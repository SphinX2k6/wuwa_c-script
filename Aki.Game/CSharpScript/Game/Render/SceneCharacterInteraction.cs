using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Core.Common;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045DB RID: 17883
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCharacterInteraction : IStaticVariableResetter
	{
		// Token: 0x0602E1C2 RID: 188866 RVA: 0x00AA2CDB File Offset: 0x00AA0EDB
		static SceneCharacterInteraction()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneCharacterInteraction.CreateStaticDefaultValue), new Action(SceneCharacterInteraction.ResetStaticDefaultValue));
		}

		// Token: 0x0602E1C3 RID: 188867 RVA: 0x00AA2D0F File Offset: 0x00AA0F0F
		public void SetInWater()
		{
			this.IsInWaterOrOnMaterial = true;
			this.PhysicalMaterial = null;
		}

		// Token: 0x0602E1C4 RID: 188868 RVA: 0x00AA2D1F File Offset: 0x00AA0F1F
		[NullableContext(1)]
		public void SetOnMaterial(UPhysicalMaterial physicalMaterial)
		{
			this.IsInWaterOrOnMaterial = true;
			this.PhysicalMaterial = physicalMaterial;
		}

		// Token: 0x0602E1C5 RID: 188869 RVA: 0x00AA2D2F File Offset: 0x00AA0F2F
		public bool GetInWater()
		{
			return this.IsInWaterOrOnMaterial && this.PhysicalMaterial == null;
		}

		// Token: 0x0602E1C6 RID: 188870 RVA: 0x00AA2D44 File Offset: 0x00AA0F44
		public bool GetInAudioShr()
		{
			return this.IsInAudioShr;
		}

		// Token: 0x0602E1C7 RID: 188871 RVA: 0x00AA2D4C File Offset: 0x00AA0F4C
		public FName GetAudioShrTag()
		{
			return this.AudioShrTag.Value;
		}

		// Token: 0x0602E1C8 RID: 188872 RVA: 0x00AA2D59 File Offset: 0x00AA0F59
		public double GetWaterHitLocationZ()
		{
			if (!(this.EnviInteractionData != null))
			{
				return double.NegativeInfinity;
			}
			return (double)this.EnviInteractionData.HitWaterLocation.Z;
		}

		// Token: 0x0602E1C9 RID: 188873 RVA: 0x00AA2D84 File Offset: 0x00AA0F84
		public double GetWaterHeight()
		{
			return this.WaterHeight;
		}

		// Token: 0x0602E1CA RID: 188874 RVA: 0x00AA2D8C File Offset: 0x00AA0F8C
		public double GetWaterDepth()
		{
			if (this.UseCppCheck)
			{
				return (double)((this.EnviInteractionData != null) ? this.EnviInteractionData.WaterDepth : 0f);
			}
			return this.WaterHeight - (this.TsActorLocation.Z - this.CapsuleHalfHeight);
		}

		// Token: 0x0602E1CB RID: 188875 RVA: 0x00AA2DDC File Offset: 0x00AA0FDC
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

		// Token: 0x170075AD RID: 30125
		// (get) Token: 0x0602E1CC RID: 188876 RVA: 0x00AA2E3C File Offset: 0x00AA103C
		// (set) Token: 0x0602E1CD RID: 188877 RVA: 0x00AA2E44 File Offset: 0x00AA1044
		private protected Vector TempVector { protected get; private set; }

		// Token: 0x0602E1CE RID: 188878 RVA: 0x00AA2E50 File Offset: 0x00AA1050
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

		// Token: 0x0602E1CF RID: 188879 RVA: 0x00AA2EB8 File Offset: 0x00AA10B8
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

		// Token: 0x0602E1D0 RID: 188880 RVA: 0x00AA31F4 File Offset: 0x00AA13F4
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

		// Token: 0x0602E1D1 RID: 188881 RVA: 0x00AA335C File Offset: 0x00AA155C
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

		// Token: 0x0602E1D2 RID: 188882 RVA: 0x00AA3408 File Offset: 0x00AA1608
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

		// Token: 0x0602E1D3 RID: 188883 RVA: 0x00AA34A1 File Offset: 0x00AA16A1
		public bool GetEnabled()
		{
			return this.IsEnable;
		}

		// Token: 0x0602E1D4 RID: 188884 RVA: 0x00AA34A9 File Offset: 0x00AA16A9
		public void Destroy()
		{
			this.Disable();
		}

		// Token: 0x0602E1D5 RID: 188885 RVA: 0x00AA34B1 File Offset: 0x00AA16B1
		public void ClearInWaterOrOnMaterialState()
		{
			this.IsInWaterOrOnMaterial = false;
			this.PhysicalMaterial = null;
		}

		// Token: 0x0602E1D6 RID: 188886 RVA: 0x00AA34C4 File Offset: 0x00AA16C4
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

		// Token: 0x0602E1D7 RID: 188887 RVA: 0x00AA3561 File Offset: 0x00AA1761
		public static void SetTraceDebug(bool enable)
		{
			if (SceneCharacterInteraction.SphereTrace != null)
			{
				SceneCharacterInteraction.SphereTrace.SetDrawDebugTrace(enable ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
			}
		}

		// Token: 0x0602E1D8 RID: 188888 RVA: 0x00AA357C File Offset: 0x00AA177C
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

		// Token: 0x0602E1D9 RID: 188889 RVA: 0x00AA3AAC File Offset: 0x00AA1CAC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E1DA RID: 188890 RVA: 0x00AA3AAE File Offset: 0x00AA1CAE
		public static void ResetStaticDefaultValue()
		{
			SceneCharacterInteraction.SphereTrace = null;
		}

		// Token: 0x04018B74 RID: 101236
		public TsBaseCharacter OwnerCharacter;

		// Token: 0x04018B75 RID: 101237
		public UKuroEnviInteractionComponent EnviInteractionComponent;

		// Token: 0x04018B76 RID: 101238
		public FVectorDouble? ActorLocation;

		// Token: 0x04018B77 RID: 101239
		public Vector TsActorLocation;

		// Token: 0x04018B78 RID: 101240
		public Vector TsPreviousActorLocation;

		// Token: 0x04018B79 RID: 101241
		public Vector ActorSpeed;

		// Token: 0x04018B7A RID: 101242
		protected PDA_InteractionPlayerConfig_C Config;

		// Token: 0x04018B7B RID: 101243
		protected SceneCharacterWaterEffect WaterEffect;

		// Token: 0x04018B7C RID: 101244
		protected SceneCharacterTriggerEffect TriggerEffect;

		// Token: 0x04018B7D RID: 101245
		protected SceneCharacterFoliageEffect FoliageEffect;

		// Token: 0x04018B7E RID: 101246
		protected double CapsuleHalfHeight;

		// Token: 0x04018B7F RID: 101247
		protected bool IsEnable;

		// Token: 0x04018B80 RID: 101248
		protected bool IsInWaterOrOnMaterial;

		// Token: 0x04018B81 RID: 101249
		protected bool IsInAudioShr;

		// Token: 0x04018B82 RID: 101250
		protected FName? AudioShrTag;

		// Token: 0x04018B83 RID: 101251
		protected UPhysicalMaterial PhysicalMaterial;

		// Token: 0x04018B84 RID: 101252
		protected double WaterHeight;

		// Token: 0x04018B85 RID: 101253
		protected Vector WaterNormal;

		// Token: 0x04018B86 RID: 101254
		protected float UpdateWaterStateInternal = 0.3f;

		// Token: 0x04018B87 RID: 101255
		protected float UpdateWaterStateInternalPc = 0.15f;

		// Token: 0x04018B88 RID: 101256
		protected float UpdateWaterStateInternalScale = 1f;

		// Token: 0x04018B89 RID: 101257
		protected float UpdateWaterStateCounter;

		// Token: 0x04018B8A RID: 101258
		protected bool UseCppCheck;

		// Token: 0x04018B8B RID: 101259
		protected FKuroEnviInteractionData EnviInteractionData;

		// Token: 0x04018B8C RID: 101260
		private static readonly FName NoCollisionProfileName = new FName("NoCollision");

		// Token: 0x04018B8D RID: 101261
		[Nullable(1)]
		private const string PROFILE_KEY = "SceneCharacterInteraction_CheckInWater";

		// Token: 0x04018B8E RID: 101262
		[Nullable(1)]
		private const string AUDIO_TAG_PREFIX = "Audio_";

		// Token: 0x04018B90 RID: 101264
		private static UTraceSphereElement SphereTrace = null;

		// Token: 0x04018B91 RID: 101265
		private const bool DebugWaterTrace = false;
	}
}
