using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.SceneItem.Elevator;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200644D RID: 25677
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CameraUtility : IStaticVariableResetter
	{
		// Token: 0x0603E594 RID: 255380 RVA: 0x0121FBB0 File Offset: 0x0121DDB0
		static CameraUtility()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraUtility.CreateStaticDefaultValue), new Action(CameraUtility.ResetStaticDefaultValue));
		}

		// Token: 0x0603E595 RID: 255381 RVA: 0x0121FCF4 File Offset: 0x0121DEF4
		[NullableContext(2)]
		public static void GetSocketLocation(AActor character, FName? socketName, [Nullable(1)] global::Vector outVector, EntityHandle handle = null)
		{
			AActor aactor;
			EntityHandle entityHandle;
			if (character == null)
			{
				if (handle == null || !handle.Valid)
				{
					outVector.Reset();
					return;
				}
				BaseActorComponent component = handle.Entity.GetComponent<BaseActorComponent>();
				aactor = ((component != null) ? component.Owner : null);
				if (aactor == null)
				{
					outVector.Reset();
					return;
				}
				entityHandle = handle;
			}
			else
			{
				aactor = character;
				entityHandle = ((handle == null || !handle.Valid) ? ActorUtils.GetEntityByActor(character, true) : handle);
			}
			if (!CameraUtility.IsTsActor(entityHandle))
			{
				if (entityHandle.Valid)
				{
					outVector.DeepCopy(entityHandle.Entity.GetComponent<BaseActorComponent>().ActorLocationProxy);
				}
				return;
			}
			TsBaseCharacter tsBaseCharacter = aactor as TsBaseCharacter;
			if (tsBaseCharacter.Mesh != null && ((socketName != null) ? socketName.GetValueOrDefault().ToString() : null) != null)
			{
				FVectorDouble fvectorDouble = tsBaseCharacter.Mesh.D_GetSocketLocation(socketName.Value);
				outVector.FromUeVector(fvectorDouble);
				return;
			}
			entityHandle.Entity.GetComponent<CharacterAnimationComponent>().GetCameraPosition(outVector);
		}

		// Token: 0x0603E596 RID: 255382 RVA: 0x0121FDE8 File Offset: 0x0121DFE8
		[NullableContext(2)]
		private static bool IsTsActor(EntityHandle handle)
		{
			if (handle == null || !handle.Valid)
			{
				return false;
			}
			EEntityType entityType = handle.Entity.GetComponent<CreatureDataComponent>().GetEntityType();
			return entityType <= EEntityType.Monster || entityType == EEntityType.Vision;
		}

		// Token: 0x0603E597 RID: 255383 RVA: 0x0121FE2D File Offset: 0x0121E02D
		[NullableContext(2)]
		public static FTransformDouble GetRootTransform(ACharacter character)
		{
			if (((character != null) ? character.Mesh : null) == null)
			{
				return new FTransformDouble();
			}
			return character.Mesh.D_GetSocketTransform(CameraUtility.Root, ERelativeTransformSpace.RTS_World);
		}

		// Token: 0x0603E598 RID: 255384 RVA: 0x0121FE54 File Offset: 0x0121E054
		public static bool TargetCanBeSelect(BaseActorComponent actorComp)
		{
			if (!actorComp.Valid || !actorComp.Active)
			{
				return false;
			}
			BaseTagComponent component = actorComp.Entity.GetComponent<BaseTagComponent>();
			return component == null || (!component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]) && !component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不可锁定"]));
		}

		// Token: 0x0603E599 RID: 255385 RVA: 0x0121FEB8 File Offset: 0x0121E0B8
		[NullableContext(2)]
		public static EntityHandle GetCameraTargetEntityHandle()
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid)
			{
				return null;
			}
			EntityHandle characterEntityHandle = logicComponent.CharacterEntityHandle;
			if (characterEntityHandle == null || !characterEntityHandle.Valid)
			{
				return null;
			}
			return characterEntityHandle;
		}

		// Token: 0x0603E59A RID: 255386 RVA: 0x0121FF00 File Offset: 0x0121E100
		[NullableContext(2)]
		public static EntityHandle GetCameraLockOnTargetEntityHandle()
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid)
			{
				return null;
			}
			EntityHandle targetEntity = logicComponent.TargetEntity;
			if (targetEntity == null || !targetEntity.Valid)
			{
				return null;
			}
			return targetEntity;
		}

		// Token: 0x0603E59B RID: 255387 RVA: 0x0121FF48 File Offset: 0x0121E148
		public static void GetCameraCharacterRotation(global::Rotator outR)
		{
			outR.Reset();
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent != null && fightCameraLogicComponent.Valid)
			{
				TsBaseCharacter character = fightCameraLogicComponent.Character;
				if (((character != null) ? character.CharacterActorComponent : null) != null)
				{
					outR.DeepCopy(fightCameraLogicComponent.Character.CharacterActorComponent.ActorRotationProxy);
					return;
				}
			}
		}

		// Token: 0x0603E59C RID: 255388 RVA: 0x0121FFB4 File Offset: 0x0121E1B4
		public static float GetPlayerTargetAndCameraYawOffset()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent != null && fightCameraLogicComponent.Valid)
			{
				EntityHandle targetEntity = fightCameraLogicComponent.TargetEntity;
				if (targetEntity != null && targetEntity.Valid)
				{
					TsBaseCharacter character = fightCameraLogicComponent.Character;
					if (((character != null) ? character.CharacterActorComponent : null) != null)
					{
						CameraUtility.GetSocketLocation(null, fightCameraLogicComponent.TargetSocketName, CameraUtility.TempVector, fightCameraLogicComponent.TargetEntity);
						CameraUtility.TempVector.SubtractionEqual(fightCameraLogicComponent.Character.CharacterActorComponent.ActorLocationProxy);
						CameraUtility.GetVectorInGravity(CameraUtility.TempVector, CameraUtility.TempVector);
						float num = (float)CameraUtility.TempVector.HeadingAngle() * 57.29578f;
						global::Rotator tempRotator = CameraUtility.TempRotator;
						FRotator cameraRotation = Global.CharacterCameraManager.GetCameraRotation();
						tempRotator.DeepCopy(cameraRotation);
						float yawInGravity = CameraUtility.GetYawInGravity(CameraUtility.TempRotator);
						return MathUtils.Instance.WrapAngle(num - yawInGravity);
					}
				}
			}
			return 0f;
		}

		// Token: 0x0603E59D RID: 255389 RVA: 0x012200A4 File Offset: 0x0121E2A4
		public static float GetPlayerAndCameraYawOffset()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
			{
				return 0f;
			}
			global::Rotator tempRotator = CameraUtility.TempRotator;
			FRotator cameraRotation = Global.CharacterCameraManager.GetCameraRotation();
			tempRotator.DeepCopy(cameraRotation);
			float yawInGravity = CameraUtility.GetYawInGravity(CameraUtility.TempRotator);
			return MathUtils.Instance.WrapAngle(fightCameraLogicComponent.PlayerRotatorInGravity.Yaw - yawInGravity);
		}

		// Token: 0x0603E59E RID: 255390 RVA: 0x01220120 File Offset: 0x0121E320
		public static global::Rotator GetCameraDefaultFocusRotator()
		{
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("InitialCameraPitch");
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent != null && fightCameraLogicComponent.Valid)
			{
				TsBaseCharacter character = fightCameraLogicComponent.Character;
				if (character != null && character.IsValid())
				{
					TsBaseCharacter character2 = fightCameraLogicComponent.Character;
					if (((character2 != null) ? character2.CharacterActorComponent : null) != null)
					{
						BaseTagComponent component = fightCameraLogicComponent.Character.CharacterActorComponent.Entity.GetComponent<BaseTagComponent>();
						if (component == null || !component.Valid || component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"]))
						{
							CameraUtility.TempRotator.Reset();
							CameraUtility.SetPitchInGravity(CameraUtility.TempRotator, (double)floatConfig.Value, CameraUtility.TempRotator);
							return CameraUtility.TempRotator;
						}
						if (fightCameraLogicComponent.IsInNormalGravityMode())
						{
							FVector fvector = fightCameraLogicComponent.Character.CharacterActorComponent.ActorRotation.Euler();
							CameraUtility.TempRotator.Pitch = floatConfig.Value;
							CameraUtility.TempRotator.Yaw = fvector.Z;
							CameraUtility.TempRotator.Roll = fvector.X;
						}
						else
						{
							CameraUtility.SetPitchInGravity(fightCameraLogicComponent.Character.CharacterActorComponent.ActorRotationProxy, (double)floatConfig.Value, CameraUtility.TempRotator);
						}
						return CameraUtility.TempRotator;
					}
				}
			}
			CameraUtility.TempRotator.Pitch = floatConfig.Value;
			CameraUtility.TempRotator.Yaw = 0f;
			CameraUtility.TempRotator.Roll = 0f;
			return CameraUtility.TempRotator;
		}

		// Token: 0x0603E59F RID: 255391 RVA: 0x012202A8 File Offset: 0x0121E4A8
		public static FRotator GetCameraDefaultFocusUeRotator()
		{
			return CameraUtility.GetCameraDefaultFocusRotator().ToUeRotator();
		}

		// Token: 0x0603E5A0 RID: 255392 RVA: 0x012202B4 File Offset: 0x0121E4B4
		[NullableContext(2)]
		public static bool CheckCameraShakeCondition(EntityHandle entityHandle)
		{
			return entityHandle != null && entityHandle.Valid && CameraUtility.CheckFormationControlState(entityHandle, true, true);
		}

		// Token: 0x0603E5A1 RID: 255393 RVA: 0x012202D4 File Offset: 0x0121E4D4
		[NullableContext(2)]
		public unsafe static bool CheckCameraSequenceCondition(TsBaseCharacter owner, ESequenceCameraAnsEffectiveClientType sequenceCameraAnsEffectiveClientType = ESequenceCameraAnsEffectiveClientType.单客户端)
		{
			if (owner == null)
			{
				return false;
			}
			switch (sequenceCameraAnsEffectiveClientType)
			{
			case ESequenceCameraAnsEffectiveClientType.单客户端:
			{
				Entity entityNoBlueprint = owner.GetEntityNoBlueprint();
				CreatureDataComponent creatureDataComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CreatureDataComponent>() : null;
				if (creatureDataComponent == null || !creatureDataComponent.IsRole())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Camera;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "SwitchSequenceCamera生效客户端类型`单客户端`只允许在角色身上调用";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ELogModule", ELogModule.Camera);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ELogAuthor", ELogAuthor.LJM);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return false;
				}
				return creatureDataComponent.IsCharacterMonster() || Global.BaseCharacter == owner;
			}
			case ESequenceCameraAnsEffectiveClientType.全客户端:
				return true;
			case ESequenceCameraAnsEffectiveClientType.锁定目标客户端:
			{
				Entity entityNoBlueprint2 = owner.GetEntityNoBlueprint();
				bool flag;
				if (entityNoBlueprint2 == null)
				{
					flag = true;
				}
				else
				{
					CreatureDataComponent component = entityNoBlueprint2.GetComponent<CreatureDataComponent>();
					flag = !((component != null) ? new bool?(component.IsMonster()) : null).GetValueOrDefault();
				}
				if (flag)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Camera;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "SwitchSequenceCamera生效客户端类型`锁定目标客户端`只允许在怪物身上调用";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ELogModule", ELogModule.Camera);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ELogAuthor", ELogAuthor.LJM);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return false;
				}
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				CharacterLockOnComponent characterLockOnComponent;
				if (baseCharacter == null)
				{
					characterLockOnComponent = null;
				}
				else
				{
					Entity entityNoBlueprint3 = baseCharacter.GetEntityNoBlueprint();
					characterLockOnComponent = ((entityNoBlueprint3 != null) ? entityNoBlueprint3.GetComponent<CharacterLockOnComponent>() : null);
				}
				CharacterLockOnComponent characterLockOnComponent2 = characterLockOnComponent;
				return characterLockOnComponent2 != null && characterLockOnComponent2.Valid && characterLockOnComponent2.GetCurrentTarget() == CharacterModel.Instance.GetHandle(owner.EntityId);
			}
			case ESequenceCameraAnsEffectiveClientType.仇恨目标客户端:
			{
				Entity entityNoBlueprint4 = owner.GetEntityNoBlueprint();
				bool flag2;
				if (entityNoBlueprint4 == null)
				{
					flag2 = true;
				}
				else
				{
					CreatureDataComponent component2 = entityNoBlueprint4.GetComponent<CreatureDataComponent>();
					flag2 = !((component2 != null) ? new bool?(component2.IsMonster()) : null).GetValueOrDefault();
				}
				if (flag2)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Camera;
					ELogAuthor author3 = ELogAuthor.LJM;
					string message3 = "SwitchSequenceCamera生效客户端类型`仇恨目标客户端`只允许在怪物身上调用";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("ELogModule", ELogModule.Camera);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("ELogAuthor", ELogAuthor.LJM);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					return false;
				}
				TsAiController tsAiController = owner.GetController() as TsAiController;
				if (tsAiController == null)
				{
					return false;
				}
				AiController aiController = tsAiController.AiController;
				EntityHandle entityHandle = (aiController != null) ? aiController.AiHateList.GetCurrentTarget() : null;
				CharacterActorComponent characterActorComponent;
				if (entityHandle == null)
				{
					characterActorComponent = null;
				}
				else
				{
					WorldEntity entity = entityHandle.Entity;
					characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
				}
				CharacterActorComponent characterActorComponent2 = characterActorComponent;
				return characterActorComponent2 != null && characterActorComponent2.Valid && characterActorComponent2.Owner is TsBaseCharacter && characterActorComponent2.IsAutonomousProxy && characterActorComponent2.Owner == Global.BaseCharacter;
			}
			case ESequenceCameraAnsEffectiveClientType.技能目标客户端:
			{
				Entity entityNoBlueprint5 = owner.GetEntityNoBlueprint();
				bool flag3;
				if (entityNoBlueprint5 == null)
				{
					flag3 = true;
				}
				else
				{
					CreatureDataComponent component3 = entityNoBlueprint5.GetComponent<CreatureDataComponent>();
					flag3 = !((component3 != null) ? new bool?(component3.IsMonster()) : null).GetValueOrDefault();
				}
				if (flag3)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Camera;
					ELogAuthor author4 = ELogAuthor.LJM;
					string message4 = "SwitchSequenceCamera生效客户端类型`技能目标客户端`只允许在怪物身上调用";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("ELogModule", ELogModule.Camera);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("ELogAuthor", ELogAuthor.LJM);
					instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
					return false;
				}
				Entity entityNoBlueprint6 = owner.GetEntityNoBlueprint();
				CharacterSkillComponent characterSkillComponent = (entityNoBlueprint6 != null) ? entityNoBlueprint6.GetComponent<CharacterSkillComponent>() : null;
				if (characterSkillComponent == null || !characterSkillComponent.Valid)
				{
					return false;
				}
				EntityHandle skillTarget = characterSkillComponent.SkillTarget;
				CharacterModel instance5 = CharacterModel.Instance;
				TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
				return skillTarget == instance5.GetHandle((baseCharacter2 != null) ? baseCharacter2.EntityId : 0);
			}
			default:
				return false;
			}
		}

		// Token: 0x0603E5A2 RID: 255394 RVA: 0x012206A0 File Offset: 0x0121E8A0
		public static bool CheckApplyCameraModifyCondition([Nullable(2)] EntityHandle entityHandle, SCameraModifier_Settings cameraModifySettings, ECameraAnsEffectiveClientType cameraEffectiveClientType = ECameraAnsEffectiveClientType.单客户端_角色为中心_, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<SCameraModifier_Condition> cameraModifierConditions = null)
		{
			return entityHandle != null && entityHandle.Valid && CameraUtility.CheckFormationControlState(entityHandle, false, !cameraModifySettings.IsSwitchModifier) && CameraUtility.CheckCameraEffectiveClientType(entityHandle, cameraEffectiveClientType) && (cameraModifierConditions == null || CameraUtility.CheckCameraModifierConditions(cameraModifierConditions));
		}

		// Token: 0x0603E5A3 RID: 255395 RVA: 0x012206F0 File Offset: 0x0121E8F0
		public static bool CheckFormationControlState(EntityHandle entityHandle, bool needLocal = false, bool needControl = false)
		{
			if (!entityHandle.Valid)
			{
				return false;
			}
			FollowShooterComponent component = entityHandle.Entity.GetComponent<FollowShooterComponent>();
			if (component != null && component.Valid)
			{
				return component.IsAutonomousProxy;
			}
			BaseVehiclePerformComponent component2 = entityHandle.Entity.GetComponent<BaseVehiclePerformComponent>();
			CreatureDataComponent component3;
			if (component2 != null && component2.Valid)
			{
				Entity driver = component2.Driver;
				if (driver != null && driver.Valid)
				{
					component3 = component2.Driver.GetComponent<CreatureDataComponent>();
					goto IL_6B;
				}
			}
			component3 = entityHandle.Entity.GetComponent<CreatureDataComponent>();
			IL_6B:
			if (component3 != null && component3.Valid)
			{
				long param = (long)((component3.IsVision() || component3.IsMonster()) ? CreatureModel.Instance.GetEntityId(component3.GetSummonerId()) : component3.Entity.Id);
				SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem(param, new GetTeamItemOptions
				{
					ParamType = ETeamParamType.EntityId
				});
				if (teamItem != null && ((needLocal && !teamItem.IsMyRole()) || (needControl && !teamItem.IsControl())))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603E5A4 RID: 255396 RVA: 0x012207DC File Offset: 0x0121E9DC
		[NullableContext(2)]
		public static bool CheckCameraEffectiveClientType(EntityHandle entityHandle, ECameraAnsEffectiveClientType cameraEffectiveClientType)
		{
			if (entityHandle == null || !entityHandle.Valid)
			{
				return false;
			}
			CreatureDataComponent component = entityHandle.Entity.GetComponent<CreatureDataComponent>();
			if (component == null || !component.Valid)
			{
				return false;
			}
			switch (cameraEffectiveClientType)
			{
			case ECameraAnsEffectiveClientType.单客户端_角色为中心_:
			case ECameraAnsEffectiveClientType.单客户端_声骸为中心_:
			{
				int playerId = component.GetPlayerId();
				int? id = PlayerInfoModel.Instance.GetId();
				return (playerId == id.GetValueOrDefault() & id != null) && (component.IsRole() || component.IsVision());
			}
			case ECameraAnsEffectiveClientType.全客户端_角色为中心_:
			case ECameraAnsEffectiveClientType.全客户端_声骸为中心_:
			case ECameraAnsEffectiveClientType.全客户端_载具为中心_:
			case ECameraAnsEffectiveClientType.全客户端_伴生物为中心_:
				return true;
			case ECameraAnsEffectiveClientType.锁定目标客户端_怪物为中心_:
			case ECameraAnsEffectiveClientType.锁定目标客户端_角色为中心_:
			{
				if (!component.IsMonster())
				{
					return false;
				}
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				CharacterLockOnComponent characterLockOnComponent;
				if (baseCharacter == null)
				{
					characterLockOnComponent = null;
				}
				else
				{
					Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
					characterLockOnComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterLockOnComponent>() : null);
				}
				CharacterLockOnComponent characterLockOnComponent2 = characterLockOnComponent;
				return characterLockOnComponent2 != null && characterLockOnComponent2.Valid && characterLockOnComponent2.ShowTarget == CharacterModel.Instance.GetHandle(entityHandle.Id);
			}
			case ECameraAnsEffectiveClientType.仇恨目标客户端_怪物为中心_:
			case ECameraAnsEffectiveClientType.仇恨目标客户端_角色为中心_:
			{
				if (!component.IsMonster())
				{
					return false;
				}
				APawn apawn = entityHandle.Entity.GetComponent<CharacterActorComponent>().Owner as APawn;
				TsAiController tsAiController = ((apawn != null) ? apawn.GetController() : null) as TsAiController;
				if (tsAiController == null)
				{
					return false;
				}
				AiController aiController = tsAiController.AiController;
				EntityHandle entityHandle2 = (aiController != null) ? aiController.AiHateList.GetCurrentTarget() : null;
				CharacterActorComponent characterActorComponent;
				if (entityHandle2 == null)
				{
					characterActorComponent = null;
				}
				else
				{
					WorldEntity entity = entityHandle2.Entity;
					characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
				}
				CharacterActorComponent characterActorComponent2 = characterActorComponent;
				return characterActorComponent2 != null && characterActorComponent2.Valid && (characterActorComponent2 != null && characterActorComponent2.Owner is TsBaseCharacter && characterActorComponent2.IsAutonomousProxy && characterActorComponent2.Owner == Global.BaseCharacter);
			}
			case ECameraAnsEffectiveClientType.技能目标客户端_怪物为中心_:
			{
				if (!component.IsMonster())
				{
					return false;
				}
				CharacterSkillComponent component2 = entityHandle.Entity.GetComponent<CharacterSkillComponent>();
				if (component2 != null && component2.Valid)
				{
					EntityHandle skillTarget = component2.SkillTarget;
					CharacterModel instance = CharacterModel.Instance;
					TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
					return skillTarget == instance.GetHandle((baseCharacter2 != null) ? baseCharacter2.EntityId : 0);
				}
				return false;
			}
			case ECameraAnsEffectiveClientType.全客户端_怪物为中心_:
				return component.IsMonster();
			case ECameraAnsEffectiveClientType.单客户端_载具为中心_:
			{
				BaseVehiclePerformComponent component3 = entityHandle.Entity.GetComponent<BaseVehiclePerformComponent>();
				if (component3 != null && component3.Valid)
				{
					Entity driver = component3.Driver;
					if (driver != null && driver.Valid)
					{
						CreatureDataComponent component4 = component3.Driver.GetComponent<CreatureDataComponent>();
						if (component4 == null || !component4.Valid)
						{
							return false;
						}
						int playerId2 = component4.GetPlayerId();
						int? id = PlayerInfoModel.Instance.GetId();
						return (playerId2 == id.GetValueOrDefault() & id != null) && (component4.IsRole() || component4.IsVision());
					}
				}
				return false;
			}
			case ECameraAnsEffectiveClientType.单客户端_伴生物为中心_:
			{
				if (!component.IsConcomitantEntity)
				{
					return false;
				}
				int entityId = CreatureModel.Instance.GetEntityId(component.GetSummonerId());
				SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)entityId, new GetTeamItemOptions
				{
					ParamType = ETeamParamType.EntityId
				});
				return teamItem != null && teamItem.IsMyRole() && teamItem.IsControl();
			}
			default:
				return false;
			}
		}

		// Token: 0x0603E5A5 RID: 255397 RVA: 0x01220AC3 File Offset: 0x0121ECC3
		private static bool CheckCameraModifierConditions([Nullable(new byte[]
		{
			2,
			1
		})] TArray<SCameraModifier_Condition> cameraModifierConditions = null)
		{
			return cameraModifierConditions == null || CameraUtility.IsCameraModifyValidation(cameraModifierConditions);
		}

		// Token: 0x0603E5A6 RID: 255398 RVA: 0x01220AD0 File Offset: 0x0121ECD0
		private static bool IsCameraModifyValidation(TArray<SCameraModifier_Condition> conditionArray)
		{
			int num = conditionArray.Num();
			for (int i = 0; i < num; i++)
			{
				SCameraModifier_Condition scameraModifier_Condition = conditionArray.Get(i);
				switch (scameraModifier_Condition.ConditionType)
				{
				case ECameraModifyConditionType.角色拥有Tag:
					if (!CameraUtility.CheckSelfContainsTag(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.锁定目标拥有Tag:
					if (!CameraUtility.CheckTargetContainsTag(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.臂长范围:
					if (!CameraUtility.CheckCameraArmLength(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.锁定目标处于镜头左边:
					if (!CameraUtility.CheckTargetCameraLeft(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.与锁定目标相对高度:
					if (!CameraUtility.CheckTargetHeightDelta(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.与锁定目标的相对Yaw:
					if (!CameraUtility.CheckTargetYawDelta(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.当前pitch范围:
					if (!CameraUtility.CheckCameraPitch(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.与锁定目标的距离:
					if (!CameraUtility.CheckTargetDistance(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.范围阻挡检测:
					if (!CameraUtility.CheckTargetCollision(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.相机位于锁定目标连线轴的左侧:
					if (!CameraUtility.CheckCameraTargetConnectionLeft(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.相机位于锁定目标连线轴的右侧:
					if (!CameraUtility.CheckCameraTargetConnectionRight(scameraModifier_Condition))
					{
						return false;
					}
					break;
				case ECameraModifyConditionType.与角色的相对Yaw:
					if (!CameraUtility.CheckCharacterYawDelta(scameraModifier_Condition))
					{
						return false;
					}
					break;
				default:
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Camera;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "未支持的相机 Modify ConditionType";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConditionType", scameraModifier_Condition.ConditionType);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x0603E5A7 RID: 255399 RVA: 0x01220C00 File Offset: 0x0121EE00
		private static bool CheckSelfContainsTag(SCameraModifier_Condition condition)
		{
			BaseTagComponent component = Global.BaseCharacter.GetEntityNoBlueprint().GetComponent<BaseTagComponent>();
			bool flag = condition.AnyTag ? component.HasAnyTag(GameplayTagUtils.ConvertFromUeContainer(condition.TagToCheck)) : component.HasAllTag(GameplayTagUtils.ConvertFromUeContainer(condition.TagToCheck));
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5A8 RID: 255400 RVA: 0x01220C58 File Offset: 0x0121EE58
		private static bool CheckTargetContainsTag(SCameraModifier_Condition condition)
		{
			bool flag = false;
			EntityHandle cameraLockOnTargetEntityHandle = CameraUtility.GetCameraLockOnTargetEntityHandle();
			if (cameraLockOnTargetEntityHandle != null)
			{
				BaseTagComponent component = cameraLockOnTargetEntityHandle.Entity.GetComponent<BaseTagComponent>();
				flag = (condition.AnyTag ? component.HasAnyTag(GameplayTagUtils.ConvertFromUeContainer(condition.TagToCheck)) : component.HasAllTag(GameplayTagUtils.ConvertFromUeContainer(condition.TagToCheck)));
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5A9 RID: 255401 RVA: 0x01220CB8 File Offset: 0x0121EEB8
		private static bool CheckCameraArmLength(SCameraModifier_Condition condition)
		{
			bool flag = false;
			double fightCameraFinalDistance = CameraController.Instance.MainModel.FightCameraFinalDistance;
			if (fightCameraFinalDistance >= (double)condition.ArmLengthMin && fightCameraFinalDistance <= (double)condition.ArmLengthMax)
			{
				flag = true;
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5AA RID: 255402 RVA: 0x01220CFC File Offset: 0x0121EEFC
		private static bool CheckTargetCameraLeft(SCameraModifier_Condition condition)
		{
			bool flag = false;
			EntityHandle cameraLockOnTargetEntityHandle = CameraUtility.GetCameraLockOnTargetEntityHandle();
			if (cameraLockOnTargetEntityHandle != null)
			{
				global::Vector cameraLocation = CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraLocation;
				global::Vector cameraForward = CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraForward;
				cameraLockOnTargetEntityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy.Subtraction(cameraLocation, CameraUtility.TempVector);
				cameraForward.CrossProduct(CameraUtility.TempVector, CameraUtility.TempVector);
				if (CameraUtility.TempVector.Z < 0.0)
				{
					flag = true;
				}
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5AB RID: 255403 RVA: 0x01220D98 File Offset: 0x0121EF98
		private static bool CheckTargetHeightDelta(SCameraModifier_Condition condition)
		{
			bool flag = false;
			EntityHandle cameraLockOnTargetEntityHandle = CameraUtility.GetCameraLockOnTargetEntityHandle();
			if (cameraLockOnTargetEntityHandle != null)
			{
				ref FVectorDouble ptr = Global.BaseCharacter.CharacterActorComponent.SkeletalMesh.D_GetSocketLocation(CharacterNameDefines.Instance.ROOT);
				global::Vector actorLocationProxy = cameraLockOnTargetEntityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy;
				double num = Math.Abs(ptr.Z - actorLocationProxy.Z);
				if (num >= (double)condition.LockTargetDeltaZMin && num <= (double)condition.LockTargetDeltaZMax)
				{
					flag = true;
				}
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5AC RID: 255404 RVA: 0x01220E18 File Offset: 0x0121F018
		private static bool CheckTargetYawDelta(SCameraModifier_Condition condition)
		{
			bool flag = false;
			if (CameraUtility.GetCameraLockOnTargetEntityHandle() != null)
			{
				double num = (double)Math.Abs(CameraUtility.GetPlayerTargetAndCameraYawOffset());
				if (num >= (double)condition.LockTargetDeltaYawMin && num <= (double)condition.LockTargetDeltaYawMax)
				{
					flag = true;
				}
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5AD RID: 255405 RVA: 0x01220E60 File Offset: 0x0121F060
		private static bool CheckCameraPitch(SCameraModifier_Condition condition)
		{
			bool flag = false;
			global::Rotator tempRotator = CameraUtility.TempRotator;
			FRotator cameraRotation = Global.CharacterCameraManager.GetCameraRotation();
			tempRotator.DeepCopy(cameraRotation);
			double num = (double)CameraUtility.GetPitchInGravity(CameraUtility.TempRotator);
			if (num >= (double)condition.LockTargetDeltaPitchMin && num <= (double)condition.LockTargetDeltaPitchMax)
			{
				flag = true;
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5AE RID: 255406 RVA: 0x01220EB8 File Offset: 0x0121F0B8
		private static bool CheckTargetDistance(SCameraModifier_Condition condition)
		{
			bool flag = false;
			EntityHandle cameraLockOnTargetEntityHandle = CameraUtility.GetCameraLockOnTargetEntityHandle();
			if (cameraLockOnTargetEntityHandle != null)
			{
				global::Vector actorLocationProxy = Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy;
				global::Vector actorLocationProxy2 = cameraLockOnTargetEntityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy;
				CameraUtility.GetVectorInGravity(actorLocationProxy, CameraUtility.TempVector);
				CameraUtility.GetVectorInGravity(actorLocationProxy2, CameraUtility.TempVector1);
				double num = global::Vector.DistSquared2D(CameraUtility.TempVector, CameraUtility.TempVector1);
				double num2 = (double)(condition.MinLockDistance * condition.MinLockDistance);
				double num3 = (double)(condition.MaxLockDistance * condition.MaxLockDistance);
				if (num >= num2 && num <= num3)
				{
					flag = true;
				}
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5AF RID: 255407 RVA: 0x01220F54 File Offset: 0x0121F154
		private static bool CheckTargetCollision(SCameraModifier_Condition condition)
		{
			bool flag = false;
			if (condition.CameraTraceRadius > 0f)
			{
				global::Rotator actorRotationProxy = Global.BaseCharacter.CharacterActorComponent.ActorRotationProxy;
				USkeletalMeshComponent skeletalMesh = Global.BaseCharacter.CharacterActorComponent.SkeletalMesh;
				FVectorDouble fvectorDouble;
				if (skeletalMesh.DoesSocketExist(condition.CameraTraceSocket))
				{
					global::Vector tempVector = CameraUtility.TempVector;
					fvectorDouble = skeletalMesh.D_GetSocketLocation(condition.CameraTraceSocket);
					tempVector.DeepCopy(fvectorDouble);
				}
				else
				{
					global::Vector tempVector2 = CameraUtility.TempVector;
					fvectorDouble = skeletalMesh.D_GetSocketLocation(CameraUtility.CameraPosition);
					tempVector2.DeepCopy(fvectorDouble);
				}
				global::Vector tempVector3 = CameraUtility.TempVector1;
				FVector cameraTraceOffset = condition.CameraTraceOffset;
				fvectorDouble = cameraTraceOffset;
				tempVector3.DeepCopy(fvectorDouble);
				actorRotationProxy.Quaternion(null).RotateVector(CameraUtility.TempVector1, CameraUtility.TempVector1);
				CameraUtility.TempVector1.AdditionEqual(CameraUtility.TempVector);
				if (CameraUtility._cameraSphereTrace == null)
				{
					CameraUtility._cameraSphereTrace = new UTraceSphereElement();
					CameraUtility._cameraSphereTrace.bIsSingle = true;
					CameraUtility._cameraSphereTrace.bTraceComplex = false;
					CameraUtility._cameraSphereTrace.bIgnoreSelf = true;
					CameraUtility._cameraSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
					CameraUtility._cameraSphereTrace.WorldContextObject = GlobalData.World;
				}
				CameraUtility._cameraSphereTrace.Radius = condition.CameraTraceRadius;
				TraceElementCommon.Instance.SetStartLocation(CameraUtility._cameraSphereTrace, CameraUtility.TempVector1);
				TraceElementCommon.Instance.SetEndLocation(CameraUtility._cameraSphereTrace, CameraUtility.TempVector1);
				flag = !TraceElementCommon.Instance.SphereTrace(CameraUtility._cameraSphereTrace, "CameraUtility_CheckCollision_Camera");
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5B0 RID: 255408 RVA: 0x012210C4 File Offset: 0x0121F2C4
		private static bool CheckCameraTargetConnectionLeft(SCameraModifier_Condition condition)
		{
			bool flag = false;
			EntityHandle cameraTargetEntityHandle = CameraUtility.GetCameraTargetEntityHandle();
			EntityHandle cameraLockOnTargetEntityHandle = CameraUtility.GetCameraLockOnTargetEntityHandle();
			if (cameraTargetEntityHandle != null && cameraLockOnTargetEntityHandle != null)
			{
				global::Vector cameraLocation = CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraLocation;
				global::Vector actorLocationProxy = cameraTargetEntityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy;
				cameraLockOnTargetEntityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy.Subtraction(actorLocationProxy, CameraUtility.TempVector);
				cameraLocation.Subtraction(actorLocationProxy, CameraUtility.TempVector1);
				CameraUtility.TempVector1.CrossProduct(CameraUtility.TempVector, CameraUtility.TempVector);
				CameraUtility.GetVectorInGravity(CameraUtility.TempVector, CameraUtility.TempVector);
				if (CameraUtility.TempVector.Z > 0.0)
				{
					flag = true;
				}
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5B1 RID: 255409 RVA: 0x01221188 File Offset: 0x0121F388
		private static bool CheckCameraTargetConnectionRight(SCameraModifier_Condition condition)
		{
			bool flag = false;
			EntityHandle cameraTargetEntityHandle = CameraUtility.GetCameraTargetEntityHandle();
			EntityHandle cameraLockOnTargetEntityHandle = CameraUtility.GetCameraLockOnTargetEntityHandle();
			if (cameraTargetEntityHandle != null && cameraLockOnTargetEntityHandle != null)
			{
				global::Vector cameraLocation = CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraLocation;
				global::Vector actorLocationProxy = cameraTargetEntityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy;
				cameraLockOnTargetEntityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy.Subtraction(actorLocationProxy, CameraUtility.TempVector);
				cameraLocation.Subtraction(actorLocationProxy, CameraUtility.TempVector1);
				CameraUtility.TempVector1.CrossProduct(CameraUtility.TempVector, CameraUtility.TempVector);
				CameraUtility.GetVectorInGravity(CameraUtility.TempVector, CameraUtility.TempVector);
				if (CameraUtility.TempVector.Z < 0.0)
				{
					flag = true;
				}
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5B2 RID: 255410 RVA: 0x0122124C File Offset: 0x0121F44C
		private static bool CheckCharacterYawDelta(SCameraModifier_Condition condition)
		{
			bool flag = false;
			if (CameraUtility.GetCameraTargetEntityHandle() != null)
			{
				float playerAndCameraYawOffset = CameraUtility.GetPlayerAndCameraYawOffset();
				if (playerAndCameraYawOffset >= condition.CharacterDeltaYawMin && playerAndCameraYawOffset <= condition.CharacterDeltaYawMax)
				{
					flag = true;
				}
			}
			if (!condition.Reverse)
			{
				return flag;
			}
			return !flag;
		}

		// Token: 0x0603E5B3 RID: 255411 RVA: 0x0122128C File Offset: 0x0121F48C
		public static bool CharacterMovementBaseIsMoving()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			UPrimitiveComponent uprimitiveComponent;
			if (fightCamera == null)
			{
				uprimitiveComponent = null;
			}
			else
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				if (logicComponent == null)
				{
					uprimitiveComponent = null;
				}
				else
				{
					TsBaseCharacter character = logicComponent.Character;
					uprimitiveComponent = ((character != null) ? character.BasedMovement.MovementBase : null);
				}
			}
			UPrimitiveComponent uprimitiveComponent2 = uprimitiveComponent;
			if (uprimitiveComponent2 == null || uprimitiveComponent2.Mobility != 2)
			{
				return false;
			}
			if (!uprimitiveComponent2.GetComponentVelocity().IsNearlyZero(0.0001f))
			{
				return true;
			}
			EntityHandle entityByBaseItem = SceneInteractionModel.Instance.GetEntityByBaseItem(uprimitiveComponent2.GetOwner());
			GamePlayElevatorComponent gamePlayElevatorComponent = (entityByBaseItem != null) ? entityByBaseItem.Entity.GetComponent<GamePlayElevatorComponent>() : null;
			return gamePlayElevatorComponent != null && gamePlayElevatorComponent.IsMovingOrTeleporting();
		}

		// Token: 0x0603E5B4 RID: 255412 RVA: 0x0122132C File Offset: 0x0121F52C
		public static void SetCameraRotationWithString(string rotation)
		{
			List<string> list = new List<string>();
			foreach (object obj in Regex.Matches(rotation, "[+-]?\\d+(?<Decimal>\\.\\d*)?"))
			{
				Match match = (Match)obj;
				list.Add(match.Value);
			}
			if (list.Count < 2)
			{
				return;
			}
			CameraUtility.SetCameraRotationWithAxisString(list[0], list[1]);
		}

		// Token: 0x0603E5B5 RID: 255413 RVA: 0x012213B4 File Offset: 0x0121F5B4
		public static void SetCameraRotationWithAxisString(string pitchStr, string yawStr)
		{
			float inPitch = MathCommon.Clamp(float.Parse(pitchStr), -89.9f, 89.9f);
			float inYaw = MathUtils.Instance.WrapAngle(float.Parse(yawStr));
			float inRoll = 0f;
			CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(new FRotator(inPitch, inYaw, inRoll));
		}

		// Token: 0x0603E5B6 RID: 255414 RVA: 0x01221410 File Offset: 0x0121F610
		[NullableContext(2)]
		public static void ResetFocus(float time = 0.6f, CurveBase curve = null, bool canBreakByInput = true, float stayTime = 0f)
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
			{
				return;
			}
			fightCameraLogicComponent.ResetCameraInput();
			fightCameraLogicComponent.PlayCameraEulerRotatorWithCurve(CameraUtility.GetCameraDefaultFocusRotator(), time, curve, canBreakByInput, stayTime);
		}

		// Token: 0x0603E5B7 RID: 255415 RVA: 0x01221460 File Offset: 0x0121F660
		public unsafe static void PrintRotationInNormalGravity(global::Rotator rotation, string printContent)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid)
			{
				return;
			}
			rotation.Quaternion(CameraUtility.TempQuat);
			logicComponent.GravityQuat.Multiply(CameraUtility.TempQuat, CameraUtility.TempQuat2);
			CameraUtility.TempQuat2.Rotator(CameraUtility.TempRotator);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("rotation", rotation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RotatorInNormalGravity", CameraUtility.TempRotator);
			instance.Info(module, author, printContent, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603E5B8 RID: 255416 RVA: 0x01221510 File Offset: 0x0121F710
		public unsafe static void PrintRotationInCameraGravity(global::Rotator rotation, string printContent)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid)
			{
				return;
			}
			rotation.Quaternion(CameraUtility.TempQuat);
			logicComponent.GravityInverseQuat.Multiply(CameraUtility.TempQuat, CameraUtility.TempQuat2);
			CameraUtility.TempQuat2.Rotator(CameraUtility.TempRotator);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("rotation", rotation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RotatorInCameraGravity", CameraUtility.TempRotator);
			instance.Info(module, author, printContent, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603E5B9 RID: 255417 RVA: 0x012215C0 File Offset: 0x0121F7C0
		public static global::Rotator GetRotatorInGravity(global::Rotator rotator, global::Rotator outRotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outRotator.DeepCopy(rotator);
				return outRotator;
			}
			rotator.Quaternion(CameraUtility.TempQuat);
			logicComponent.GravityInverseQuat.Multiply(CameraUtility.TempQuat, CameraUtility.TempQuat2);
			CameraUtility.TempQuat2.Rotator(outRotator);
			return outRotator;
		}

		// Token: 0x0603E5BA RID: 255418 RVA: 0x0122162C File Offset: 0x0121F82C
		public static global::Rotator SetRotatorInGravity(global::Rotator inOutRotator, global::Rotator rotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				inOutRotator.DeepCopy(rotator);
				return inOutRotator;
			}
			rotator.Quaternion(CameraUtility.TempQuat);
			logicComponent.GravityQuat.Multiply(CameraUtility.TempQuat, CameraUtility.TempQuat2);
			CameraUtility.TempQuat2.Rotator(inOutRotator);
			return inOutRotator;
		}

		// Token: 0x0603E5BB RID: 255419 RVA: 0x01221698 File Offset: 0x0121F898
		public static global::Rotator GetRotatorInNormal(global::Rotator rotator, global::Rotator outRotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outRotator.DeepCopy(rotator);
				return outRotator;
			}
			rotator.Quaternion(CameraUtility.TempQuat);
			logicComponent.GravityQuat.Multiply(CameraUtility.TempQuat, CameraUtility.TempQuat2);
			CameraUtility.TempQuat2.Rotator(outRotator);
			return outRotator;
		}

		// Token: 0x0603E5BC RID: 255420 RVA: 0x01221704 File Offset: 0x0121F904
		public static global::Vector GetVectorInGravity(global::Vector vector, global::Vector outVector)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outVector.DeepCopy(vector);
				return outVector;
			}
			logicComponent.GravityInverseQuat.RotateVector(vector, outVector);
			return outVector;
		}

		// Token: 0x0603E5BD RID: 255421 RVA: 0x01221750 File Offset: 0x0121F950
		public static global::Vector GetVectorInNormal(global::Vector vector, global::Vector outVector)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outVector.DeepCopy(vector);
				return outVector;
			}
			logicComponent.GravityQuat.RotateVector(vector, outVector);
			return outVector;
		}

		// Token: 0x0603E5BE RID: 255422 RVA: 0x0122179C File Offset: 0x0121F99C
		public static float GetPitchInGravity(global::Rotator rotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				return rotator.Pitch;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			return CameraUtility.TempRotator.Pitch;
		}

		// Token: 0x0603E5BF RID: 255423 RVA: 0x012217F8 File Offset: 0x0121F9F8
		public static global::Rotator SetPitchInGravity(global::Rotator rotator, double pitch, global::Rotator outRotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outRotator.DeepCopy(rotator);
				outRotator.Pitch = (float)MathCommon.Clamp(pitch, -89.9000015258789, 89.9000015258789);
				return outRotator;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			CameraUtility.TempRotator.Pitch = (float)MathCommon.Clamp(pitch, -89.9000015258789, 89.9000015258789);
			GravityUtils.Instance.GetRotatorInNormal(CameraUtility.TempRotator, logicComponent.GravityQuat, outRotator);
			return outRotator;
		}

		// Token: 0x0603E5C0 RID: 255424 RVA: 0x012218A4 File Offset: 0x0121FAA4
		public static global::Rotator AddPitchInGravity(global::Rotator rotator, double addPitch, global::Rotator outRotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outRotator.DeepCopy(rotator);
				outRotator.Pitch = (float)MathCommon.Clamp((double)outRotator.Pitch + addPitch, -89.9000015258789, 89.9000015258789);
				return outRotator;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			CameraUtility.TempRotator.Pitch = (float)MathCommon.Clamp((double)CameraUtility.TempRotator.Pitch + addPitch, -89.9000015258789, 89.9000015258789);
			GravityUtils.Instance.GetRotatorInNormal(CameraUtility.TempRotator, logicComponent.GravityQuat, outRotator);
			return outRotator;
		}

		// Token: 0x0603E5C1 RID: 255425 RVA: 0x01221964 File Offset: 0x0121FB64
		public static float GetYawInGravity(global::Rotator rotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				return rotator.Yaw;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			return CameraUtility.TempRotator.Yaw;
		}

		// Token: 0x0603E5C2 RID: 255426 RVA: 0x012219C0 File Offset: 0x0121FBC0
		public static global::Rotator SetYawInGravity(global::Rotator rotator, double yaw, global::Rotator outRotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outRotator.DeepCopy(rotator);
				outRotator.Yaw = (float)MathUtils.Instance.WrapAngle(yaw);
				return outRotator;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			CameraUtility.TempRotator.Yaw = (float)MathUtils.Instance.WrapAngle(yaw);
			GravityUtils.Instance.GetRotatorInNormal(CameraUtility.TempRotator, logicComponent.GravityQuat, outRotator);
			return outRotator;
		}

		// Token: 0x0603E5C3 RID: 255427 RVA: 0x01221A54 File Offset: 0x0121FC54
		public static global::Rotator AddYawInGravity(global::Rotator rotator, double addYaw, global::Rotator outRotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outRotator.DeepCopy(rotator);
				outRotator.Yaw = (float)MathUtils.Instance.WrapAngle((double)outRotator.Yaw + addYaw);
				return outRotator;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			CameraUtility.TempRotator.Yaw = (float)MathUtils.Instance.WrapAngle((double)CameraUtility.TempRotator.Yaw + addYaw);
			GravityUtils.Instance.GetRotatorInNormal(CameraUtility.TempRotator, logicComponent.GravityQuat, outRotator);
			return outRotator;
		}

		// Token: 0x0603E5C4 RID: 255428 RVA: 0x01221AFC File Offset: 0x0121FCFC
		public static float GetRollInGravity(global::Rotator rotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				return rotator.Roll;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			return CameraUtility.TempRotator.Roll;
		}

		// Token: 0x0603E5C5 RID: 255429 RVA: 0x01221B58 File Offset: 0x0121FD58
		public static global::Rotator SetRollInGravity(global::Rotator rotator, double roll, global::Rotator outRotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outRotator.DeepCopy(rotator);
				outRotator.Roll = (float)MathUtils.Instance.WrapAngle(roll);
				return outRotator;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			CameraUtility.TempRotator.Roll = (float)MathUtils.Instance.WrapAngle(roll);
			GravityUtils.Instance.GetRotatorInNormal(CameraUtility.TempRotator, logicComponent.GravityQuat, outRotator);
			return outRotator;
		}

		// Token: 0x0603E5C6 RID: 255430 RVA: 0x01221BEC File Offset: 0x0121FDEC
		public static global::Rotator AddRollInGravity(global::Rotator rotator, double addRoll, global::Rotator outRotator)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outRotator.DeepCopy(rotator);
				outRotator.Roll = (float)MathUtils.Instance.WrapAngle((double)outRotator.Roll + addRoll);
				return outRotator;
			}
			GravityUtils.Instance.GetRotatorInGravity(rotator, logicComponent.GravityInverseQuat, CameraUtility.TempRotator);
			CameraUtility.TempRotator.Roll = (float)MathUtils.Instance.WrapAngle((double)CameraUtility.TempRotator.Roll + addRoll);
			GravityUtils.Instance.GetRotatorInNormal(CameraUtility.TempRotator, logicComponent.GravityQuat, outRotator);
			return outRotator;
		}

		// Token: 0x0603E5C7 RID: 255431 RVA: 0x01221C94 File Offset: 0x0121FE94
		public static global::Vector SetXnInGravity(global::Vector vector, double x, global::Vector outVector)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outVector.DeepCopy(vector);
				outVector.X = x;
				return outVector;
			}
			GravityUtils.Instance.GetVectorInGravity(vector, logicComponent.GravityInverseQuat, outVector);
			outVector.X = x;
			GravityUtils.Instance.GetVectorInNormal(outVector, logicComponent.GravityQuat, outVector);
			return outVector;
		}

		// Token: 0x0603E5C8 RID: 255432 RVA: 0x01221D04 File Offset: 0x0121FF04
		public static global::Vector SetYnInGravity(global::Vector vector, float y, global::Vector outVector)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outVector.DeepCopy(vector);
				outVector.Y = (double)y;
				return outVector;
			}
			GravityUtils.Instance.GetVectorInGravity(vector, logicComponent.GravityInverseQuat, outVector);
			outVector.Y = (double)y;
			GravityUtils.Instance.GetVectorInNormal(outVector, logicComponent.GravityQuat, outVector);
			return outVector;
		}

		// Token: 0x0603E5C9 RID: 255433 RVA: 0x01221D78 File Offset: 0x0121FF78
		public static global::Vector SetZnInGravity(global::Vector vector, double z, global::Vector outVector)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outVector.DeepCopy(vector);
				outVector.Z = z;
				return outVector;
			}
			GravityUtils.Instance.GetVectorInGravity(vector, logicComponent.GravityInverseQuat, outVector);
			outVector.Z = z;
			GravityUtils.Instance.GetVectorInNormal(outVector, logicComponent.GravityQuat, outVector);
			return outVector;
		}

		// Token: 0x0603E5CA RID: 255434 RVA: 0x01221DE8 File Offset: 0x0121FFE8
		public static float GetZnInGravity(global::Vector vector)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				return (float)vector.Z;
			}
			return (float)CameraUtility.GetVectorInGravity(vector, CameraUtility.TempVector).Z;
		}

		// Token: 0x0603E5CB RID: 255435 RVA: 0x01221E34 File Offset: 0x01220034
		public static global::Vector AddZnInGravity(global::Vector vector, double addZ, global::Vector outVector)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				outVector.DeepCopy(vector);
				outVector.Z += addZ;
				return outVector;
			}
			outVector.DeepCopy(vector);
			GravityUtils.Instance.AddZnInGravity(logicComponent.GravityDirect, outVector, addZ);
			return outVector;
		}

		// Token: 0x0603E5CC RID: 255436 RVA: 0x01221E98 File Offset: 0x01220098
		public static FName GetCameraMode(ECustomCameraMode cameraMode)
		{
			switch (cameraMode)
			{
			case ECustomCameraMode.LockOn:
				return CameraUtility.CameraModeLockOn;
			case ECustomCameraMode.Sequence:
				return CameraUtility.CameraModeSequence;
			case ECustomCameraMode.Widget:
				return CameraUtility.CameraModeWidget;
			case ECustomCameraMode.Scene:
				return CameraUtility.CameraModeScene;
			case ECustomCameraMode.Orbital:
				return CameraUtility.CameraModeOrbital;
			case ECustomCameraMode.Free:
				return CameraUtility.CameraModeFree;
			default:
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "Invalid Camera Mode";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cameraMode", cameraMode);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return CameraUtility.CameraModeDefault;
			}
			}
		}

		// Token: 0x0603E5CD RID: 255437 RVA: 0x01221F1C File Offset: 0x0122011C
		public static double GetValidPitchAngle(double limitPitchAngle, bool isMinValue)
		{
			if (!MathUtils.Instance.IsNearlyZero(limitPitchAngle, new double?((double)0.0001f)) && MathUtils.Instance.IsNearlyZero(Math.Abs(limitPitchAngle) % 90.0, new double?((double)0.0001f)))
			{
				return (double)((limitPitchAngle > 0.0) ? 89.9f : -89.9f);
			}
			if (!isMinValue)
			{
				return Math.Min(limitPitchAngle, 89.9000015258789);
			}
			return Math.Max(limitPitchAngle, -89.9000015258789);
		}

		// Token: 0x0603E5CE RID: 255438 RVA: 0x01221FA4 File Offset: 0x012201A4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E5CF RID: 255439 RVA: 0x01221FA6 File Offset: 0x012201A6
		public static void ResetStaticDefaultValue()
		{
			CameraUtility._cameraSphereTrace = null;
		}

		// Token: 0x04021393 RID: 136083
		private const string PROFILE_KEY = "CameraUtility_CheckCollision_Camera";

		// Token: 0x04021394 RID: 136084
		private const float RESET_FOCUS_TIME = 0.6f;

		// Token: 0x04021395 RID: 136085
		private const float PITCH_LIMIT_VALUE = 89.9f;

		// Token: 0x04021396 RID: 136086
		[StaticVariableRuleIgnore]
		public static readonly FName CameraPosition = new FName("CameraPosition");

		// Token: 0x04021397 RID: 136087
		[StaticVariableRuleIgnore]
		public static readonly FName HitCase = new FName("HitCase");

		// Token: 0x04021398 RID: 136088
		[StaticVariableRuleIgnore]
		public static readonly FName Root = new FName("Root");

		// Token: 0x04021399 RID: 136089
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeDefault = new FName("KuroDefault");

		// Token: 0x0402139A RID: 136090
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeLockOn = new FName("KuroLockOn");

		// Token: 0x0402139B RID: 136091
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeWidget = new FName("KuroWidget");

		// Token: 0x0402139C RID: 136092
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeSequence = new FName("KuroSequence");

		// Token: 0x0402139D RID: 136093
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeScene = new FName("KuroScene");

		// Token: 0x0402139E RID: 136094
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeOrbital = new FName("KuroOrbital");

		// Token: 0x0402139F RID: 136095
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeFree = new FName("KuroFree");

		// Token: 0x040213A0 RID: 136096
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TempVector = global::Vector.Create();

		// Token: 0x040213A1 RID: 136097
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TempVector1 = global::Vector.Create();

		// Token: 0x040213A2 RID: 136098
		[StaticVariableRuleIgnore]
		private static readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040213A3 RID: 136099
		[StaticVariableRuleIgnore]
		private static readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040213A4 RID: 136100
		[StaticVariableRuleIgnore]
		private static readonly global::Rotator TempRotator = global::Rotator.Create();

		// Token: 0x040213A5 RID: 136101
		public static readonly float CapsuleHeightRatio = 0.67f;

		// Token: 0x040213A6 RID: 136102
		[Nullable(2)]
		private static UTraceSphereElement _cameraSphereTrace;
	}
}
