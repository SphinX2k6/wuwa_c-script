using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045DD RID: 17885
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCharacterVehicleEffect
	{
		// Token: 0x0602E1E5 RID: 188901 RVA: 0x00AA4CB8 File Offset: 0x00AA2EB8
		public void Start(TsBaseCharacter owner)
		{
			if (!owner.IsValid())
			{
				return;
			}
			this.Owner = owner;
			this.IsReady = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "VehicleEffect Start";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E1E6 RID: 188902 RVA: 0x00AA4D04 File Offset: 0x00AA2F04
		public void Enable()
		{
			if (!this.IsReady)
			{
				return;
			}
			this.IsEnabled = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "WaterEffect Enabled";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E1E7 RID: 188903 RVA: 0x00AA4D50 File Offset: 0x00AA2F50
		public void Disable()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			if (EffectSystem.Instance.IsValid(this.MotorAttachHandle))
			{
				EffectSystem.Instance.StopEffectById(this.MotorAttachHandle, "[SceneCharacterWaterEffect.Disable]", true, null);
				this.MotorAttachHandle = 0;
			}
			if (EffectSystem.Instance.IsValid(this.MotorScreenHandle))
			{
				EffectSystem.Instance.StopEffectById(this.MotorScreenHandle, "[SceneCharacterWaterEffect.Disable]", true, null);
				this.MotorScreenHandle = 0;
			}
			this.MotorAttachHandlePath = "";
			this.MotorScreenHandlePath = "";
			this.IsEnabled = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "WaterEffect Disabled";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E1E8 RID: 188904 RVA: 0x00AA4E21 File Offset: 0x00AA3021
		public void Tick()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			if (!this.IsVehicleWaterState && (this.MotorAttachHandlePath == "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Putong.DA_Fx_SI3_Water_Moto_Putong" || this.MotorAttachHandlePath == "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Danqi.DA_Fx_SI3_Water_Moto_Danqi"))
			{
				this.StopMotorAttachEffect();
			}
		}

		// Token: 0x0602E1E9 RID: 188905 RVA: 0x00AA4E60 File Offset: 0x00AA3060
		[NullableContext(2)]
		public void SetStateInWaterEnviData(FKuroEnviInteractionData enviData)
		{
			if (!this.IsEnabled || enviData == null)
			{
				return;
			}
			this.EnviData = enviData;
			if (this.IsMotorState)
			{
				CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
				object obj;
				if (characterActorComponent == null)
				{
					obj = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
				}
				object obj2 = obj;
				if (obj2 != null && obj2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.冲刺"]))
				{
					if (!this.FindNoWaterPhysicalMaterial)
					{
						this.SpawnMotorAttachEffect("/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Danqi.DA_Fx_SI3_Water_Moto_Danqi");
					}
				}
				else if (this.CacheMaxSpeed > 100.0)
				{
					if (!this.FindNoWaterPhysicalMaterial)
					{
						this.SpawnMotorAttachEffect("/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Putong.DA_Fx_SI3_Water_Moto_Putong");
					}
				}
				else
				{
					this.StopMotorAttachEffect();
				}
			}
			string screenEffectPath = this.GetScreenEffectPath(enviData);
			this.UpdateMotorScreenEffect(screenEffectPath);
		}

		// Token: 0x0602E1EA RID: 188906 RVA: 0x00AA4F24 File Offset: 0x00AA3124
		[NullableContext(2)]
		public void UpdateVehicleEffectData(FKuroEnviInteractionData enviData, bool motorState, double cacheMaxSpeed, bool isBlackWave)
		{
			if (!this.IsEnabled || enviData == null || this.Owner == null)
			{
				return;
			}
			this.IsMotorState = motorState;
			this.CacheMaxSpeed = cacheMaxSpeed;
			this.IsBlackWave = isBlackWave;
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			BaseTagComponent baseTagComponent;
			if (characterActorComponent == null)
			{
				baseTagComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			string attachEffectPath = this.GetAttachEffectPath(enviData);
			if (this.IsMotorState && (baseTagComponent2 == null || !baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.状态.空中状态"])) && attachEffectPath != "")
			{
				if (this.CacheMaxSpeed > 100.0 && !enviData.bInWater)
				{
					this.SpawnMotorAttachEffect(attachEffectPath);
				}
				else if (this.IsPlayingAttachEffectButNotWater())
				{
					this.StopMotorAttachEffect();
				}
			}
			else if (this.IsPlayingAttachEffectButNotWater())
			{
				this.StopMotorAttachEffect();
			}
			this.FindNoWaterPhysicalMaterial = enviData.HitPhysicMaterialArray.Contains("DynamicWater");
			string screenEffectPath = this.GetScreenEffectPath(enviData);
			this.UpdateMotorScreenEffect(screenEffectPath);
		}

		// Token: 0x0602E1EB RID: 188907 RVA: 0x00AA5028 File Offset: 0x00AA3228
		public unsafe void OnFallInWater(Vector location, Vector normal)
		{
			if (!this.IsEnabled)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "VehicleEffect Spawn Fall In Water";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Owner", this.Owner.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("vel", this.CacheMaxSpeed);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.SpawnFallEffect(location, normal);
		}

		// Token: 0x0602E1EC RID: 188908 RVA: 0x00AA50B0 File Offset: 0x00AA32B0
		protected void StopMotorAttachEffect()
		{
			int motorAttachHandle = this.MotorAttachHandle;
			if (motorAttachHandle != 0 && EffectSystem.Instance.IsValid(motorAttachHandle))
			{
				EffectSystem.Instance.StopEffectById(motorAttachHandle, "[SceneCharacterWaterEffect.StopMotorAttachEffect]", false, null);
			}
			this.MotorAttachHandle = 0;
			this.MotorAttachHandlePath = "";
		}

		// Token: 0x0602E1ED RID: 188909 RVA: 0x00AA5104 File Offset: 0x00AA3304
		protected void StopMotorScreenEffect()
		{
			int effectHandle = this.MotorScreenHandle;
			if (effectHandle != 0 && EffectSystem.Instance.IsValid(effectHandle))
			{
				TimerSystem.Instance.Delay(delegate(float deltaTime)
				{
					if (EffectSystem.Instance.IsValid(effectHandle))
					{
						EffectSystem.Instance.StopEffectById(effectHandle, "[SceneCharacterVehicleEffect.StopMotorScreenEffect]", false, null);
					}
				}, 20f, null, null, true, 1f);
			}
			this.MotorScreenHandle = 0;
			this.MotorScreenHandlePath = "";
		}

		// Token: 0x0602E1EE RID: 188910 RVA: 0x00AA5174 File Offset: 0x00AA3374
		protected void SpawnMotorAttachEffect(string effectDataPath)
		{
			if (this.IsBlackWave || this.CacheMaxSpeed < 100.0 || this.Owner == null)
			{
				return;
			}
			if (!EffectSystem.Instance.IsValid(this.MotorAttachHandle) || this.MotorAttachHandlePath != effectDataPath)
			{
				this.StopMotorAttachEffect();
				EffectSystem instance = EffectSystem.Instance;
				UObject owner = this.Owner;
				FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
				this.MotorAttachHandle = instance.SpawnEffect(owner, ftransformDouble, effectDataPath, "[SceneCharacterWaterEffect.SpawnMotorAttachEffect]", new EffectContext(null, this.Owner, false), EEffectType.Fight, null, null, null, false, false);
				if (EffectSystem.Instance.IsValid(this.MotorAttachHandle))
				{
					OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.MotorAttachHandle);
					if (effectActor.HasValue)
					{
						OneOf<KuroEffectActorHandle, AActor> self = effectActor;
						AActor owner2 = this.Owner;
						FName? fname = null;
						self.K2_AttachToActor(owner2, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
						FTransformDouble ftransformDouble2 = new FTransformDouble();
						FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, -80.0);
						ftransformDouble2.SetLocation(fvectorDouble);
						effectActor.D_K2_SetActorRelativeTransform(ftransformDouble2, false, ref PhysicsUtils.Instance.DefaultHitResult, true);
					}
					this.MotorAttachHandlePath = effectDataPath;
				}
			}
		}

		// Token: 0x0602E1EF RID: 188911 RVA: 0x00AA52A8 File Offset: 0x00AA34A8
		protected string GetScreenEffectPath(FKuroEnviInteractionData enviData)
		{
			if (this.Owner == null || !this.IsMotorState)
			{
				return "";
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			BaseTagComponent baseTagComponent;
			if (characterActorComponent == null)
			{
				baseTagComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.冲刺"]) && enviData.bInWater && !this.FindNoWaterPhysicalMaterial && (baseTagComponent2 == null || !baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["GameplayEffect.ShieldWaterMoveEffect"])))
			{
				return "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Motuo_Screen01.DA_Fx_Sl3_Motuo_Screen01";
			}
			return "";
		}

		// Token: 0x0602E1F0 RID: 188912 RVA: 0x00AA5344 File Offset: 0x00AA3544
		protected void UpdateMotorScreenEffect(string screenEffectPath)
		{
			if (this.IsBlackWave || this.CacheMaxSpeed < 100.0 || this.Owner == null)
			{
				screenEffectPath = "";
			}
			if (screenEffectPath == "")
			{
				if (EffectSystem.Instance.IsValid(this.MotorScreenHandle))
				{
					this.StopMotorScreenEffect();
				}
				return;
			}
			if (EffectSystem.Instance.IsValid(this.MotorScreenHandle) && this.MotorScreenHandlePath == screenEffectPath)
			{
				return;
			}
			this.StopMotorScreenEffect();
			EffectSystem instance = EffectSystem.Instance;
			UObject owner = this.Owner;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
			this.MotorScreenHandle = instance.SpawnEffect(owner, ftransformDouble, screenEffectPath, "[SceneCharacterVehicleEffect.UpdateMotorScreenEffect]", new EffectContext(null, this.Owner, false), EEffectType.Fight, null, null, null, false, false);
			if (EffectSystem.Instance.IsValid(this.MotorScreenHandle))
			{
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.MotorScreenHandle);
				if (effectActor.HasValue)
				{
					OneOf<KuroEffectActorHandle, AActor> self = effectActor;
					AActor owner2 = this.Owner;
					FName? fname = null;
					self.K2_AttachToActor(owner2, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
				}
				this.MotorScreenHandlePath = screenEffectPath;
			}
		}

		// Token: 0x0602E1F1 RID: 188913 RVA: 0x00AA5458 File Offset: 0x00AA3658
		protected int SpawnFallEffect(Vector location, Vector normal)
		{
			if (this.FindNoWaterPhysicalMaterial)
			{
				return -1;
			}
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			this.EmptyUeTransform.SetLocation(fvectorDouble);
			fvectorDouble = normal.ToUeVector(false);
			FQuat fquat = UKismetMathLibrary.D_MakeRotFromZ(fvectorDouble).Quaternion();
			this.EmptyUeTransform.SetRotation(fquat);
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
			return instance.SpawnUnloopedEffect(world, ftransformDouble, "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Fall.DA_Fx_SI3_Water_Moto_Fall", "[SceneCharacterVehicleEffect.SpawnFallEffect]", new EffectContext(null, this.Owner, false), EEffectType.Scene, null, null, null, false, false);
		}

		// Token: 0x0602E1F2 RID: 188914 RVA: 0x00AA54EC File Offset: 0x00AA36EC
		protected string GetAttachEffectPath(FKuroEnviInteractionData enviData)
		{
			string result = "";
			if ((enviData.HitPhysicMaterialArray.Contains("DirtLand") || enviData.HitPhysicMaterialArray.Contains("SoilLand")) && !enviData.HitPhysicMaterialArray.Contains("Highway"))
			{
				result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_ShaChen.DA_Fx_Sl3_Moto_ShaChen";
			}
			if (this.Owner != null)
			{
				if (enviData.HitPhysicMaterialArray.Contains("SnowLand") || enviData.HitPhysicMaterialArray.Contains("PM_LandThickSnow"))
				{
					CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
					object obj;
					if (characterActorComponent == null)
					{
						obj = null;
					}
					else
					{
						Entity entity = characterActorComponent.Entity;
						obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
					}
					object obj2 = obj;
					if (obj2 != null && obj2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.冲刺"]))
					{
						result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_DQ.DA_Fx_Sl3_Moto_Snow_DQ";
					}
					else
					{
						result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_PT.DA_Fx_Sl3_Moto_Snow_PT";
					}
					if (obj2 != null && obj2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.漂移"]))
					{
						if (this.DriftingLift())
						{
							result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_SP_L.DA_Fx_Sl3_Moto_Snow_SP_L";
						}
						else
						{
							result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_SP_R.DA_Fx_Sl3_Moto_Snow_SP_R";
						}
					}
					if (obj2 != null && obj2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.烧胎"]))
					{
						result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_ST.DA_Fx_Sl3_Moto_Snow_ST";
					}
				}
				else if (enviData.HitTagArray.Contains("ObjTrail"))
				{
					CharacterActorComponent characterActorComponent2 = this.Owner.CharacterActorComponent;
					object obj3;
					if (characterActorComponent2 == null)
					{
						obj3 = null;
					}
					else
					{
						Entity entity2 = characterActorComponent2.Entity;
						obj3 = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
					}
					object obj4 = obj3;
					if (obj4 != null && obj4.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.冲刺"]))
					{
						result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_DQ.DA_Fx_Sl3_Moto_Ice_DQ";
					}
					else
					{
						result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_PT.DA_Fx_Sl3_Moto_Ice_PT";
					}
					if (obj4 != null && obj4.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.漂移"]))
					{
						if (this.DriftingLift())
						{
							result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_SP_L.DA_Fx_Sl3_Moto_Ice_SP_L";
						}
						else
						{
							result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_SP_R.DA_Fx_Sl3_Moto_Ice_SP_R";
						}
					}
					if (obj4 != null && obj4.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.烧胎"]))
					{
						result = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_ST.DA_Fx_Sl3_Moto_Ice_ST";
					}
				}
				if (enviData.HitPhysicMaterialArray.Contains("LightRail"))
				{
					result = "/Game/Aki/Effect/EffectGroup/BigWorld/3_3AnYuan/DA_Fx_Group_Sl2_AY_Glg_MT.DA_Fx_Group_Sl2_AY_Glg_MT";
				}
				else if (enviData.HitPhysicMaterialArray.Contains("XuZhiCube"))
				{
					result = "/Game/Aki/Effect/EffectGroup/BigWorld/3_3AnYuan/DA_Fx_Group_Sl2_AY_3_3_Motuo_Trail.DA_Fx_Group_Sl2_AY_3_3_Motuo_Trail";
				}
			}
			return result;
		}

		// Token: 0x0602E1F3 RID: 188915 RVA: 0x00AA5709 File Offset: 0x00AA3909
		protected bool IsPlayingAttachEffectButNotWater()
		{
			return this.MotorAttachHandlePath != "" && this.MotorAttachHandlePath != "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Putong.DA_Fx_SI3_Water_Moto_Putong" && this.MotorAttachHandlePath != "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Danqi.DA_Fx_SI3_Water_Moto_Danqi";
		}

		// Token: 0x0602E1F4 RID: 188916 RVA: 0x00AA5741 File Offset: 0x00AA3941
		protected bool DriftingLift()
		{
			return this.Owner.K2_GetActorRotation().Roll < 0f;
		}

		// Token: 0x04018BA6 RID: 101286
		private const string MOTOR_DANQI = "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Danqi.DA_Fx_SI3_Water_Moto_Danqi";

		// Token: 0x04018BA7 RID: 101287
		private const string MOTOR_PUTONG = "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Putong.DA_Fx_SI3_Water_Moto_Putong";

		// Token: 0x04018BA8 RID: 101288
		private const string MOTOR_SHACHEN = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_ShaChen.DA_Fx_Sl3_Moto_ShaChen";

		// Token: 0x04018BA9 RID: 101289
		private const string MOTOR_FALL_IN = "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_Fx_SI3_Water_Moto_Fall.DA_Fx_SI3_Water_Moto_Fall";

		// Token: 0x04018BAA RID: 101290
		private const string MOTOR_SCREEN = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Motuo_Screen01.DA_Fx_Sl3_Motuo_Screen01";

		// Token: 0x04018BAB RID: 101291
		private const string ICE_DQ = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_DQ.DA_Fx_Sl3_Moto_Ice_DQ";

		// Token: 0x04018BAC RID: 101292
		private const string ICE_PT = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_PT.DA_Fx_Sl3_Moto_Ice_PT";

		// Token: 0x04018BAD RID: 101293
		private const string ICE_SP_L = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_SP_L.DA_Fx_Sl3_Moto_Ice_SP_L";

		// Token: 0x04018BAE RID: 101294
		private const string ICE_SP_R = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_SP_R.DA_Fx_Sl3_Moto_Ice_SP_R";

		// Token: 0x04018BAF RID: 101295
		private const string ICE_ST = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Ice_ST.DA_Fx_Sl3_Moto_Ice_ST";

		// Token: 0x04018BB0 RID: 101296
		private const string SNOW_DQ = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_DQ.DA_Fx_Sl3_Moto_Snow_DQ";

		// Token: 0x04018BB1 RID: 101297
		private const string SNOW_PT = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_PT.DA_Fx_Sl3_Moto_Snow_PT";

		// Token: 0x04018BB2 RID: 101298
		private const string SNOW_SP_L = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_SP_L.DA_Fx_Sl3_Moto_Snow_SP_L";

		// Token: 0x04018BB3 RID: 101299
		private const string SNOW_SP_R = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_SP_R.DA_Fx_Sl3_Moto_Snow_SP_R";

		// Token: 0x04018BB4 RID: 101300
		private const string SNOW_ST = "/Game/Aki/Effect/DataAsset/Niagara/Common/Snow/DA_Fx_Sl3_Moto_Snow_ST.DA_Fx_Sl3_Moto_Snow_ST";

		// Token: 0x04018BB5 RID: 101301
		private const string MOTOR_LIGHT_RAIL = "/Game/Aki/Effect/EffectGroup/BigWorld/3_3AnYuan/DA_Fx_Group_Sl2_AY_Glg_MT.DA_Fx_Group_Sl2_AY_Glg_MT";

		// Token: 0x04018BB6 RID: 101302
		private const string MOTOR_XU_ZHI_CUBE = "/Game/Aki/Effect/EffectGroup/BigWorld/3_3AnYuan/DA_Fx_Group_Sl2_AY_3_3_Motuo_Trail.DA_Fx_Group_Sl2_AY_3_3_Motuo_Trail";

		// Token: 0x04018BB7 RID: 101303
		private const double MOTOR_EFFECT_SPEED_CLAMP = 100.0;

		// Token: 0x04018BB8 RID: 101304
		[Nullable(2)]
		public TsBaseCharacter Owner;

		// Token: 0x04018BB9 RID: 101305
		public bool IsReady;

		// Token: 0x04018BBA RID: 101306
		public bool IsEnabled;

		// Token: 0x04018BBB RID: 101307
		protected int MotorAttachHandle;

		// Token: 0x04018BBC RID: 101308
		protected string MotorAttachHandlePath = "";

		// Token: 0x04018BBD RID: 101309
		protected int MotorScreenHandle;

		// Token: 0x04018BBE RID: 101310
		protected string MotorScreenHandlePath = "";

		// Token: 0x04018BBF RID: 101311
		protected double CacheMaxSpeed;

		// Token: 0x04018BC0 RID: 101312
		protected FTransformDouble EmptyUeTransform = new FTransformDouble();

		// Token: 0x04018BC1 RID: 101313
		protected bool IsMotorState;

		// Token: 0x04018BC2 RID: 101314
		protected bool FindNoWaterPhysicalMaterial;

		// Token: 0x04018BC3 RID: 101315
		public bool IsVehicleWaterState;

		// Token: 0x04018BC4 RID: 101316
		public bool IsBlackWave;

		// Token: 0x04018BC5 RID: 101317
		[Nullable(2)]
		protected FKuroEnviInteractionData EnviData;
	}
}
