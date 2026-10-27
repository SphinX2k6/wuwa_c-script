using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045E7 RID: 17895
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneObjectWaterEffect
	{
		// Token: 0x0602E26C RID: 189036 RVA: 0x00AA97E4 File Offset: 0x00AA79E4
		private void InitTraceInfo()
		{
			UTraceSphereElement utraceSphereElement = new UTraceSphereElement();
			utraceSphereElement.WorldContextObject = GlobalData.World;
			utraceSphereElement.bIsSingle = false;
			utraceSphereElement.bIgnoreSelf = true;
			utraceSphereElement.Radius = this.Radius;
			utraceSphereElement.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
			if (EffectGlobal.Instance.SceneObjectWaterEffectShowDebugTrace)
			{
				utraceSphereElement.DrawTime = 5f;
				TraceElementCommon.Instance.SetTraceColor(utraceSphereElement, ColorUtils.LinearGreen);
				TraceElementCommon.Instance.SetTraceHitColor(utraceSphereElement, ColorUtils.LinearRed);
				utraceSphereElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			}
			else
			{
				utraceSphereElement.SetDrawDebugTrace(EDrawDebugTrace.None);
			}
			this.SphereTrace = utraceSphereElement;
		}

		// Token: 0x0602E26D RID: 189037 RVA: 0x00AA9878 File Offset: 0x00AA7A78
		public void Start(SWaterEffectObject config, USceneComponent actorToAttach)
		{
			if (config == null || actorToAttach == null)
			{
				return;
			}
			this.Config = config;
			this.ActorToAttach = actorToAttach;
			this.Radius = this.Config.Radius;
			FTransformDouble value = UKismetMathLibrary.Conv_TransformToTransformDouble(this.Config.Transform);
			this.Transform = new FTransformDouble?(value);
			this.Effect = this.Config.Effect.ToAssetPathName();
			this.TriggerOnce = this.Config.TriggerOnce;
			this.EnableSurfaceEffect = this.Config.EnableSurfaceEffect;
			this.TimeAfterSurfaceEffectStop = this.Config.TimeAfterSurfaceEffectStop;
			if (!this.TriggerOnce && this.EnableSurfaceEffect)
			{
				this.WaterSurfaceEffect = this.Config.WaterSurfaceEffect.ToAssetPathName();
			}
			this.TempUeVector = new FVector?(new FVector());
			this.TempVector = Vector.Create();
			this.TempVector1 = Vector.Create();
			this.TempPosition = Vector.Create();
			this.LastPosition = Vector.Create();
			this.IsReady = true;
			this.InitTraceInfo();
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.LSY, "SceneObjectWaterEffect Start", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602E26E RID: 189038 RVA: 0x00AA99A4 File Offset: 0x00AA7BA4
		protected void GetActorLocation()
		{
			Vector tempVector = this.TempVector;
			FVectorDouble fvectorDouble = this.ActorToAttach.D_K2_GetComponentLocation();
			tempVector.FromUeVector(fvectorDouble);
		}

		// Token: 0x0602E26F RID: 189039 RVA: 0x00AA99CA File Offset: 0x00AA7BCA
		public void AfterRegistered()
		{
			if (!this.IsReady)
			{
				return;
			}
			this.WasHitWater = false;
			this.GetActorLocation();
			this.LastPosition.DeepCopy(this.TempVector);
			this.IsEnabled = true;
		}

		// Token: 0x0602E270 RID: 189040 RVA: 0x00AA99FA File Offset: 0x00AA7BFA
		public void BeforeUnregistered()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			this.StopEffect();
			this.IsEnabled = false;
		}

		// Token: 0x0602E271 RID: 189041 RVA: 0x00AA9A14 File Offset: 0x00AA7C14
		public void Update(float deltaSeconds)
		{
			if (this.IsEnabled)
			{
				USceneComponent actorToAttach = this.ActorToAttach;
				if (actorToAttach != null && actorToAttach.IsValid())
				{
					bool flag = false;
					this.GetActorLocation();
					UTraceSphereElement sphereTrace = this.SphereTrace;
					TraceElementCommon.Instance.SetStartLocation(sphereTrace, this.LastPosition);
					TraceElementCommon.Instance.SetEndLocation(sphereTrace, this.TempVector);
					bool flag2 = TraceElementCommon.Instance.SphereTrace(sphereTrace, "SceneObjectWaterEffect_Update");
					UKuroHitResult hitResult = sphereTrace.HitResult;
					if (flag2 && hitResult != null)
					{
						UKuroHitResult ukuroHitResult = hitResult;
						if (ukuroHitResult.bBlockingHit)
						{
							int hitCount = ukuroHitResult.GetHitCount();
							for (int i = 0; i < hitCount; i++)
							{
								FName collisionProfileName = UKuroCollisionLibrary.GetCollisionProfileName(ukuroHitResult.Components.Get(i), i);
								if (RenderConfig.WaterCollisionProfileName == collisionProfileName)
								{
									this.WaterHeight = (double)ukuroHitResult.ImpactPointZ_Array.Get(i);
									this.TempPosition.DeepCopy(this.TempVector);
									this.TempPosition.Z = this.WaterHeight;
									flag = true;
									break;
								}
							}
						}
					}
					if (flag != this.WasHitWater)
					{
						this.SpawnFallEffect(this.Effect, this.TempPosition);
						if (this.TriggerOnce)
						{
							this.StopEffect();
							this.IsEnabled = false;
						}
					}
					if (this.EnableSurfaceEffect && flag && this.WasHitWater)
					{
						if (!EffectSystem.Instance.IsValid(this.SurfaceHandle))
						{
							this.SpawnEffect(this.WaterSurfaceEffect);
						}
						if (EffectSystem.Instance.IsValid(this.SurfaceHandle))
						{
							this.TempVector.Subtraction(this.LastPosition, this.TempVector1);
							float time = (float)(this.TempVector1.Size() / (double)deltaSeconds);
							EffectSystem.Instance.HandleSeekToTime(this.SurfaceHandle, time, false, false);
							FHitResult fhitResult = new FHitResult();
							OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.SurfaceHandle);
							FVectorDouble fvectorDouble = this.TempPosition.ToUeVector(false);
							effectActor.D_K2_SetActorLocation(fvectorDouble, false, ref fhitResult, true);
						}
					}
					else if (this.SurfaceHandle != 0)
					{
						this.StopEffect();
					}
					this.WasHitWater = flag;
					this.LastPosition.DeepCopy(this.TempVector);
					return;
				}
			}
		}

		// Token: 0x0602E272 RID: 189042 RVA: 0x00AA9C2C File Offset: 0x00AA7E2C
		public void StopEffect()
		{
			if (EffectSystem.Instance.IsValid(this.SurfaceHandle))
			{
				EffectSystem.Instance.HandleSeekToTime(this.SurfaceHandle, 0f, false, false);
				EffectSystem.Instance.SetHandleLifeCycle(this.SurfaceHandle, this.TimeAfterSurfaceEffectStop);
			}
			this.SurfaceHandle = 0;
		}

		// Token: 0x0602E273 RID: 189043 RVA: 0x00AA9C80 File Offset: 0x00AA7E80
		[NullableContext(1)]
		protected void SpawnEffect(string effectDataPath)
		{
			if (string.IsNullOrEmpty(effectDataPath))
			{
				return;
			}
			this.StopEffect();
			this.SurfaceHandle = EffectSystem.Instance.SpawnEffect(GlobalData.World, this.Transform, effectDataPath, "[SceneObjectWaterEffect.SpawnEffect]", null, EEffectType.Scene, delegate(int handle)
			{
				EffectSystem.Instance.FreezeHandle(handle, true, false);
				EffectSystem.Instance.SetHandleLifeCycle(this.SurfaceHandle, 10f);
			}, null, null, false, false);
		}

		// Token: 0x0602E274 RID: 189044 RVA: 0x00AA9CD0 File Offset: 0x00AA7ED0
		[NullableContext(1)]
		protected void SpawnFallEffect(string effectDataPath, Vector location)
		{
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref fvectorDouble));
			this.Handle = instance.SpawnUnloopedEffect(world, ftransformDouble, effectDataPath, "[SceneObjectWaterEffect.SpawnFallEffect]", null, EEffectType.Scene, null, null, null, false, false);
		}

		// Token: 0x04018C31 RID: 101425
		[Nullable(1)]
		private const string PROFILE_KEY = "SceneObjectWaterEffect_Update";

		// Token: 0x04018C32 RID: 101426
		public SWaterEffectObject Config;

		// Token: 0x04018C33 RID: 101427
		public USceneComponent ActorToAttach;

		// Token: 0x04018C34 RID: 101428
		public bool IsReady;

		// Token: 0x04018C35 RID: 101429
		protected float Radius;

		// Token: 0x04018C36 RID: 101430
		protected FTransformDouble? Transform;

		// Token: 0x04018C37 RID: 101431
		[Nullable(1)]
		protected string Effect = "";

		// Token: 0x04018C38 RID: 101432
		protected bool TriggerOnce;

		// Token: 0x04018C39 RID: 101433
		protected bool EnableSurfaceEffect;

		// Token: 0x04018C3A RID: 101434
		[Nullable(1)]
		protected string WaterSurfaceEffect = "";

		// Token: 0x04018C3B RID: 101435
		protected float TimeAfterSurfaceEffectStop;

		// Token: 0x04018C3C RID: 101436
		private UTraceSphereElement SphereTrace;

		// Token: 0x04018C3D RID: 101437
		protected int Handle;

		// Token: 0x04018C3E RID: 101438
		protected int SurfaceHandle;

		// Token: 0x04018C3F RID: 101439
		protected bool WasHitWater;

		// Token: 0x04018C40 RID: 101440
		protected Vector LastPosition;

		// Token: 0x04018C41 RID: 101441
		protected double WaterHeight;

		// Token: 0x04018C42 RID: 101442
		protected FVector? TempUeVector;

		// Token: 0x04018C43 RID: 101443
		protected Vector TempVector;

		// Token: 0x04018C44 RID: 101444
		protected Vector TempVector1;

		// Token: 0x04018C45 RID: 101445
		protected Vector TempPosition;

		// Token: 0x04018C46 RID: 101446
		public bool IsEnabled;
	}
}
