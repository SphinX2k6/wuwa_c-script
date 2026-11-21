using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003510 RID: 13584
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneObjectWaterEffect
	{
		// Token: 0x06022961 RID: 141665 RVA: 0x009D5F7C File Offset: 0x009D417C
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

		// Token: 0x06022962 RID: 141666 RVA: 0x009D6010 File Offset: 0x009D4210
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

		// Token: 0x06022963 RID: 141667 RVA: 0x009D613C File Offset: 0x009D433C
		protected void GetActorLocation()
		{
			Vector tempVector = this.TempVector;
			FVectorDouble fvectorDouble = this.ActorToAttach.D_K2_GetComponentLocation();
			tempVector.FromUeVector(fvectorDouble);
		}

		// Token: 0x06022964 RID: 141668 RVA: 0x009D6162 File Offset: 0x009D4362
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

		// Token: 0x06022965 RID: 141669 RVA: 0x009D6192 File Offset: 0x009D4392
		public void BeforeUnregistered()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			this.StopEffect();
			this.IsEnabled = false;
		}

		// Token: 0x06022966 RID: 141670 RVA: 0x009D61AC File Offset: 0x009D43AC
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

		// Token: 0x06022967 RID: 141671 RVA: 0x009D63C4 File Offset: 0x009D45C4
		public void StopEffect()
		{
			if (EffectSystem.Instance.IsValid(this.SurfaceHandle))
			{
				EffectSystem.Instance.HandleSeekToTime(this.SurfaceHandle, 0f, false, false);
				EffectSystem.Instance.SetHandleLifeCycle(this.SurfaceHandle, this.TimeAfterSurfaceEffectStop);
			}
			this.SurfaceHandle = 0;
		}

		// Token: 0x06022968 RID: 141672 RVA: 0x009D6418 File Offset: 0x009D4618
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

		// Token: 0x06022969 RID: 141673 RVA: 0x009D6468 File Offset: 0x009D4668
		[NullableContext(1)]
		protected void SpawnFallEffect(string effectDataPath, Vector location)
		{
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref fvectorDouble));
			this.Handle = instance.SpawnUnloopedEffect(world, ftransformDouble, effectDataPath, "[SceneObjectWaterEffect.SpawnFallEffect]", null, EEffectType.Scene, null, null, null, false, false);
		}

		// Token: 0x04013270 RID: 78448
		[Nullable(1)]
		private const string PROFILE_KEY = "SceneObjectWaterEffect_Update";

		// Token: 0x04013271 RID: 78449
		public SWaterEffectObject Config;

		// Token: 0x04013272 RID: 78450
		public USceneComponent ActorToAttach;

		// Token: 0x04013273 RID: 78451
		public bool IsReady;

		// Token: 0x04013274 RID: 78452
		protected float Radius;

		// Token: 0x04013275 RID: 78453
		protected FTransformDouble? Transform;

		// Token: 0x04013276 RID: 78454
		[Nullable(1)]
		protected string Effect = "";

		// Token: 0x04013277 RID: 78455
		protected bool TriggerOnce;

		// Token: 0x04013278 RID: 78456
		protected bool EnableSurfaceEffect;

		// Token: 0x04013279 RID: 78457
		[Nullable(1)]
		protected string WaterSurfaceEffect = "";

		// Token: 0x0401327A RID: 78458
		protected float TimeAfterSurfaceEffectStop;

		// Token: 0x0401327B RID: 78459
		private UTraceSphereElement SphereTrace;

		// Token: 0x0401327C RID: 78460
		protected int Handle;

		// Token: 0x0401327D RID: 78461
		protected int SurfaceHandle;

		// Token: 0x0401327E RID: 78462
		protected bool WasHitWater;

		// Token: 0x0401327F RID: 78463
		protected Vector LastPosition;

		// Token: 0x04013280 RID: 78464
		protected double WaterHeight;

		// Token: 0x04013281 RID: 78465
		protected FVector? TempUeVector;

		// Token: 0x04013282 RID: 78466
		protected Vector TempVector;

		// Token: 0x04013283 RID: 78467
		protected Vector TempVector1;

		// Token: 0x04013284 RID: 78468
		protected Vector TempPosition;

		// Token: 0x04013285 RID: 78469
		public bool IsEnabled;
	}
}
