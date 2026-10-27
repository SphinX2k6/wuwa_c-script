using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045DC RID: 17884
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCharacterTriggerEffect
	{
		// Token: 0x0602E1DC RID: 188892 RVA: 0x00AA3AE0 File Offset: 0x00AA1CE0
		public void Start(TsBaseCharacter owner)
		{
			if (!owner.IsValid())
			{
				return;
			}
			this.Owner = owner;
			this.IsReady = true;
			this.VelocityHistory.Initialize(12);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "TriggerEffect Start";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E1DD RID: 188893 RVA: 0x00AA3B38 File Offset: 0x00AA1D38
		public void Enable()
		{
			if (!this.IsReady)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			CharacterUnifiedStateComponent ownerStateComponent;
			if (characterActorComponent == null)
			{
				ownerStateComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				ownerStateComponent = ((entity != null) ? entity.GetComponent<CharacterUnifiedStateComponent>() : null);
			}
			this.OwnerStateComponent = ownerStateComponent;
			this.IsEnabled = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "TriggerEffect Enabled";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E1DE RID: 188894 RVA: 0x00AA3BAC File Offset: 0x00AA1DAC
		public void Disable()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			if (EffectSystem.Instance.IsValid(this.BushEffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.BushEffectHandle, "[SceneCharacterTriggerEffect.Disable]", true, null);
				this.BushEffectHandle = 0;
			}
			this.IsEnabled = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "TriggerEffect Disabled";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E1DF RID: 188895 RVA: 0x00AA3C30 File Offset: 0x00AA1E30
		public void Tick()
		{
			if (!this.IsEnabled || this.Owner == null)
			{
				return;
			}
			this.CurrentVelocity = this.Owner.D_GetVelocity();
			this.VelocityHistory.AddVelocity(Vector.Create(this.CurrentVelocity.X, this.CurrentVelocity.Y, this.CurrentVelocity.Z));
			this.PlayBushEffect();
			this.PlayOverlapTriggerEffect();
			this.CacheData = this.Data;
		}

		// Token: 0x0602E1E0 RID: 188896 RVA: 0x00AA3CA8 File Offset: 0x00AA1EA8
		private bool CheckPlayInBushEffect()
		{
			if (!this.IsReady)
			{
				return false;
			}
			Vector direction = Vector.Create(0.0, 0.0, -1.0);
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			CharacterMoveComponent characterMoveComponent;
			if (characterActorComponent == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
			}
			CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
			if (characterMoveComponent2 != null)
			{
				direction = characterMoveComponent2.GravityDirect;
			}
			return this.VelocityHistory.GetMaxVelocityDirection(direction) > 500.0;
		}

		// Token: 0x0602E1E1 RID: 188897 RVA: 0x00AA3D28 File Offset: 0x00AA1F28
		private bool IsBushInteractionEffectEnabled()
		{
			return UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.InteractionEffect.EnableBushInteractionEffect") > 0;
		}

		// Token: 0x0602E1E2 RID: 188898 RVA: 0x00AA3D38 File Offset: 0x00AA1F38
		private void PlayBushEffect()
		{
			if (!this.IsReady)
			{
				return;
			}
			if (!this.IsBushInteractionEffectEnabled())
			{
				return;
			}
			if (this.Data == null || this.CacheData == null)
			{
				return;
			}
			FTransformDouble? ftransformDouble;
			FName? fname;
			if (this.Data.bHideOnBush)
			{
				if (EffectSystem.Instance.IsValid(this.BushEffectHandle))
				{
					EffectSystem.Instance.HandleSeekToTime(this.BushEffectHandle, (float)this.CurrentVelocity.Size(), false, false);
					OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.BushEffectHandle);
					EffectSystem.Instance.GetEffectModel(this.BushEffectHandle);
					FVectorDouble fvectorDouble = this.Owner.D_K2_GetActorLocation();
					FVectorDouble fvectorDouble2 = new FVectorDouble(fvectorDouble.X, fvectorDouble.Y, (double)this.Data.TriggerHitPoint.Z);
					effectActor.D_K2_SetActorLocation(fvectorDouble2, false, ref PhysicsUtils.Instance.DefaultHitResult, true);
					CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
					CharacterMoveComponent characterMoveComponent;
					if (characterActorComponent == null)
					{
						characterMoveComponent = null;
					}
					else
					{
						Entity entity = characterActorComponent.Entity;
						characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
					}
					CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
					if (characterMoveComponent2 == null)
					{
						return;
					}
					FVectorDouble fvectorDouble3 = Vector.Create(-characterMoveComponent2.GravityDirect.X, -characterMoveComponent2.GravityDirect.Y, -characterMoveComponent2.GravityDirect.Z).ToUeVector(false);
					FVectorDouble fvectorDouble4 = this.Owner.D_GetActorForwardVector();
					FVectorDouble fvectorDouble5 = UKismetMathLibrary.D_Cross_VectorVector(fvectorDouble3, fvectorDouble4);
					fvectorDouble4 = UKismetMathLibrary.D_Cross_VectorVector(fvectorDouble5, fvectorDouble3);
					OneOf<KuroEffectActorHandle, AActor> self = effectActor;
					FRotator frotator = UKismetMathLibrary.D_MakeRotationFromAxes(fvectorDouble4, fvectorDouble5, fvectorDouble3);
					self.K2_SetActorRotation(frotator, true);
				}
				else
				{
					FVector triggerHitPoint = this.Data.TriggerHitPoint;
					FVectorDouble fvectorDouble6 = new FVectorDouble(ref triggerHitPoint);
					this.EmptyUeTransform.SetLocation(fvectorDouble6);
					EffectSystem instance = EffectSystem.Instance;
					UObject owner = this.Owner;
					ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
					this.BushEffectHandle = instance.SpawnEffect(owner, ftransformDouble, "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_Loop.DA_Fx_HideOnBush_Loop", "[SceneCharacterTriggerEffect.SpawnEffect(BushEffect)]", new EffectContext(null, this.Owner, false), EEffectType.Scene, null, null, null, false, false);
				}
				if (EffectSystem.Instance.IsValid(this.BushEffectHandle))
				{
					EffectParameterNiagara effectParameterNiagara = new EffectParameterNiagara();
					effectParameterNiagara.UserParameterFloat = new List<ValueTuple<FName, float>>();
					List<ValueTuple<FName, float>> userParameterFloat = effectParameterNiagara.UserParameterFloat;
					fname = FNameUtil.GetDynamicFName("LUTIndex");
					userParameterFloat.Add(new ValueTuple<FName, float>(fname.Value, this.Data.HitBushLUTIndex));
					if (this.Data.BushIEParam != null)
					{
						List<ValueTuple<FName, float>> userParameterFloat2 = effectParameterNiagara.UserParameterFloat;
						fname = FNameUtil.GetDynamicFName("BushScale");
						userParameterFloat2.Add(new ValueTuple<FName, float>(fname.Value, this.Data.BushIEParam.SpawnSizeScale));
					}
					EffectSystem.Instance.SetEffectParameterNiagara(this.BushEffectHandle, effectParameterNiagara);
				}
			}
			if (this.Data.bHideOnBush || !this.CacheData.bHideOnBush || this.CacheData.BushIEParam.BushEffectTypeIndex < 0)
			{
				if (this.Data.bHideOnBush && !this.CacheData.bHideOnBush && this.Data.BushIEParam.BushEffectTypeIndex >= 0 && this.CheckPlayInBushEffect())
				{
					string path = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_RushIn.DA_Fx_HideOnBush_RushIn";
					if (this.Data.BushIEParam.BushEffectTypeIndex == 1)
					{
						path = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_RushIn_Index1.DA_Fx_HideOnBush_RushIn_Index1";
					}
					EffectSystem instance2 = EffectSystem.Instance;
					UObject owner2 = this.Owner;
					ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
					int id = instance2.SpawnUnloopedEffect(owner2, ftransformDouble, path, "[SceneCharacterFootprintEffect.SpawnRainFootEffect]", null, EEffectType.Scene, null, null, null, false, false);
					OneOf<KuroEffectActorHandle, AActor> effectActor2 = EffectSystem.Instance.GetEffectActor(id);
					if (effectActor2.HasValue && this.Data.HitBushActor.IsValid(false, false))
					{
						OneOf<KuroEffectActorHandle, AActor> self2 = effectActor2;
						AActor parent = this.Data.HitBushActor;
						fname = null;
						self2.K2_AttachToActor(parent, fname, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false);
						effectActor2.D_K2_SetActorRelativeTransform(MathUtils.Instance.DefaultTransformDouble, false, ref PhysicsUtils.Instance.DefaultHitResult, true);
					}
					double num = 1.0;
					CharacterActorComponent characterActorComponent2 = this.Owner.CharacterActorComponent;
					CharacterBuffComponent characterBuffComponent;
					if (characterActorComponent2 == null)
					{
						characterBuffComponent = null;
					}
					else
					{
						Entity entity2 = characterActorComponent2.Entity;
						characterBuffComponent = ((entity2 != null) ? entity2.GetComponent<CharacterBuffComponent>() : null);
					}
					CharacterBuffComponent characterBuffComponent2 = characterBuffComponent;
					if (characterBuffComponent2 != null && characterBuffComponent2.HasBuff(640018019L, false))
					{
						num = 3.0;
					}
					EffectParameterNiagara effectParameterNiagara2 = new EffectParameterNiagara();
					effectParameterNiagara2.UserParameterFloat = new List<ValueTuple<FName, float>>();
					effectParameterNiagara2.UserParameterVector = new List<ValueTuple<FName, FVector>>();
					List<ValueTuple<FName, float>> userParameterFloat3 = effectParameterNiagara2.UserParameterFloat;
					fname = FNameUtil.GetDynamicFName("LUTIndex");
					userParameterFloat3.Add(new ValueTuple<FName, float>(fname.Value, this.Data.HitBushLUTIndex));
					if (this.Data.BushIEParam != null)
					{
						List<ValueTuple<FName, float>> userParameterFloat4 = effectParameterNiagara2.UserParameterFloat;
						fname = FNameUtil.GetDynamicFName("SpawnCountScale");
						userParameterFloat4.Add(new ValueTuple<FName, float>(fname.Value, (float)((double)this.Data.BushIEParam.SpawnCountScale * num)));
						List<ValueTuple<FName, float>> userParameterFloat5 = effectParameterNiagara2.UserParameterFloat;
						fname = FNameUtil.GetDynamicFName("BushScale");
						userParameterFloat5.Add(new ValueTuple<FName, float>(fname.Value, this.Data.BushIEParam.SpawnSizeScale));
						List<ValueTuple<FName, float>> userParameterFloat6 = effectParameterNiagara2.UserParameterFloat;
						fname = FNameUtil.GetDynamicFName("UVIndexBegin");
						userParameterFloat6.Add(new ValueTuple<FName, float>(fname.Value, (float)this.Data.BushIEParam.UVIndexBegin));
						List<ValueTuple<FName, float>> userParameterFloat7 = effectParameterNiagara2.UserParameterFloat;
						fname = FNameUtil.GetDynamicFName("UVIndexEnd");
						userParameterFloat7.Add(new ValueTuple<FName, float>(fname.Value, (float)this.Data.BushIEParam.UVIndexEnd));
						List<ValueTuple<FName, FVector>> userParameterVector = effectParameterNiagara2.UserParameterVector;
						fname = FNameUtil.GetDynamicFName("SpawnBoxExtent");
						userParameterVector.Add(new ValueTuple<FName, FVector>(fname.Value, this.Data.BushIEParam.SpawnBoxExtent));
						List<ValueTuple<FName, FVector>> userParameterVector2 = effectParameterNiagara2.UserParameterVector;
						fname = FNameUtil.GetDynamicFName("SpawnBoxOffset");
						userParameterVector2.Add(new ValueTuple<FName, FVector>(fname.Value, this.Data.BushIEParam.SpawnBoxOffset));
					}
					EffectSystem.Instance.SetEffectParameterNiagara(id, effectParameterNiagara2);
				}
				return;
			}
			FVectorDouble fvectorDouble7 = this.Owner.D_K2_GetActorLocation();
			FVectorDouble fvectorDouble8 = new FVectorDouble(fvectorDouble7.X, fvectorDouble7.Y, (double)this.CacheData.TriggerHitPoint.Z);
			this.EmptyUeTransform.SetLocation(fvectorDouble8);
			FQuat fquat = this.CurrentVelocity.ToOrientationQuat();
			this.EmptyUeTransform.SetRotation(fquat);
			string path2 = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_Out.DA_Fx_HideOnBush_Out";
			if (this.CacheData.BushIEParam.BushEffectTypeIndex == 1)
			{
				path2 = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_Out_Index1.DA_Fx_HideOnBush_Out_Index1";
			}
			EffectSystem instance3 = EffectSystem.Instance;
			UObject owner3 = this.Owner;
			ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
			int id2 = instance3.SpawnUnloopedEffect(owner3, ftransformDouble, path2, "[SceneCharacterFootprintEffect.SpawnRainFootEffect]", null, EEffectType.Scene, null, null, null, false, false);
			CharacterActorComponent characterActorComponent3 = this.Owner.CharacterActorComponent;
			CharacterMoveComponent characterMoveComponent3;
			if (characterActorComponent3 == null)
			{
				characterMoveComponent3 = null;
			}
			else
			{
				Entity entity3 = characterActorComponent3.Entity;
				characterMoveComponent3 = ((entity3 != null) ? entity3.GetComponent<CharacterMoveComponent>() : null);
			}
			CharacterMoveComponent characterMoveComponent4 = characterMoveComponent3;
			if (characterMoveComponent4 == null)
			{
				return;
			}
			Vector vector = Vector.Create(-characterMoveComponent4.GravityDirect.X, -characterMoveComponent4.GravityDirect.Y, -characterMoveComponent4.GravityDirect.Z);
			FVectorDouble safeNormal = this.CurrentVelocity.GetSafeNormal(9.99999993922529E-09);
			double num2 = MathCommon.Clamp(vector.DotProduct(Vector.Create(safeNormal.X, safeNormal.Y, safeNormal.Z)), 0.0, 1.0);
			num2 = (double)MathCommon.Lerp(1f, 0.3f, (float)num2);
			EffectParameterNiagara effectParameterNiagara3 = new EffectParameterNiagara();
			effectParameterNiagara3.UserParameterFloat = new List<ValueTuple<FName, float>>();
			effectParameterNiagara3.UserParameterVector = new List<ValueTuple<FName, FVector>>();
			List<ValueTuple<FName, float>> userParameterFloat8 = effectParameterNiagara3.UserParameterFloat;
			fname = FNameUtil.GetDynamicFName("VelocityStrength");
			userParameterFloat8.Add(new ValueTuple<FName, float>(fname.Value, (float)(Math.Max(this.CurrentVelocity.Size() / 500.0, 0.3) * num2)));
			List<ValueTuple<FName, float>> userParameterFloat9 = effectParameterNiagara3.UserParameterFloat;
			fname = FNameUtil.GetDynamicFName("LUTIndex");
			userParameterFloat9.Add(new ValueTuple<FName, float>(fname.Value, this.CacheData.HitBushLUTIndex));
			List<ValueTuple<FName, float>> userParameterFloat10 = effectParameterNiagara3.UserParameterFloat;
			fname = FNameUtil.GetDynamicFName("SpawnCountScale");
			userParameterFloat10.Add(new ValueTuple<FName, float>(fname.Value, this.CacheData.BushIEParam.SpawnCountScale));
			List<ValueTuple<FName, float>> userParameterFloat11 = effectParameterNiagara3.UserParameterFloat;
			fname = FNameUtil.GetDynamicFName("BushScale");
			userParameterFloat11.Add(new ValueTuple<FName, float>(fname.Value, this.CacheData.BushIEParam.SpawnSizeScale));
			List<ValueTuple<FName, float>> userParameterFloat12 = effectParameterNiagara3.UserParameterFloat;
			fname = FNameUtil.GetDynamicFName("UVIndexBegin");
			userParameterFloat12.Add(new ValueTuple<FName, float>(fname.Value, (float)this.CacheData.BushIEParam.UVIndexBegin));
			List<ValueTuple<FName, float>> userParameterFloat13 = effectParameterNiagara3.UserParameterFloat;
			fname = FNameUtil.GetDynamicFName("UVIndexEnd");
			userParameterFloat13.Add(new ValueTuple<FName, float>(fname.Value, (float)this.CacheData.BushIEParam.UVIndexEnd));
			List<ValueTuple<FName, FVector>> userParameterVector3 = effectParameterNiagara3.UserParameterVector;
			fname = FNameUtil.GetDynamicFName("SpawnBoxExtent");
			userParameterVector3.Add(new ValueTuple<FName, FVector>(fname.Value, this.CacheData.BushIEParam.SpawnBoxExtent));
			List<ValueTuple<FName, FVector>> userParameterVector4 = effectParameterNiagara3.UserParameterVector;
			fname = FNameUtil.GetDynamicFName("SpawnBoxOffset");
			userParameterVector4.Add(new ValueTuple<FName, FVector>(fname.Value, this.CacheData.BushIEParam.SpawnBoxOffset));
			EffectSystem.Instance.SetEffectParameterNiagara(id2, effectParameterNiagara3);
			if (EffectSystem.Instance.IsValid(this.BushEffectHandle))
			{
				int stopHandle = this.BushEffectHandle;
				TimerSystem.Instance.Delay(delegate(float deltaTime)
				{
					if (EffectSystem.Instance.IsValid(stopHandle))
					{
						EffectSystem.Instance.StopEffectById(stopHandle, "[SceneCharacterWaterEffect.StopEffect]", true, new bool?(true));
					}
				}, 1000f, null, null, true, 1f);
			}
			this.BushEffectHandle = 0;
		}

		// Token: 0x0602E1E3 RID: 188899 RVA: 0x00AA46A4 File Offset: 0x00AA28A4
		private unsafe void PlayOverlapTriggerEffect()
		{
			if (!this.IsReady)
			{
				return;
			}
			if (!this.IsBushInteractionEffectEnabled())
			{
				return;
			}
			if (this.Data == null || this.CacheData == null)
			{
				return;
			}
			if (!this.Data.OverlapTriggerMesh && this.CacheData.OverlapTriggerMesh && this.CacheData.BushIEParam.TreeEffectTypeIndex >= 0 && this.CacheData.OverlapTriggerParam0.X == 2f)
			{
				FVectorDouble fvectorDouble = this.Owner.D_K2_GetActorLocation();
				FVectorDouble fvectorDouble2 = new FVectorDouble(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z);
				this.EmptyUeTransform.SetLocation(fvectorDouble2);
				FQuat fquat = this.CurrentVelocity.ToOrientationQuat();
				this.EmptyUeTransform.SetRotation(fquat);
				CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
				bool flag;
				if (characterActorComponent == null)
				{
					flag = (null != null);
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					flag = (((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null) != null);
				}
				if (!flag)
				{
					return;
				}
				CharacterUnifiedStateComponent ownerStateComponent = this.OwnerStateComponent;
				ECharMoveState? echarMoveState = (ownerStateComponent != null) ? new ECharMoveState?(ownerStateComponent.MoveState) : null;
				CharacterActorComponent characterActorComponent2 = this.Owner.CharacterActorComponent;
				BaseTagComponent baseTagComponent;
				if (characterActorComponent2 == null)
				{
					baseTagComponent = null;
				}
				else
				{
					Entity entity2 = characterActorComponent2.Entity;
					baseTagComponent = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
				}
				BaseTagComponent baseTagComponent2 = baseTagComponent;
				string path = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_SoaringTreeOut.DA_Fx_SoaringTreeOut";
				if (this.CacheData.BushIEParam.TreeEffectTypeIndex == 1)
				{
					path = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_SoaringTreeOutSpecialFoliage.DA_Fx_SoaringTreeOutSpecialFoliage";
				}
				double num = 1.0;
				double num2 = 1.0;
				int id;
				double num3;
				if (echarMoveState.GetValueOrDefault() == ECharMoveState.Soar || (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托"])) || (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.冲刺移动"]) && baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.主控机甲"])))
				{
					EffectSystem instance = EffectSystem.Instance;
					UObject owner = this.Owner;
					FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
					id = instance.SpawnUnloopedEffect(owner, ftransformDouble, path, "[SceneEffect.SpawnTriggerSoaringTreeEffect]", null, EEffectType.Scene, null, null, null, false, false);
					num3 = Math.Max(this.CurrentVelocity.Size() / 500.0, 1.0) * (double)this.CacheData.BushIEParam.SoaringSpeedScale;
					num = (double)this.CacheData.BushIEParam.SoaringSpawnSizeScale;
					num2 = (double)this.CacheData.BushIEParam.SoaringSpawnCountScale;
				}
				else
				{
					EffectSystem instance2 = EffectSystem.Instance;
					UObject owner2 = this.Owner;
					FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
					id = instance2.SpawnUnloopedEffect(owner2, ftransformDouble, "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_Out.DA_Fx_HideOnBush_Out", "[SceneEffect.SpawnTriggerBushEffect]", null, EEffectType.Scene, null, null, null, false, false);
					num3 = Math.Max(this.CurrentVelocity.Size() / 500.0, 0.3);
				}
				EffectParameterNiagara effectParameterNiagara = new EffectParameterNiagara();
				effectParameterNiagara.UserParameterFloat = new List<ValueTuple<FName, float>>();
				effectParameterNiagara.UserParameterVector = new List<ValueTuple<FName, FVector>>();
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("VelocityStrength").Value, (float)num3));
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("LifeTimeScale").Value, this.CacheData.BushIEParam.SoaringLifeTimeScale));
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("LUTIndex").Value, this.CacheData.HitBushLUTIndex));
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("SpawnCountScale").Value, this.CacheData.BushIEParam.SpawnCountScale));
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("BushScale").Value, this.CacheData.BushIEParam.SpawnSizeScale));
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("SoaringScale").Value, (float)num));
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("SoaringCountScale").Value, (float)num2));
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("UVIndexBegin").Value, (float)this.CacheData.BushIEParam.UVIndexBegin));
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("UVIndexEnd").Value, (float)this.CacheData.BushIEParam.UVIndexEnd));
				effectParameterNiagara.UserParameterVector.Add(new ValueTuple<FName, FVector>(FNameUtil.GetDynamicFName("SpawnBoxExtent").Value, this.CacheData.BushIEParam.SpawnBoxExtent));
				effectParameterNiagara.UserParameterVector.Add(new ValueTuple<FName, FVector>(FNameUtil.GetDynamicFName("SpawnBoxOffset").Value, this.CacheData.BushIEParam.SpawnBoxOffset));
				EffectSystem.Instance.SetEffectParameterNiagara(id, effectParameterNiagara);
				Log instance3 = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.LLX;
				string message = "SoarEffect DebugMessage";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("UVIndexBegin", this.CacheData.BushIEParam.UVIndexBegin);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("UVIndexEnd", this.CacheData.BushIEParam.UVIndexEnd);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SoaringScale", this.CacheData.BushIEParam.SoaringSpawnSizeScale);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SoaringCountScale", this.CacheData.BushIEParam.SoaringSpawnCountScale);
				instance3.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}

		// Token: 0x04018B92 RID: 101266
		private const float DELAY_OUT_BUSH_EFFECT = 1000f;

		// Token: 0x04018B93 RID: 101267
		private const string BUSH_WALK_EFFCT = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_Loop.DA_Fx_HideOnBush_Loop";

		// Token: 0x04018B94 RID: 101268
		private const string BUSH_OUT_EFFCT = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_Out.DA_Fx_HideOnBush_Out";

		// Token: 0x04018B95 RID: 101269
		private const string BUSH_IN_EFFCT = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_RushIn.DA_Fx_HideOnBush_RushIn";

		// Token: 0x04018B96 RID: 101270
		private const string BUSH_OUT_EFFCT_INDEX1 = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_Out_Index1.DA_Fx_HideOnBush_Out_Index1";

		// Token: 0x04018B97 RID: 101271
		private const string BUSH_IN_EFFCT_INDEX1 = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_HideOnBush_RushIn_Index1.DA_Fx_HideOnBush_RushIn_Index1";

		// Token: 0x04018B98 RID: 101272
		private const string SOARING_TREE_EFFCT = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_SoaringTreeOut.DA_Fx_SoaringTreeOut";

		// Token: 0x04018B99 RID: 101273
		private const string SOARING_TREE_EFFCT_SPECIAL = "/Game/Aki/Effect/DataAsset/Niagara/Common/Interaction/DA_Fx_SoaringTreeOutSpecialFoliage.DA_Fx_SoaringTreeOutSpecialFoliage";

		// Token: 0x04018B9A RID: 101274
		private const string CVAR_ENABLE_BUSH_INTERACTION_EFFECT = "r.Kuro.InteractionEffect.EnableBushInteractionEffect";

		// Token: 0x04018B9B RID: 101275
		[Nullable(2)]
		public TsBaseCharacter Owner;

		// Token: 0x04018B9C RID: 101276
		[Nullable(2)]
		public CharacterUnifiedStateComponent OwnerStateComponent;

		// Token: 0x04018B9D RID: 101277
		[Nullable(2)]
		public PlayerGameplayCueComponent CueComponent;

		// Token: 0x04018B9E RID: 101278
		[Nullable(2)]
		public FKuroEnviInteractionData Data;

		// Token: 0x04018B9F RID: 101279
		[Nullable(2)]
		public FKuroEnviInteractionData CacheData;

		// Token: 0x04018BA0 RID: 101280
		public bool IsReady;

		// Token: 0x04018BA1 RID: 101281
		protected int BushEffectHandle;

		// Token: 0x04018BA2 RID: 101282
		protected FVectorDouble CurrentVelocity = new FVectorDouble();

		// Token: 0x04018BA3 RID: 101283
		protected FTransformDouble EmptyUeTransform = new FTransformDouble();

		// Token: 0x04018BA4 RID: 101284
		protected VelocityHistoryCache VelocityHistory = new VelocityHistoryCache();

		// Token: 0x04018BA5 RID: 101285
		public bool IsEnabled;
	}
}
