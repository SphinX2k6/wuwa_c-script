using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Core.Common;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003504 RID: 13572
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCharacterInteraction : IStaticVariableResetter
	{
		// Token: 0x060228B6 RID: 141494 RVA: 0x009CF3B7 File Offset: 0x009CD5B7
		static SceneCharacterInteraction()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneCharacterInteraction.CreateStaticDefaultValue), new Action(SceneCharacterInteraction.ResetStaticDefaultValue));
		}

		// Token: 0x060228B7 RID: 141495 RVA: 0x009CF3EB File Offset: 0x009CD5EB
		public void SetInWater()
		{
			this.IsInWaterOrOnMaterial = true;
			this.PhysicalMaterial = null;
		}

		// Token: 0x060228B8 RID: 141496 RVA: 0x009CF3FB File Offset: 0x009CD5FB
		[NullableContext(1)]
		public void SetOnMaterial(UPhysicalMaterial physicalMaterial)
		{
			this.IsInWaterOrOnMaterial = true;
			this.PhysicalMaterial = physicalMaterial;
		}

		// Token: 0x060228B9 RID: 141497 RVA: 0x009CF40B File Offset: 0x009CD60B
		public bool GetInWater()
		{
			return this.IsInWaterOrOnMaterial && this.PhysicalMaterial == null;
		}

		// Token: 0x060228BA RID: 141498 RVA: 0x009CF420 File Offset: 0x009CD620
		public bool GetInAudioShr()
		{
			return this.IsInAudioShr;
		}

		// Token: 0x060228BB RID: 141499 RVA: 0x009CF428 File Offset: 0x009CD628
		public FName GetAudioShrTag()
		{
			return this.AudioShrTag.Value;
		}

		// Token: 0x060228BC RID: 141500 RVA: 0x009CF435 File Offset: 0x009CD635
		public double GetWaterHitLocationZ()
		{
			if (!(this.EnviInteractionData != null))
			{
				return double.NegativeInfinity;
			}
			return (double)this.EnviInteractionData.HitWaterLocation.Z;
		}

		// Token: 0x060228BD RID: 141501 RVA: 0x009CF460 File Offset: 0x009CD660
		public double GetWaterHeight()
		{
			return this.WaterHeight;
		}

		// Token: 0x060228BE RID: 141502 RVA: 0x009CF468 File Offset: 0x009CD668
		public double GetWaterDepth()
		{
			if (this.UseCppCheck)
			{
				return (double)((this.EnviInteractionData != null) ? this.EnviInteractionData.WaterDepth : 0f);
			}
			return this.WaterHeight - (this.TsActorLocation.Z - this.CapsuleHalfHeight);
		}

		// Token: 0x060228BF RID: 141503 RVA: 0x009CF4B8 File Offset: 0x009CD6B8
		[NullableContext(1)]
		public void Start(TsBaseCharacter owner, PDA_InteractionPlayerConfig_C config, float updateInternalScale = 1f)
		{
			this.OwnerCharacter = owner;
			this.UpdateWaterStateInternalScale = updateInternalScale;
			if (config != null)
			{
				this.Config = config;
				this.Init();
				this.Enable();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.LSY;
			string message = ": 创建了没有配置的交互控制";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.OwnerCharacter);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x17004865 RID: 18533
		// (get) Token: 0x060228C0 RID: 141504 RVA: 0x009CF518 File Offset: 0x009CD718
		// (set) Token: 0x060228C1 RID: 141505 RVA: 0x009CF520 File Offset: 0x009CD720
		private protected Vector TempVector { protected get; private set; }

		// Token: 0x060228C2 RID: 141506 RVA: 0x009CF52C File Offset: 0x009CD72C
		[NullableContext(1)]
		private FName FindAudioShrubTagFromComp(UStaticMesh staticMesh)
		{
			for (int i = 0; i < staticMesh.Tags.Num(); i++)
			{
				string text = staticMesh.Tags.Get(i).ToString();
				if (text.StartsWith("Audio_", StringComparison.Ordinal))
				{
					return new FName(text.Substring("Audio_".Length));
				}
			}
			return FNameUtil.NONE;
		}

		// Token: 0x060228C3 RID: 141507 RVA: 0x009CF594 File Offset: 0x009CD794
		public void Update(float deltaSeconds)
		{
			if (!this.IsEnable)
			{
				return;
			}
			this.UseCppCheck = (UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.InteractionEffect.UseCppWaterEffect") > 0f);
			if (this.UseCppCheck)
			{
				UKuroEnviInteractionComponent enviInteractionComponent = this.EnviInteractionComponent;
				this.EnviInteractionData = ((enviInteractionComponent != null) ? enviInteractionComponent.GetEnviInteractionData() : null);
			}
			if (this.OwnerCharacter != null && this.OwnerCharacter.IsValid())
			{
				this.ActorLocation = new FVectorDouble?(this.OwnerCharacter.D_K2_GetActorLocation());
				Vector tsPreviousActorLocation = this.TsPreviousActorLocation;
				if (tsPreviousActorLocation != null)
				{
					tsPreviousActorLocation.DeepCopy(this.TsActorLocation);
				}
				Vector tsActorLocation = this.TsActorLocation;
				if (tsActorLocation != null)
				{
					FVectorDouble value = this.ActorLocation.Value;
					tsActorLocation.FromUeVector(value);
				}
				Vector tsActorLocation2 = this.TsActorLocation;
				if (tsActorLocation2 != null)
				{
					tsActorLocation2.Subtraction(this.TsPreviousActorLocation, this.TempVector);
				}
				Vector tempVector = this.TempVector;
				if (tempVector != null)
				{
					tempVector.Division((double)deltaSeconds, this.ActorSpeed);
				}
				bool flag = true;
				this.UpdateWaterStateCounter -= deltaSeconds;
				if (this.UpdateWaterStateCounter > 0f)
				{
					flag = false;
				}
				else
				{
					this.UpdateWaterStateCounter = this.UpdateWaterStateInternal;
				}
				if (this.UseCppCheck)
				{
					flag = true;
				}
				if (this.WaterEffect != null)
				{
					if (flag)
					{
						this.CheckInWater(deltaSeconds);
						double num = this.TsActorLocation.Z - this.CapsuleHalfHeight;
						if (this.EnviInteractionData != null)
						{
							this.WaterEffect.SetWaterDataEnviDataCheckFly(this.EnviInteractionData, this.TsActorLocation, this.ActorSpeed);
						}
						if (this.IsInWaterOrOnMaterial)
						{
							if (this.PhysicalMaterial == null)
							{
								if (this.UseCppCheck)
								{
									this.WaterEffect.SetStateInWaterEnviData(this.EnviInteractionData, this.ActorSpeed, this.TsActorLocation);
								}
								else
								{
									this.WaterEffect.SetStateInWater(this.WaterHeight - num, this.WaterNormal, this.ActorSpeed, this.TsActorLocation, this.WaterHeight);
								}
							}
							else if (this.UseCppCheck)
							{
								this.WaterEffect.SetStateOnMaterialEnviData(this.PhysicalMaterial, this.ActorSpeed, this.TsActorLocation, this.EnviInteractionData);
							}
							else
							{
								this.WaterEffect.SetStateOnMaterial(this.PhysicalMaterial, this.WaterHeight - num, this.WaterNormal, this.ActorSpeed, this.TsActorLocation, this.WaterHeight);
							}
						}
						else
						{
							this.WaterEffect.SetStateNone(this.ActorSpeed);
						}
					}
					this.WaterEffect.Tick();
				}
				if (this.TriggerEffect != null && this.EnviInteractionData != null)
				{
					this.TriggerEffect.Data = this.EnviInteractionData;
					this.TriggerEffect.Tick();
				}
				if (this.FoliageEffect != null)
				{
					this.FoliageEffect.Tick(deltaSeconds);
				}
				this.IsInAudioShr = false;
				this.AudioShrTag = new FName?(FNameUtil.NONE);
				if (this.EnviInteractionData != null && this.EnviInteractionData.bHitAudioShrub && this.EnviInteractionData.AudioShrubStaticMeshComp != null && this.EnviInteractionData.AudioShrubStaticMeshComp.GetCollisionProfileName().Equals(SceneCharacterInteraction.NoCollisionProfileName))
				{
					this.IsInAudioShr = true;
					UStaticMesh staticMesh = this.EnviInteractionData.AudioShrubStaticMeshComp.StaticMesh;
					this.AudioShrTag = new FName?((staticMesh != null) ? this.FindAudioShrubTagFromComp(staticMesh) : FNameUtil.NONE);
				}
			}
		}

		// Token: 0x060228C4 RID: 141508 RVA: 0x009CF8D0 File Offset: 0x009CDAD0
		public void Init()
		{
			TsBaseCharacter ownerCharacter = this.OwnerCharacter;
			if (((ownerCharacter != null) ? ownerCharacter.CapsuleComponent : null) != null)
			{
				this.CapsuleHalfHeight = (double)this.OwnerCharacter.CapsuleComponent.CapsuleHalfHeight;
				this.WaterEffect = new SceneCharacterWaterEffect();
				this.WaterEffect.Config = this.Config.水特效;
				this.WaterEffect.Start(this.OwnerCharacter);
				this.WaterEffect.Enable();
				if (!Info.Instance.IsMobilePlatform())
				{
					this.TriggerEffect = new SceneCharacterTriggerEffect();
					this.TriggerEffect.Start(this.OwnerCharacter);
					this.TriggerEffect.Enable();
					this.FoliageEffect = new SceneCharacterFoliageEffect();
					this.FoliageEffect.Start(this.OwnerCharacter);
					this.FoliageEffect.Enable();
				}
			}
			bool flag = true;
			this.IsEnable = false;
			this.TempVector = Vector.Create();
			this.ActorSpeed = Vector.Create();
			if (this.OwnerCharacter != null)
			{
				this.ActorLocation = new FVectorDouble?(this.OwnerCharacter.D_K2_GetActorLocation());
				this.TsActorLocation = Vector.Create(this.ActorLocation.Value);
				this.TsPreviousActorLocation = Vector.Create(this.ActorLocation.Value);
			}
			if (flag)
			{
				this.UpdateWaterStateInternal = this.UpdateWaterStateInternalPc;
			}
			this.UpdateWaterStateInternal *= this.UpdateWaterStateInternalScale;
		}

		// Token: 0x060228C5 RID: 141509 RVA: 0x009CFA38 File Offset: 0x009CDC38
		public void Enable()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "交互配置启用";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.OwnerCharacter);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			SceneCharacterInteraction.InitTraceInfo();
			this.IsEnable = true;
			if (this.OwnerCharacter != null)
			{
				this.EnviInteractionComponent = (this.OwnerCharacter.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) as UKuroEnviInteractionComponent);
			}
			if (this.EnviInteractionComponent != null)
			{
				this.EnviInteractionComponent.bUpdateWaterEID = true;
				this.EnviInteractionComponent.bUpdateRainOcclusion = true;
			}
			TsBaseCharacter ownerCharacter = this.OwnerCharacter;
			if (((ownerCharacter != null) ? ownerCharacter.CapsuleComponent : null) != null)
			{
				this.CheckInWater(0f);
			}
		}

		// Token: 0x060228C6 RID: 141510 RVA: 0x009CFAE4 File Offset: 0x009CDCE4
		public void Disable()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "交互配置禁用";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.OwnerCharacter);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.IsEnable = false;
			this.ClearInWaterOrOnMaterialState();
			SceneCharacterWaterEffect waterEffect = this.WaterEffect;
			if (waterEffect != null)
			{
				waterEffect.Disable();
			}
			SceneCharacterTriggerEffect triggerEffect = this.TriggerEffect;
			if (triggerEffect != null)
			{
				triggerEffect.Disable();
			}
			SceneCharacterFoliageEffect foliageEffect = this.FoliageEffect;
			if (foliageEffect != null)
			{
				foliageEffect.Disable();
			}
			if (this.EnviInteractionComponent != null)
			{
				this.EnviInteractionComponent.bUpdateWaterEID = false;
				this.EnviInteractionComponent.bUpdateRainOcclusion = false;
			}
		}

		// Token: 0x060228C7 RID: 141511 RVA: 0x009CFB7D File Offset: 0x009CDD7D
		public bool GetEnabled()
		{
			return this.IsEnable;
		}

		// Token: 0x060228C8 RID: 141512 RVA: 0x009CFB85 File Offset: 0x009CDD85
		public void Destroy()
		{
			this.Disable();
		}

		// Token: 0x060228C9 RID: 141513 RVA: 0x009CFB8D File Offset: 0x009CDD8D
		public void ClearInWaterOrOnMaterialState()
		{
			this.IsInWaterOrOnMaterial = false;
			this.PhysicalMaterial = null;
		}

		// Token: 0x060228CA RID: 141514 RVA: 0x009CFBA0 File Offset: 0x009CDDA0
		private static void InitTraceInfo()
		{
			UTraceSphereElement utraceSphereElement = new UTraceSphereElement();
			utraceSphereElement.WorldContextObject = GlobalData.World;
			utraceSphereElement.bIsSingle = false;
			utraceSphereElement.bIgnoreSelf = true;
			utraceSphereElement.Radius = 1f;
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			tarray.Add(KuroObjectTypeQuery.WorldStatic);
			tarray.Add(KuroObjectTypeQuery.KuroWater);
			utraceSphereElement.SetObjectTypesQuery(ref tarray);
			utraceSphereElement.DrawTime = 10f;
			TraceElementCommon.Instance.SetTraceColor(utraceSphereElement, ColorUtils.LinearGreen);
			TraceElementCommon.Instance.SetTraceHitColor(utraceSphereElement, ColorUtils.LinearRed);
			utraceSphereElement.SetDrawDebugTrace(EDrawDebugTrace.None);
			SceneCharacterInteraction.SphereTrace = utraceSphereElement;
		}

		// Token: 0x060228CB RID: 141515 RVA: 0x009CFC3D File Offset: 0x009CDE3D
		public static void SetTraceDebug(bool enable)
		{
			if (SceneCharacterInteraction.SphereTrace != null)
			{
				SceneCharacterInteraction.SphereTrace.SetDrawDebugTrace(enable ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
			}
		}

		// Token: 0x060228CC RID: 141516 RVA: 0x009CFC58 File Offset: 0x009CDE58
		protected void CheckInWater(float delta)
		{
			if (this.UseCppCheck)
			{
				if (this.EnviInteractionData != null)
				{
					FVectorDouble fvectorDouble = this.OwnerCharacter.CapsuleComponent.D_K2_GetComponentLocation();
					this.WaterHeight = Vector.Distance(Vector.Create(this.EnviInteractionData.HitWaterLocation), Vector.Create(fvectorDouble));
					this.WaterNormal = Vector.Create(this.EnviInteractionData.HitWaterNormal);
					if (this.EnviInteractionData.bInWater)
					{
						this.SetInWater();
						return;
					}
					if (this.EnviInteractionData.HitPhysicMaterial == null)
					{
						UPhysicalMaterial globalFootstepMaterial = RenderDataManager.Instance.GetGlobalFootstepMaterial();
						this.EnviInteractionData.HitPhysicMaterial = globalFootstepMaterial;
					}
					if (this.EnviInteractionData.HitPhysicMaterial != null)
					{
						SceneCharacterWaterEffect waterEffect = this.WaterEffect;
						if (waterEffect != null && waterEffect.IsMaterialInUse(this.EnviInteractionData.HitPhysicMaterial))
						{
							this.SetOnMaterial(this.EnviInteractionData.HitPhysicMaterial);
							return;
						}
					}
				}
				this.ClearInWaterOrOnMaterialState();
				return;
			}
			PDA_InteractionPlayerConfig_C config = this.Config;
			if (config != null && config.启用水面交互)
			{
				if (SceneCharacterInteraction.SphereTrace == null)
				{
					SceneCharacterInteraction.InitTraceInfo();
				}
				UCapsuleComponent capsuleComponent = this.OwnerCharacter.CapsuleComponent;
				FVectorDouble fvectorDouble2 = capsuleComponent.D_K2_GetComponentLocation();
				FVectorDouble fvectorDouble3 = new FVectorDouble(0.0, 0.0, (double)capsuleComponent.CapsuleHalfHeight);
				FVectorDouble fvectorDouble4 = new FVectorDouble(0.0, 0.0, (double)(-(double)capsuleComponent.CapsuleHalfHeight - this.Config.射线向下延长));
				Vector location = Vector.Create(fvectorDouble2.X + fvectorDouble3.X, fvectorDouble2.Y + fvectorDouble3.Y, fvectorDouble2.Z + fvectorDouble3.Z);
				Vector location2 = Vector.Create(fvectorDouble2.X + fvectorDouble4.X, fvectorDouble2.Y + fvectorDouble4.Y, fvectorDouble2.Z + fvectorDouble4.Z);
				TraceElementCommon.Instance.SetStartLocation(SceneCharacterInteraction.SphereTrace, location);
				TraceElementCommon.Instance.SetEndLocation(SceneCharacterInteraction.SphereTrace, location2);
				bool flag = TraceElementCommon.Instance.SphereTrace(SceneCharacterInteraction.SphereTrace, "SceneCharacterInteraction_CheckInWater");
				UTraceSphereElement sphereTrace = SceneCharacterInteraction.SphereTrace;
				UKuroHitResult ukuroHitResult = (sphereTrace != null) ? sphereTrace.HitResult : null;
				if (flag && ukuroHitResult != null && ukuroHitResult.bBlockingHit)
				{
					int hitCount = ukuroHitResult.GetHitCount();
					UPhysicalMaterial globalFootstepMaterial2 = RenderDataManager.Instance.GetGlobalFootstepMaterial();
					for (int i = 0; i < hitCount; i++)
					{
						UPrimitiveComponent uprimitiveComponent = ukuroHitResult.Components.Get(i).Get();
						TEnumAsByte<ECollisionResponse>? tenumAsByte = (uprimitiveComponent != null) ? new TEnumAsByte<ECollisionResponse>?(uprimitiveComponent.BodyInstance.CollisionResponses.ResponseToChannels.GameTraceChannel2) : null;
						int? num = (tenumAsByte != null) ? new int?((int)tenumAsByte.GetValueOrDefault()) : null;
						int num2 = 2;
						if (num.GetValueOrDefault() == num2 & num != null)
						{
							this.WaterHeight = (double)ukuroHitResult.LocationZ_Array.Get(i);
							this.WaterNormal = Vector.Create((double)ukuroHitResult.ImpactNormalX_Array.Get(i), (double)ukuroHitResult.ImpactNormalY_Array.Get(i), (double)ukuroHitResult.ImpactNormalZ_Array.Get(i));
							this.SetInWater();
							return;
						}
						UPrimitiveComponent uprimitiveComponent2 = ukuroHitResult.Components.Get(i).Get();
						if (uprimitiveComponent2 is ULandscapeHeightfieldCollisionComponent)
						{
							this.PhysicalMaterial = ukuroHitResult.PhysMaterials.Get(i);
							if (this.PhysicalMaterial == null || !this.WaterEffect.IsMaterialInUse(this.PhysicalMaterial))
							{
								this.PhysicalMaterial = globalFootstepMaterial2;
							}
						}
						else
						{
							tenumAsByte = ((uprimitiveComponent2 != null) ? new TEnumAsByte<ECollisionResponse>?(uprimitiveComponent2.BodyInstance.CollisionResponses.ResponseToChannels.WorldStatic) : null);
							num = ((tenumAsByte != null) ? new int?((int)tenumAsByte.GetValueOrDefault()) : null);
							num2 = 2;
							if (num.GetValueOrDefault() == num2 & num != null)
							{
								this.PhysicalMaterial = UKuroRenderingRuntimeBPPluginBPLibrary.GetComponentPhysicalMaterial(uprimitiveComponent2);
								if (this.PhysicalMaterial == null || !this.WaterEffect.IsMaterialInUse(this.PhysicalMaterial))
								{
									this.PhysicalMaterial = globalFootstepMaterial2;
								}
							}
						}
						if (this.PhysicalMaterial != null && this.WaterEffect.IsMaterialInUse(this.PhysicalMaterial))
						{
							this.WaterHeight = (double)ukuroHitResult.LocationZ_Array.Get(i);
							this.WaterNormal = Vector.Create((double)ukuroHitResult.ImpactNormalX_Array.Get(i), (double)ukuroHitResult.ImpactNormalY_Array.Get(i), (double)ukuroHitResult.ImpactNormalZ_Array.Get(i));
							this.SetOnMaterial(this.PhysicalMaterial);
							return;
						}
						tenumAsByte = ((uprimitiveComponent2 != null) ? new TEnumAsByte<ECollisionResponse>?(uprimitiveComponent2.BodyInstance.CollisionResponses.ResponseToChannels.WorldStatic) : null);
						num = ((tenumAsByte != null) ? new int?((int)tenumAsByte.GetValueOrDefault()) : null);
						num2 = 2;
						if (num.GetValueOrDefault() == num2 & num != null)
						{
							break;
						}
					}
				}
				this.ClearInWaterOrOnMaterialState();
			}
		}

		// Token: 0x060228CD RID: 141517 RVA: 0x009D0188 File Offset: 0x009CE388
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060228CE RID: 141518 RVA: 0x009D018A File Offset: 0x009CE38A
		public static void ResetStaticDefaultValue()
		{
			SceneCharacterInteraction.SphereTrace = null;
		}

		// Token: 0x040131B2 RID: 78258
		public TsBaseCharacter OwnerCharacter;

		// Token: 0x040131B3 RID: 78259
		public UKuroEnviInteractionComponent EnviInteractionComponent;

		// Token: 0x040131B4 RID: 78260
		public FVectorDouble? ActorLocation;

		// Token: 0x040131B5 RID: 78261
		public Vector TsActorLocation;

		// Token: 0x040131B6 RID: 78262
		public Vector TsPreviousActorLocation;

		// Token: 0x040131B7 RID: 78263
		public Vector ActorSpeed;

		// Token: 0x040131B8 RID: 78264
		protected PDA_InteractionPlayerConfig_C Config;

		// Token: 0x040131B9 RID: 78265
		protected SceneCharacterWaterEffect WaterEffect;

		// Token: 0x040131BA RID: 78266
		protected SceneCharacterTriggerEffect TriggerEffect;

		// Token: 0x040131BB RID: 78267
		protected SceneCharacterFoliageEffect FoliageEffect;

		// Token: 0x040131BC RID: 78268
		protected double CapsuleHalfHeight;

		// Token: 0x040131BD RID: 78269
		protected bool IsEnable;

		// Token: 0x040131BE RID: 78270
		protected bool IsInWaterOrOnMaterial;

		// Token: 0x040131BF RID: 78271
		protected bool IsInAudioShr;

		// Token: 0x040131C0 RID: 78272
		protected FName? AudioShrTag;

		// Token: 0x040131C1 RID: 78273
		protected UPhysicalMaterial PhysicalMaterial;

		// Token: 0x040131C2 RID: 78274
		protected double WaterHeight;

		// Token: 0x040131C3 RID: 78275
		protected Vector WaterNormal;

		// Token: 0x040131C4 RID: 78276
		protected float UpdateWaterStateInternal = 0.3f;

		// Token: 0x040131C5 RID: 78277
		protected float UpdateWaterStateInternalPc = 0.15f;

		// Token: 0x040131C6 RID: 78278
		protected float UpdateWaterStateInternalScale = 1f;

		// Token: 0x040131C7 RID: 78279
		protected float UpdateWaterStateCounter;

		// Token: 0x040131C8 RID: 78280
		protected bool UseCppCheck;

		// Token: 0x040131C9 RID: 78281
		protected FKuroEnviInteractionData EnviInteractionData;

		// Token: 0x040131CA RID: 78282
		private static readonly FName NoCollisionProfileName = new FName("NoCollision");

		// Token: 0x040131CB RID: 78283
		[Nullable(1)]
		private const string PROFILE_KEY = "SceneCharacterInteraction_CheckInWater";

		// Token: 0x040131CC RID: 78284
		[Nullable(1)]
		private const string AUDIO_TAG_PREFIX = "Audio_";

		// Token: 0x040131CE RID: 78286
		private static UTraceSphereElement SphereTrace = null;

		// Token: 0x040131CF RID: 78287
		private const bool DebugWaterTrace = false;
	}
}
