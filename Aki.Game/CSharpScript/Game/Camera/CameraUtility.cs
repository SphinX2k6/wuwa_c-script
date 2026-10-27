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
	// Token: 0x020072CB RID: 29387
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CameraUtility : IStaticVariableResetter
	{
		// Token: 0x06048191 RID: 295313 RVA: 0x0127D0B4 File Offset: 0x0127B2B4
		static CameraUtility()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraUtility.CreateStaticDefaultValue), new Action(CameraUtility.ResetStaticDefaultValue));
		}

		// Token: 0x06048192 RID: 295314 RVA: 0x0127D1F8 File Offset: 0x0127B3F8
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

		// Token: 0x06048193 RID: 295315 RVA: 0x0127D2EC File Offset: 0x0127B4EC
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

		// Token: 0x06048194 RID: 295316 RVA: 0x0127D331 File Offset: 0x0127B531
		[NullableContext(2)]
		public static FTransformDouble GetRootTransform(ACharacter character)
		{
			if (((character != null) ? character.Mesh : null) == null)
			{
				return new FTransformDouble();
			}
			return character.Mesh.D_GetSocketTransform(CameraUtility.Root, ERelativeTransformSpace.RTS_World);
		}

		// Token: 0x06048195 RID: 295317 RVA: 0x0127D358 File Offset: 0x0127B558
		public static bool TargetCanBeSelect(BaseActorComponent actorComp)
		{
			if (!actorComp.Valid || !actorComp.Active)
			{
				return false;
			}
			BaseTagComponent component = actorComp.Entity.GetComponent<BaseTagComponent>();
			return component == null || (!component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]) && !component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不可锁定"]));
		}

		// Token: 0x06048196 RID: 295318 RVA: 0x0127D3BC File Offset: 0x0127B5BC
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

		// Token: 0x06048197 RID: 295319 RVA: 0x0127D404 File Offset: 0x0127B604
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

		// Token: 0x06048198 RID: 295320 RVA: 0x0127D44C File Offset: 0x0127B64C
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

		// Token: 0x06048199 RID: 295321 RVA: 0x0127D4B8 File Offset: 0x0127B6B8
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

		// Token: 0x0604819A RID: 295322 RVA: 0x0127D5A8 File Offset: 0x0127B7A8
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

		// Token: 0x0604819B RID: 295323 RVA: 0x0127D624 File Offset: 0x0127B824
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

		// Token: 0x0604819C RID: 295324 RVA: 0x0127D7AC File Offset: 0x0127B9AC
		public static FRotator GetCameraDefaultFocusUeRotator()
		{
			return CameraUtility.GetCameraDefaultFocusRotator().ToUeRotator();
		}

		// Token: 0x0604819D RID: 295325 RVA: 0x0127D7B8 File Offset: 0x0127B9B8
		[NullableContext(2)]
		public static bool CheckCameraShakeCondition(EntityHandle entityHandle)
		{
			return entityHandle != null && entityHandle.Valid && CameraUtility.CheckFormationControlState(entityHandle, true, true);
		}

		// Token: 0x0604819E RID: 295326 RVA: 0x0127D7D8 File Offset: 0x0127B9D8
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

		// Token: 0x0604819F RID: 295327 RVA: 0x0127DBA4 File Offset: 0x0127BDA4
		public static bool CheckApplyCameraModifyCondition([Nullable(2)] EntityHandle entityHandle, SCameraModifier_Settings cameraModifySettings, ECameraAnsEffectiveClientType cameraEffectiveClientType = ECameraAnsEffectiveClientType.单客户端_角色为中心_, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<SCameraModifier_Condition> cameraModifierConditions = null)
		{
			return entityHandle != null && entityHandle.Valid && CameraUtility.CheckFormationControlState(entityHandle, false, !cameraModifySettings.IsSwitchModifier) && CameraUtility.CheckCameraEffectiveClientType(entityHandle, cameraEffectiveClientType) && (cameraModifierConditions == null || CameraUtility.CheckCameraModifierConditions(cameraModifierConditions));
		}

		// Token: 0x060481A0 RID: 295328 RVA: 0x0127DBF4 File Offset: 0x0127BDF4
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

		// Token: 0x060481A1 RID: 295329 RVA: 0x0127DCE0 File Offset: 0x0127BEE0
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

		// Token: 0x060481A2 RID: 295330 RVA: 0x0127DFC7 File Offset: 0x0127C1C7
		private static bool CheckCameraModifierConditions([Nullable(new byte[]
		{
			2,
			1
		})] TArray<SCameraModifier_Condition> cameraModifierConditions = null)
		{
			return cameraModifierConditions == null || CameraUtility.IsCameraModifyValidation(cameraModifierConditions);
		}

		// Token: 0x060481A3 RID: 295331 RVA: 0x0127DFD4 File Offset: 0x0127C1D4
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

		// Token: 0x060481A4 RID: 295332 RVA: 0x0127E104 File Offset: 0x0127C304
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

		// Token: 0x060481A5 RID: 295333 RVA: 0x0127E15C File Offset: 0x0127C35C
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

		// Token: 0x060481A6 RID: 295334 RVA: 0x0127E1BC File Offset: 0x0127C3BC
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

		// Token: 0x060481A7 RID: 295335 RVA: 0x0127E200 File Offset: 0x0127C400
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

		// Token: 0x060481A8 RID: 295336 RVA: 0x0127E29C File Offset: 0x0127C49C
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

		// Token: 0x060481A9 RID: 295337 RVA: 0x0127E31C File Offset: 0x0127C51C
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

		// Token: 0x060481AA RID: 295338 RVA: 0x0127E364 File Offset: 0x0127C564
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

		// Token: 0x060481AB RID: 295339 RVA: 0x0127E3BC File Offset: 0x0127C5BC
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

		// Token: 0x060481AC RID: 295340 RVA: 0x0127E458 File Offset: 0x0127C658
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

		// Token: 0x060481AD RID: 295341 RVA: 0x0127E5C8 File Offset: 0x0127C7C8
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

		// Token: 0x060481AE RID: 295342 RVA: 0x0127E68C File Offset: 0x0127C88C
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

		// Token: 0x060481AF RID: 295343 RVA: 0x0127E750 File Offset: 0x0127C950
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

		// Token: 0x060481B0 RID: 295344 RVA: 0x0127E790 File Offset: 0x0127C990
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

		// Token: 0x060481B1 RID: 295345 RVA: 0x0127E830 File Offset: 0x0127CA30
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

		// Token: 0x060481B2 RID: 295346 RVA: 0x0127E8B8 File Offset: 0x0127CAB8
		public static void SetCameraRotationWithAxisString(string pitchStr, string yawStr)
		{
			float inPitch = MathCommon.Clamp(float.Parse(pitchStr), -89.9f, 89.9f);
			float inYaw = MathUtils.Instance.WrapAngle(float.Parse(yawStr));
			float inRoll = 0f;
			CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(new FRotator(inPitch, inYaw, inRoll));
		}

		// Token: 0x060481B3 RID: 295347 RVA: 0x0127E914 File Offset: 0x0127CB14
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

		// Token: 0x060481B4 RID: 295348 RVA: 0x0127E964 File Offset: 0x0127CB64
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

		// Token: 0x060481B5 RID: 295349 RVA: 0x0127EA14 File Offset: 0x0127CC14
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

		// Token: 0x060481B6 RID: 295350 RVA: 0x0127EAC4 File Offset: 0x0127CCC4
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

		// Token: 0x060481B7 RID: 295351 RVA: 0x0127EB30 File Offset: 0x0127CD30
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

		// Token: 0x060481B8 RID: 295352 RVA: 0x0127EB9C File Offset: 0x0127CD9C
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

		// Token: 0x060481B9 RID: 295353 RVA: 0x0127EC08 File Offset: 0x0127CE08
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

		// Token: 0x060481BA RID: 295354 RVA: 0x0127EC54 File Offset: 0x0127CE54
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

		// Token: 0x060481BB RID: 295355 RVA: 0x0127ECA0 File Offset: 0x0127CEA0
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

		// Token: 0x060481BC RID: 295356 RVA: 0x0127ECFC File Offset: 0x0127CEFC
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

		// Token: 0x060481BD RID: 295357 RVA: 0x0127EDA8 File Offset: 0x0127CFA8
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

		// Token: 0x060481BE RID: 295358 RVA: 0x0127EE68 File Offset: 0x0127D068
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

		// Token: 0x060481BF RID: 295359 RVA: 0x0127EEC4 File Offset: 0x0127D0C4
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

		// Token: 0x060481C0 RID: 295360 RVA: 0x0127EF58 File Offset: 0x0127D158
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

		// Token: 0x060481C1 RID: 295361 RVA: 0x0127F000 File Offset: 0x0127D200
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

		// Token: 0x060481C2 RID: 295362 RVA: 0x0127F05C File Offset: 0x0127D25C
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

		// Token: 0x060481C3 RID: 295363 RVA: 0x0127F0F0 File Offset: 0x0127D2F0
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

		// Token: 0x060481C4 RID: 295364 RVA: 0x0127F198 File Offset: 0x0127D398
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

		// Token: 0x060481C5 RID: 295365 RVA: 0x0127F208 File Offset: 0x0127D408
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

		// Token: 0x060481C6 RID: 295366 RVA: 0x0127F27C File Offset: 0x0127D47C
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

		// Token: 0x060481C7 RID: 295367 RVA: 0x0127F2EC File Offset: 0x0127D4EC
		public static float GetZnInGravity(global::Vector vector)
		{
			FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
			if (!logicComponent.Valid || logicComponent.IsInNormalGravityMode())
			{
				return (float)vector.Z;
			}
			return (float)CameraUtility.GetVectorInGravity(vector, CameraUtility.TempVector).Z;
		}

		// Token: 0x060481C8 RID: 295368 RVA: 0x0127F338 File Offset: 0x0127D538
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

		// Token: 0x060481C9 RID: 295369 RVA: 0x0127F39C File Offset: 0x0127D59C
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

		// Token: 0x060481CA RID: 295370 RVA: 0x0127F420 File Offset: 0x0127D620
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

		// Token: 0x060481CB RID: 295371 RVA: 0x0127F4A8 File Offset: 0x0127D6A8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060481CC RID: 295372 RVA: 0x0127F4AA File Offset: 0x0127D6AA
		public static void ResetStaticDefaultValue()
		{
			CameraUtility._cameraSphereTrace = null;
		}

		// Token: 0x040260B0 RID: 155824
		private const string PROFILE_KEY = "CameraUtility_CheckCollision_Camera";

		// Token: 0x040260B1 RID: 155825
		private const float RESET_FOCUS_TIME = 0.6f;

		// Token: 0x040260B2 RID: 155826
		private const float PITCH_LIMIT_VALUE = 89.9f;

		// Token: 0x040260B3 RID: 155827
		[StaticVariableRuleIgnore]
		public static readonly FName CameraPosition = new FName("CameraPosition");

		// Token: 0x040260B4 RID: 155828
		[StaticVariableRuleIgnore]
		public static readonly FName HitCase = new FName("HitCase");

		// Token: 0x040260B5 RID: 155829
		[StaticVariableRuleIgnore]
		public static readonly FName Root = new FName("Root");

		// Token: 0x040260B6 RID: 155830
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeDefault = new FName("KuroDefault");

		// Token: 0x040260B7 RID: 155831
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeLockOn = new FName("KuroLockOn");

		// Token: 0x040260B8 RID: 155832
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeWidget = new FName("KuroWidget");

		// Token: 0x040260B9 RID: 155833
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeSequence = new FName("KuroSequence");

		// Token: 0x040260BA RID: 155834
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeScene = new FName("KuroScene");

		// Token: 0x040260BB RID: 155835
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeOrbital = new FName("KuroOrbital");

		// Token: 0x040260BC RID: 155836
		[StaticVariableRuleIgnore]
		public static readonly FName CameraModeFree = new FName("KuroFree");

		// Token: 0x040260BD RID: 155837
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TempVector = global::Vector.Create();

		// Token: 0x040260BE RID: 155838
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TempVector1 = global::Vector.Create();

		// Token: 0x040260BF RID: 155839
		[StaticVariableRuleIgnore]
		private static readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040260C0 RID: 155840
		[StaticVariableRuleIgnore]
		private static readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040260C1 RID: 155841
		[StaticVariableRuleIgnore]
		private static readonly global::Rotator TempRotator = global::Rotator.Create();

		// Token: 0x040260C2 RID: 155842
		public static readonly float CapsuleHeightRatio = 0.67f;

		// Token: 0x040260C3 RID: 155843
		[Nullable(2)]
		private static UTraceSphereElement _cameraSphereTrace;
	}
}
