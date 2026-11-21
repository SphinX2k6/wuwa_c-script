using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002395 RID: 9109
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/CharacterBlueprintFunctionLibrary.CharacterBlueprintFunctionLibrary_C")]
public class CharacterBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601680E RID: 92174 RVA: 0x00694955 File Offset: 0x00692B55
	static CharacterBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(CharacterBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x0601680F RID: 92175 RVA: 0x00694974 File Offset: 0x00692B74
	public static void CreateStaticDefaultValue()
	{
		CharacterBlueprintFunctionLibrary._entityTimeDilation = default(SEntityTimeDilation);
	}

	// Token: 0x06016810 RID: 92176 RVA: 0x00694981 File Offset: 0x00692B81
	public static void ResetStaticDefaultValue()
	{
		CharacterBlueprintFunctionLibrary._entityTimeDilation = default(SEntityTimeDilation);
		CharacterBlueprintFunctionLibrary.ResumeTimeHandle = null;
	}

	// Token: 0x06016811 RID: 92177 RVA: 0x00694994 File Offset: 0x00692B94
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetPartCollisionSwitch(TsBaseCharacter character, string compName, bool isBlockPawn, bool isBulletDetect, bool isBlockCamera, bool isActiveOcclusionDither)
	{
		if (character.IsValid())
		{
			CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.Valid)
			{
				character.CharacterActorComponent.SetPartCollisionSwitch(compName, isBlockPawn, isBulletDetect, isBlockCamera, isActiveOcclusionDither, false);
				return;
			}
		}
		Log.Instance.Error(ELogModule.Character, ELogAuthor.HCW, "传入的character为空", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06016812 RID: 92178 RVA: 0x006949F0 File Offset: 0x00692BF0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ResetPartCollisionSwitch(TsBaseCharacter character, string compName)
	{
		CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
		SPartHitEffect partConf = characterActorComponent.GetPartConf(compName);
		if (partConf != null)
		{
			characterActorComponent.SetPartCollisionSwitch(compName, partConf.IsBlockPawn, partConf.IsBulletDetect, partConf.IsBlockCamera, partConf.IsActiveOcclusionDither, false);
		}
	}

	// Token: 0x06016813 RID: 92179 RVA: 0x00694A38 File Offset: 0x00692C38
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TsBaseCharacter GetCharacterActorByEntityId(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		return ((component != null) ? component.Owner : null) as TsBaseCharacter;
	}

	// Token: 0x06016814 RID: 92180 RVA: 0x00694A75 File Offset: 0x00692C75
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CharacterOperationRecord(bool open)
	{
		CharacterStatisticsComponent.OperationRecord(open);
		if (open)
		{
			CharacterGasDebugComponent.BeginRecord();
			return;
		}
		CharacterGasDebugComponent.EndRecord();
	}

	// Token: 0x06016815 RID: 92181 RVA: 0x00694A8C File Offset: 0x00692C8C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetStatisticsOpen()
	{
		return CharacterStatisticsComponent.OpenOperationRecord;
	}

	// Token: 0x06016816 RID: 92182 RVA: 0x00694A94 File Offset: 0x00692C94
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool SaveCharacterOperationRecord()
	{
		CharacterGasDebugComponent.EndRecord();
		string text = CharacterStatisticsComponent.ExportRecord();
		return text != null && (UKuroStaticLibrary.SaveStringToFile(text, UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/OperationRecord.csv", true) && CharacterBlueprintFunctionLibrary.SaveCharacterStatisticsData());
	}

	// Token: 0x06016817 RID: 92183 RVA: 0x00694AD4 File Offset: 0x00692CD4
	public static bool SaveCharacterStatisticsData()
	{
		string text = CharacterStatisticsComponent.ExportStatisticsByAttackType();
		string text2 = CharacterStatisticsComponent.ExportStatisticsBySkillType();
		bool flag = text.Length == 0;
		bool flag2 = text2.Length == 0;
		if (flag || flag2)
		{
			return false;
		}
		string str = UBlueprintPathsLibrary.ProjectSavedDir();
		bool flag3 = UKuroStaticLibrary.SaveStringToFile(text, str + "Statistics/FightDataRecord/DamageStatisticsRecord_B.csv", true);
		bool flag4 = UKuroStaticLibrary.SaveStringToFile(text2, str + "Statistics/FightDataRecord/DamageStatisticsRecord_A.csv", true);
		return flag3 && flag4;
	}

	// Token: 0x06016818 RID: 92184 RVA: 0x00694B3A File Offset: 0x00692D3A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetOperationRecordCount()
	{
		return (float)CharacterStatisticsComponent.OperationRecordCount();
	}

	// Token: 0x06016819 RID: 92185 RVA: 0x00694B42 File Offset: 0x00692D42
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CleanupOperationRecord()
	{
		CharacterStatisticsComponent.CleanupOperationRecord();
		CharacterStatisticsComponent.CleanupRecordData();
		CharacterGasDebugComponent.CleanupRecord();
	}

	// Token: 0x0601681A RID: 92186 RVA: 0x00694B53 File Offset: 0x00692D53
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetHalfLengthRecord(float sideLenHalf)
	{
		CharacterStatisticsComponent.HalfLengthRecordSquared = Math.Pow((double)sideLenHalf, 2.0);
	}

	// Token: 0x0601681B RID: 92187 RVA: 0x00694B6C File Offset: 0x00692D6C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCombatStarted(bool started, int attackerIndex, int targetIndex, bool isDamage, bool isCure, bool isSkillUsed, bool isState, bool isKill, bool isReborn)
	{
		List<ECombatDataType> list = new List<ECombatDataType>();
		if (isDamage)
		{
			list.Add(ECombatDataType.Damage);
		}
		if (isCure)
		{
			list.Add(ECombatDataType.Heal);
		}
		if (isSkillUsed)
		{
			list.Add(ECombatDataType.SkillUsed);
		}
		if (isState)
		{
			list.Add(ECombatDataType.State);
		}
		if (isKill)
		{
			list.Add(ECombatDataType.Kill);
		}
		if (isReborn)
		{
			list.Add(ECombatDataType.Revive);
		}
		CharacterStatisticsComponent.SetCombatStarted(started, list, attackerIndex, targetIndex);
	}

	// Token: 0x0601681C RID: 92188 RVA: 0x00694BCC File Offset: 0x00692DCC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetTypeOpen(bool isDamage, bool isCure, bool isSkillUsed, bool isState, bool isKill, bool isReborn)
	{
		List<ECombatDataType> list = new List<ECombatDataType>();
		if (isDamage)
		{
			list.Add(ECombatDataType.Damage);
		}
		if (isCure)
		{
			list.Add(ECombatDataType.Heal);
		}
		if (isSkillUsed)
		{
			list.Add(ECombatDataType.SkillUsed);
		}
		if (isState)
		{
			list.Add(ECombatDataType.State);
		}
		if (isKill)
		{
			list.Add(ECombatDataType.Kill);
		}
		if (isReborn)
		{
			list.Add(ECombatDataType.Revive);
		}
		CharacterStatisticsComponent.SetTypeOpen(list);
	}

	// Token: 0x0601681D RID: 92189 RVA: 0x00694C23 File Offset: 0x00692E23
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetAttackerCombatEntities()
	{
		return CharacterStatisticsComponent.GetAttackerCombatEntities();
	}

	// Token: 0x0601681E RID: 92190 RVA: 0x00694C2A File Offset: 0x00692E2A
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetTargetCombatEntities()
	{
		return CharacterStatisticsComponent.GetTargetCombatEntities();
	}

	// Token: 0x0601681F RID: 92191 RVA: 0x00694C31 File Offset: 0x00692E31
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCurrentAttacker(int index)
	{
		CharacterStatisticsComponent.SetCurrentAttacker(index);
	}

	// Token: 0x06016820 RID: 92192 RVA: 0x00694C39 File Offset: 0x00692E39
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCurrentTarget(int index)
	{
		CharacterStatisticsComponent.SetCurrentTarget(index);
	}

	// Token: 0x06016821 RID: 92193 RVA: 0x00694C41 File Offset: 0x00692E41
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetItemsReset()
	{
		return CharacterStatisticsComponent.ItemReset;
	}

	// Token: 0x06016822 RID: 92194 RVA: 0x00694C48 File Offset: 0x00692E48
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OnItemsResetFinished()
	{
		CharacterStatisticsComponent.OnItemsResetFinished();
	}

	// Token: 0x06016823 RID: 92195 RVA: 0x00694C4F File Offset: 0x00692E4F
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetSubItemsListView(int startIndex, int length)
	{
		return CharacterStatisticsComponent.GetSubItemsListView(startIndex, length);
	}

	// Token: 0x06016824 RID: 92196 RVA: 0x00694C58 File Offset: 0x00692E58
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetItemListViewCount()
	{
		return CharacterStatisticsComponent.GetItemListViewCount();
	}

	// Token: 0x06016825 RID: 92197 RVA: 0x00694C5F File Offset: 0x00692E5F
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TestLeaveSplineMove(TsBaseCharacter actor)
	{
		actor.GetEntityNoBlueprint().GetComponent<CharacterSplineMoveComponent>().EndSplineMove(1);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraSpline();
	}

	// Token: 0x06016826 RID: 92198 RVA: 0x00694C8C File Offset: 0x00692E8C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FTransformDouble GetBaseCharacterTransform()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (characterActorComponent != null)
		{
			return characterActorComponent.ActorTransform;
		}
		return MathUtils.Instance.DefaultTransformDouble;
	}

	// Token: 0x06016827 RID: 92199 RVA: 0x00694CC0 File Offset: 0x00692EC0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetActorExtraSkeletalMeshComponent(int entityId, USkeletalMeshComponent skeletalMeshComponent)
	{
		EntityHandle handle = CharacterModel.Instance.GetHandle(entityId);
		if (handle == null)
		{
			return;
		}
		WorldEntity entity = handle.Entity;
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		if (characterActorComponent == null)
		{
			return;
		}
		characterActorComponent.AddExtraSkeletalMeshComponent(skeletalMeshComponent);
	}

	// Token: 0x06016828 RID: 92200 RVA: 0x00694CFC File Offset: 0x00692EFC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool CanCharacterMonsterOrSummonedDisplayEffect(TsBaseCharacter owner)
	{
		if (owner == null)
		{
			return true;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(owner.EntityId);
		return entityById == null || !entityById.Valid || CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityById);
	}

	// Token: 0x06016829 RID: 92201 RVA: 0x00694D40 File Offset: 0x00692F40
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DetachFromHost(int id, bool isDetachFollower, bool isRecursion)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return;
		}
		CharacterAttachComponent component = entity.GetComponent<CharacterAttachComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		component.DetachFromHost(isDetachFollower, isRecursion, true, null);
	}

	// Token: 0x0601682A RID: 92202 RVA: 0x00694D8A File Offset: 0x00692F8A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetCharacterGravityDirect()
	{
		GravityUtils instance = GravityUtils.Instance;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		return instance.GetGravityDirectForActor((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null).ToUeVector(false);
	}

	// Token: 0x0601682B RID: 92203 RVA: 0x00694DAD File Offset: 0x00692FAD
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetCharacterGravityUp()
	{
		GravityUtils instance = GravityUtils.Instance;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		return instance.GetGravityUpForActor((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null).ToUeVector(false);
	}

	// Token: 0x0601682C RID: 92204 RVA: 0x00694DD0 File Offset: 0x00692FD0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetGravityDirect(int entityId, FVectorDouble gravityDirect)
	{
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
		if (entityById == null || !entityById.Valid)
		{
			return;
		}
		BaseGravityComponent component = entityById.Entity.GetComponent<BaseGravityComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		component.SetGravityByPriority(0, gravityDirect, true, -1f, false);
	}

	// Token: 0x0601682D RID: 92205 RVA: 0x00694E24 File Offset: 0x00693024
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static void EnableSelfCentered(ESelfCenteredMode selfCenteredMode, float timeDilation, float duration)
	{
		if (CharacterBlueprintFunctionLibrary.ResumeTimeHandle != null && CharacterBlueprintFunctionLibrary.ResumeTimeHandle.Valid())
		{
			TimerSystem.Instance.Remove(CharacterBlueprintFunctionLibrary.ResumeTimeHandle);
			CharacterBlueprintFunctionLibrary.ResumeTimeHandle = null;
		}
		float interval = duration * (float)TimeUtil.Instance.InverseMillisecond * timeDilation;
		CharacterController.Instance.EnterSelfCenteredMode(selfCenteredMode, timeDilation, duration);
		if (interval > 0f)
		{
			CharacterBlueprintFunctionLibrary.ResumeTimeHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.TimeDilation;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "EnableSelfCentered StopTimerSystem";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("selfCenteredMode", selfCenteredMode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("timeDilation", timeDilation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("interval(ms)", interval);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3);
				string item2 = "timerHandle.Id";
				TimerHandle resumeTimeHandle2 = CharacterBlueprintFunctionLibrary.ResumeTimeHandle;
				ptr2 = new ValueTuple<string, object>(item2, (resumeTimeHandle2 != null) ? new int?(resumeTimeHandle2.Id) : null);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				if (selfCenteredMode == ESelfCenteredMode.Skill)
				{
					CharacterController.Instance.ExitSkillSelfCenteredMode();
				}
				else
				{
					CharacterController.Instance.ExitSelfCenteredMode(selfCenteredMode);
				}
				if (CharacterBlueprintFunctionLibrary.ResumeTimeHandle != null && CharacterBlueprintFunctionLibrary.ResumeTimeHandle.Valid())
				{
					TimerSystem.Instance.Remove(CharacterBlueprintFunctionLibrary.ResumeTimeHandle);
					CharacterBlueprintFunctionLibrary.ResumeTimeHandle = null;
				}
			}, (float)((int)interval), null, null, true, 1f);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TimeDilation;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "EnableSelfCentered EnableTimerSystem";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("timeDilation", timeDilation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("selfCenteredMode", selfCenteredMode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("interval(ms)", interval);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item = "timerHandle.Id";
			TimerHandle resumeTimeHandle = CharacterBlueprintFunctionLibrary.ResumeTimeHandle;
			ptr = new ValueTuple<string, object>(item, (resumeTimeHandle != null) ? new int?(resumeTimeHandle.Id) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x0601682E RID: 92206 RVA: 0x00694FA0 File Offset: 0x006931A0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DisableSelfCentered(ESelfCenteredMode selfCenteredMode)
	{
		CharacterController.Instance.ExitSelfCenteredMode(selfCenteredMode);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TimeDilation;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "DisableSelfCentered";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("selfCenteredMode", selfCenteredMode);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601682F RID: 92207 RVA: 0x00694FE7 File Offset: 0x006931E7
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsAnySelfCenteredModeEnabled()
	{
		CharacterModel instance = CharacterModel.Instance;
		return instance != null && instance.EnabledSelfCentered;
	}

	// Token: 0x06016830 RID: 92208 RVA: 0x00694FF9 File Offset: 0x006931F9
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsSelfCenteredModeEnabled(ESelfCenteredMode selfCenteredMode)
	{
		return CharacterController.Instance.IsSelfCenteredModeEnabled(selfCenteredMode);
	}

	// Token: 0x06016831 RID: 92209 RVA: 0x00695008 File Offset: 0x00693208
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SEntityTimeDilation GetEntityForeverTimeDilation(int entityId)
	{
		CharacterBlueprintFunctionLibrary._entityTimeDilation.SourceType = -1;
		PawnTimeScaleComponent component = EntitySystem.Instance.GetComponent<PawnTimeScaleComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return CharacterBlueprintFunctionLibrary._entityTimeDilation;
		}
		ForeverTimeScale topForeverTimeScaleConfig = component.GetTopForeverTimeScaleConfig(null);
		if (topForeverTimeScaleConfig == null)
		{
			return CharacterBlueprintFunctionLibrary._entityTimeDilation;
		}
		CharacterBlueprintFunctionLibrary._entityTimeDilation.SourceType = (int)topForeverTimeScaleConfig.SourceType;
		CharacterBlueprintFunctionLibrary._entityTimeDilation.TimeDilation = topForeverTimeScaleConfig.TimeDilation;
		return CharacterBlueprintFunctionLibrary._entityTimeDilation;
	}

	// Token: 0x06016832 RID: 92210 RVA: 0x0069507B File Offset: 0x0069327B
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ESelfCenteredMode GetSelfCenteredMode()
	{
		return CharacterModel.Instance.SelfCenteredMode;
	}

	// Token: 0x06016833 RID: 92211 RVA: 0x00695087 File Offset: 0x00693287
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetSelfCenteredTimeDilation()
	{
		return CharacterModel.Instance.SelfCenteredTimeDilation;
	}

	// Token: 0x06016834 RID: 92212 RVA: 0x00695093 File Offset: 0x00693293
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetInverseSelfCenteredTimeDilation()
	{
		return CharacterModel.Instance.InverseSelfCenteredTimeDilation;
	}

	// Token: 0x06016835 RID: 92213 RVA: 0x006950A0 File Offset: 0x006932A0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetPlanarReflectionShowPlayers(UPlanarReflectionComponent comp)
	{
		foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
		{
			EntityHandle entityHandle = sceneTeamItem.EntityHandle;
			object obj;
			if (entityHandle == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				if (entity == null)
				{
					obj = null;
				}
				else
				{
					CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
					obj = ((component != null) ? component.Owner : null);
				}
			}
			TsBaseCharacter tsBaseCharacter = obj as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				comp.ShowOnlyActors.Add(tsBaseCharacter);
			}
		}
	}

	// Token: 0x06016836 RID: 92214 RVA: 0x00695130 File Offset: 0x00693330
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCharacterDirectlySightLockEnableState(int id, bool bEnable)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return;
		}
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component == null)
		{
			return;
		}
		component.SetDirectlySightEnableState(bEnable, "通过蓝图接口设置");
	}

	// Token: 0x06016837 RID: 92215 RVA: 0x0069516C File Offset: 0x0069336C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCharacterSightLockBoneLimit(int id, float yawMin = -23f, float yawMax = 23f, float pitchMin = -10f, float pitchMax = 13f, float assistLimit = 5f, FVector sightDirectInSightBone = default(FVector), FVector upAxisInSightBone = default(FVector))
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return;
		}
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component == null)
		{
			return;
		}
		component.SetSightBoneLimit(yawMin, yawMax, pitchMin, pitchMax, assistLimit, sightDirectInSightBone, upAxisInSightBone);
	}

	// Token: 0x06016838 RID: 92216 RVA: 0x006951AC File Offset: 0x006933AC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RestoreSightLockBoneLimit(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return;
		}
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component == null)
		{
			return;
		}
		component.RestoreSightBoneLimit();
	}

	// Token: 0x06016839 RID: 92217 RVA: 0x006951E4 File Offset: 0x006933E4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetCharacterMovementModeInfo(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return "";
		}
		CharacterMoveComponent component = entity.GetComponent<CharacterMoveComponent>();
		UCharacterMovementComponent ucharacterMovementComponent = (component != null) ? component.CharacterMovement : null;
		if (ucharacterMovementComponent == null || !ucharacterMovementComponent.IsValid())
		{
			return "";
		}
		CharacterUnifiedStateComponent component2 = entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component2 == null || !component2.Valid)
		{
			return "";
		}
		return "Mode: " + ucharacterMovementComponent.MovementMode.ToString() + ", CustomMode: " + CharacterUtils.GetCustomMovementModeName((int)ucharacterMovementComponent.CustomMovementMode);
	}

	// Token: 0x0601683A RID: 92218 RVA: 0x00695280 File Offset: 0x00693480
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetCharacterMovementStateInfo(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (!(((entity != null) ? new bool?(entity.Valid) : null) ?? false))
		{
			return "";
		}
		CharacterMoveComponent component = entity.GetComponent<CharacterMoveComponent>();
		UCharacterMovementComponent ucharacterMovementComponent = (component != null) ? component.CharacterMovement : null;
		if (ucharacterMovementComponent == null || !ucharacterMovementComponent.IsValid())
		{
			return "";
		}
		CharacterUnifiedStateComponent component2 = entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component2 == null || !component2.Valid)
		{
			return "";
		}
		return "PositionState: " + component2.PositionState.ToString() + ", MoveState: " + component2.MoveState.ToString();
	}

	// Token: 0x0601683B RID: 92219 RVA: 0x00695344 File Offset: 0x00693544
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetVehicleMovementModeInfo(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return "";
		}
		VehicleMoveComponent component = entity.GetComponent<VehicleMoveComponent>();
		UKuroVehicleMovementComponent ukuroVehicleMovementComponent = (component != null) ? component.VehicleMovement : null;
		if (component == null || !component.Valid || ukuroVehicleMovementComponent == null || !ukuroVehicleMovementComponent.IsValid())
		{
			return "";
		}
		return "Mode: " + CharacterUtils.GetVehicleMovementModeName(ukuroVehicleMovementComponent.MovementMode) + ", ";
	}

	// Token: 0x0601683C RID: 92220 RVA: 0x006953C0 File Offset: 0x006935C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetVehicleMovementStateInfo(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return "";
		}
		VehicleMoveComponent component = entity.GetComponent<VehicleMoveComponent>();
		if (component == null || !component.Valid || component.VehicleMovement == null || !component.VehicleMovement.IsValid())
		{
			return "";
		}
		string text = "";
		MotorcycleMoveComponent motorcycleMoveComponent = component as MotorcycleMoveComponent;
		if (motorcycleMoveComponent != null)
		{
			text = ", Drifting: " + (motorcycleMoveComponent.DriftingState ? "true" : "false");
		}
		return string.Concat(new string[]
		{
			"IsMoving: ",
			component.IsMoving ? "true" : "false",
			", IsStandardGravity: ",
			component.IsStandardGravity ? "true" : "false",
			text
		});
	}

	// Token: 0x0601683D RID: 92221 RVA: 0x00695493 File Offset: 0x00693693
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CharacterBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/CharacterBlueprintFunctionLibrary.CharacterBlueprintFunctionLibrary_C");
		}
		return CharacterBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601683E RID: 92222 RVA: 0x006954B8 File Offset: 0x006936B8
	public CharacterBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(CharacterBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601683F RID: 92223 RVA: 0x006954E0 File Offset: 0x006936E0
	[NullableContext(1)]
	public CharacterBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharacterBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016840 RID: 92224 RVA: 0x00695513 File Offset: 0x00693713
	protected CharacterBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016841 RID: 92225 RVA: 0x0069551C File Offset: 0x0069371C
	protected unsafe static void __CPPCALL_SetPartCollisionSwitch_Implementation(CharacterBlueprintFunctionLibrary.__SetPartCollisionSwitch_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->character);
		string compName = FString.ToString((void*)(&__Params->compName));
		CharacterBlueprintFunctionLibrary.SetPartCollisionSwitch(orCreateUObjectByNativePointer, compName, __Params->isBlockPawn, __Params->isBulletDetect, __Params->isBlockCamera, __Params->isActiveOcclusionDither);
	}

	// Token: 0x06016842 RID: 92226 RVA: 0x00695560 File Offset: 0x00693760
	protected unsafe static void __CPPCALL_ResetPartCollisionSwitch_Implementation(CharacterBlueprintFunctionLibrary.__ResetPartCollisionSwitch_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->character);
		string compName = FString.ToString((void*)(&__Params->compName));
		CharacterBlueprintFunctionLibrary.ResetPartCollisionSwitch(orCreateUObjectByNativePointer, compName);
	}

	// Token: 0x06016843 RID: 92227 RVA: 0x0069558B File Offset: 0x0069378B
	protected unsafe static void __CPPCALL_GetCharacterActorByEntityId_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterActorByEntityId_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter characterActorByEntityId = CharacterBlueprintFunctionLibrary.GetCharacterActorByEntityId(__Params->id);
		ptr = ((characterActorByEntityId != null) ? characterActorByEntityId.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016844 RID: 92228 RVA: 0x006955AD File Offset: 0x006937AD
	protected unsafe static void __CPPCALL_CharacterOperationRecord_Implementation(CharacterBlueprintFunctionLibrary.__CharacterOperationRecord_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.CharacterOperationRecord(__Params->open);
	}

	// Token: 0x06016845 RID: 92229 RVA: 0x006955BA File Offset: 0x006937BA
	protected unsafe static void __CPPCALL_GetStatisticsOpen_Implementation(CharacterBlueprintFunctionLibrary.__GetStatisticsOpen_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetStatisticsOpen();
	}

	// Token: 0x06016846 RID: 92230 RVA: 0x006955C7 File Offset: 0x006937C7
	protected unsafe static void __CPPCALL_SaveCharacterOperationRecord_Implementation(CharacterBlueprintFunctionLibrary.__SaveCharacterOperationRecord_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.SaveCharacterOperationRecord();
	}

	// Token: 0x06016847 RID: 92231 RVA: 0x006955D4 File Offset: 0x006937D4
	protected unsafe static void __CPPCALL_GetOperationRecordCount_Implementation(CharacterBlueprintFunctionLibrary.__GetOperationRecordCount_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetOperationRecordCount();
	}

	// Token: 0x06016848 RID: 92232 RVA: 0x006955E1 File Offset: 0x006937E1
	protected unsafe static void __CPPCALL_CleanupOperationRecord_Implementation(CharacterBlueprintFunctionLibrary.__CleanupOperationRecord_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.CleanupOperationRecord();
	}

	// Token: 0x06016849 RID: 92233 RVA: 0x006955E8 File Offset: 0x006937E8
	protected unsafe static void __CPPCALL_SetHalfLengthRecord_Implementation(CharacterBlueprintFunctionLibrary.__SetHalfLengthRecord_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetHalfLengthRecord(__Params->sideLenHalf);
	}

	// Token: 0x0601684A RID: 92234 RVA: 0x006955F8 File Offset: 0x006937F8
	protected unsafe static void __CPPCALL_SetCombatStarted_Implementation(CharacterBlueprintFunctionLibrary.__SetCombatStarted_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCombatStarted(__Params->started, __Params->attackerIndex, __Params->targetIndex, __Params->isDamage, __Params->isCure, __Params->isSkillUsed, __Params->isState, __Params->isKill, __Params->isReborn);
	}

	// Token: 0x0601684B RID: 92235 RVA: 0x00695640 File Offset: 0x00693840
	protected unsafe static void __CPPCALL_SetTypeOpen_Implementation(CharacterBlueprintFunctionLibrary.__SetTypeOpen_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetTypeOpen(__Params->isDamage, __Params->isCure, __Params->isSkillUsed, __Params->isState, __Params->isKill, __Params->isReborn);
	}

	// Token: 0x0601684C RID: 92236 RVA: 0x0069566C File Offset: 0x0069386C
	protected unsafe static void __CPPCALL_GetAttackerCombatEntities_Implementation(CharacterBlueprintFunctionLibrary.__GetAttackerCombatEntities_FunctionParams* __Params)
	{
		TArray<string> attackerCombatEntities = CharacterBlueprintFunctionLibrary.GetAttackerCombatEntities();
		if (attackerCombatEntities == null)
		{
			return;
		}
		attackerCombatEntities.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601684D RID: 92237 RVA: 0x00695698 File Offset: 0x00693898
	protected unsafe static void __CPPCALL_GetTargetCombatEntities_Implementation(CharacterBlueprintFunctionLibrary.__GetTargetCombatEntities_FunctionParams* __Params)
	{
		TArray<string> targetCombatEntities = CharacterBlueprintFunctionLibrary.GetTargetCombatEntities();
		if (targetCombatEntities == null)
		{
			return;
		}
		targetCombatEntities.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601684E RID: 92238 RVA: 0x006956C4 File Offset: 0x006938C4
	protected unsafe static void __CPPCALL_SetCurrentAttacker_Implementation(CharacterBlueprintFunctionLibrary.__SetCurrentAttacker_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCurrentAttacker(__Params->index);
	}

	// Token: 0x0601684F RID: 92239 RVA: 0x006956D1 File Offset: 0x006938D1
	protected unsafe static void __CPPCALL_SetCurrentTarget_Implementation(CharacterBlueprintFunctionLibrary.__SetCurrentTarget_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCurrentTarget(__Params->index);
	}

	// Token: 0x06016850 RID: 92240 RVA: 0x006956DE File Offset: 0x006938DE
	protected unsafe static void __CPPCALL_GetItemsReset_Implementation(CharacterBlueprintFunctionLibrary.__GetItemsReset_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetItemsReset();
	}

	// Token: 0x06016851 RID: 92241 RVA: 0x006956EB File Offset: 0x006938EB
	protected unsafe static void __CPPCALL_OnItemsResetFinished_Implementation(CharacterBlueprintFunctionLibrary.__OnItemsResetFinished_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.OnItemsResetFinished();
	}

	// Token: 0x06016852 RID: 92242 RVA: 0x006956F4 File Offset: 0x006938F4
	protected unsafe static void __CPPCALL_GetSubItemsListView_Implementation(CharacterBlueprintFunctionLibrary.__GetSubItemsListView_FunctionParams* __Params)
	{
		TArray<string> subItemsListView = CharacterBlueprintFunctionLibrary.GetSubItemsListView(__Params->startIndex, __Params->length);
		if (subItemsListView == null)
		{
			return;
		}
		subItemsListView.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06016853 RID: 92243 RVA: 0x0069572C File Offset: 0x0069392C
	protected unsafe static void __CPPCALL_GetItemListViewCount_Implementation(CharacterBlueprintFunctionLibrary.__GetItemListViewCount_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetItemListViewCount();
	}

	// Token: 0x06016854 RID: 92244 RVA: 0x00695739 File Offset: 0x00693939
	protected unsafe static void __CPPCALL_TestLeaveSplineMove_Implementation(CharacterBlueprintFunctionLibrary.__TestLeaveSplineMove_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.TestLeaveSplineMove(BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->actor));
	}

	// Token: 0x06016855 RID: 92245 RVA: 0x0069574B File Offset: 0x0069394B
	protected unsafe static void __CPPCALL_GetBaseCharacterTransform_Implementation(CharacterBlueprintFunctionLibrary.__GetBaseCharacterTransform_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetBaseCharacterTransform();
	}

	// Token: 0x06016856 RID: 92246 RVA: 0x00695758 File Offset: 0x00693958
	protected unsafe static void __CPPCALL_SetActorExtraSkeletalMeshComponent_Implementation(CharacterBlueprintFunctionLibrary.__SetActorExtraSkeletalMeshComponent_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->skeletalMeshComponent);
		CharacterBlueprintFunctionLibrary.SetActorExtraSkeletalMeshComponent(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016857 RID: 92247 RVA: 0x00695780 File Offset: 0x00693980
	protected unsafe static void __CPPCALL_CanCharacterMonsterOrSummonedDisplayEffect_Implementation(CharacterBlueprintFunctionLibrary.__CanCharacterMonsterOrSummonedDisplayEffect_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		__Params->__Result = CharacterBlueprintFunctionLibrary.CanCharacterMonsterOrSummonedDisplayEffect(orCreateUObjectByNativePointer);
	}

	// Token: 0x06016858 RID: 92248 RVA: 0x006957A5 File Offset: 0x006939A5
	protected unsafe static void __CPPCALL_DetachFromHost_Implementation(CharacterBlueprintFunctionLibrary.__DetachFromHost_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.DetachFromHost(__Params->id, __Params->isDetachFollower, __Params->isRecursion);
	}

	// Token: 0x06016859 RID: 92249 RVA: 0x006957BE File Offset: 0x006939BE
	protected unsafe static void __CPPCALL_GetCharacterGravityDirect_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterGravityDirect_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetCharacterGravityDirect();
	}

	// Token: 0x0601685A RID: 92250 RVA: 0x006957CB File Offset: 0x006939CB
	protected unsafe static void __CPPCALL_GetCharacterGravityUp_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterGravityUp_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetCharacterGravityUp();
	}

	// Token: 0x0601685B RID: 92251 RVA: 0x006957D8 File Offset: 0x006939D8
	protected unsafe static void __CPPCALL_SetGravityDirect_Implementation(CharacterBlueprintFunctionLibrary.__SetGravityDirect_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetGravityDirect(__Params->entityId, __Params->gravityDirect);
	}

	// Token: 0x0601685C RID: 92252 RVA: 0x006957EB File Offset: 0x006939EB
	protected unsafe static void __CPPCALL_EnableSelfCentered_Implementation(CharacterBlueprintFunctionLibrary.__EnableSelfCentered_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.EnableSelfCentered((ESelfCenteredMode)__Params->selfCenteredMode, __Params->timeDilation, __Params->duration);
	}

	// Token: 0x0601685D RID: 92253 RVA: 0x00695804 File Offset: 0x00693A04
	protected unsafe static void __CPPCALL_DisableSelfCentered_Implementation(CharacterBlueprintFunctionLibrary.__DisableSelfCentered_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.DisableSelfCentered((ESelfCenteredMode)__Params->selfCenteredMode);
	}

	// Token: 0x0601685E RID: 92254 RVA: 0x00695811 File Offset: 0x00693A11
	protected unsafe static void __CPPCALL_IsAnySelfCenteredModeEnabled_Implementation(CharacterBlueprintFunctionLibrary.__IsAnySelfCenteredModeEnabled_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.IsAnySelfCenteredModeEnabled();
	}

	// Token: 0x0601685F RID: 92255 RVA: 0x00695820 File Offset: 0x00693A20
	protected unsafe static void __CPPCALL_IsSelfCenteredModeEnabled_Implementation(CharacterBlueprintFunctionLibrary.__IsSelfCenteredModeEnabled_FunctionParams* __Params)
	{
		ESelfCenteredMode selfCenteredMode = (ESelfCenteredMode)__Params->selfCenteredMode;
		__Params->__Result = CharacterBlueprintFunctionLibrary.IsSelfCenteredModeEnabled(selfCenteredMode);
	}

	// Token: 0x06016860 RID: 92256 RVA: 0x00695840 File Offset: 0x00693A40
	protected unsafe static void __CPPCALL_GetEntityForeverTimeDilation_Implementation(CharacterBlueprintFunctionLibrary.__GetEntityForeverTimeDilation_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetEntityForeverTimeDilation(__Params->entityId);
	}

	// Token: 0x06016861 RID: 92257 RVA: 0x00695853 File Offset: 0x00693A53
	protected unsafe static void __CPPCALL_GetSelfCenteredMode_Implementation(CharacterBlueprintFunctionLibrary.__GetSelfCenteredMode_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)CharacterBlueprintFunctionLibrary.GetSelfCenteredMode();
	}

	// Token: 0x06016862 RID: 92258 RVA: 0x00695862 File Offset: 0x00693A62
	protected unsafe static void __CPPCALL_GetSelfCenteredTimeDilation_Implementation(CharacterBlueprintFunctionLibrary.__GetSelfCenteredTimeDilation_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetSelfCenteredTimeDilation();
	}

	// Token: 0x06016863 RID: 92259 RVA: 0x0069586F File Offset: 0x00693A6F
	protected unsafe static void __CPPCALL_GetInverseSelfCenteredTimeDilation_Implementation(CharacterBlueprintFunctionLibrary.__GetInverseSelfCenteredTimeDilation_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetInverseSelfCenteredTimeDilation();
	}

	// Token: 0x06016864 RID: 92260 RVA: 0x0069587C File Offset: 0x00693A7C
	protected unsafe static void __CPPCALL_SetPlanarReflectionShowPlayers_Implementation(CharacterBlueprintFunctionLibrary.__SetPlanarReflectionShowPlayers_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetPlanarReflectionShowPlayers(BuiltinUtils.GetOrCreateUObjectByNativePointer<UPlanarReflectionComponent>(__Params->comp));
	}

	// Token: 0x06016865 RID: 92261 RVA: 0x0069588E File Offset: 0x00693A8E
	protected unsafe static void __CPPCALL_SetCharacterDirectlySightLockEnableState_Implementation(CharacterBlueprintFunctionLibrary.__SetCharacterDirectlySightLockEnableState_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCharacterDirectlySightLockEnableState(__Params->id, __Params->bEnable);
	}

	// Token: 0x06016866 RID: 92262 RVA: 0x006958A1 File Offset: 0x00693AA1
	protected unsafe static void __CPPCALL_SetCharacterSightLockBoneLimit_Implementation(CharacterBlueprintFunctionLibrary.__SetCharacterSightLockBoneLimit_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCharacterSightLockBoneLimit(__Params->id, __Params->yawMin, __Params->yawMax, __Params->pitchMin, __Params->pitchMax, __Params->assistLimit, __Params->sightDirectInSightBone, __Params->upAxisInSightBone);
	}

	// Token: 0x06016867 RID: 92263 RVA: 0x006958D8 File Offset: 0x00693AD8
	protected unsafe static void __CPPCALL_RestoreSightLockBoneLimit_Implementation(CharacterBlueprintFunctionLibrary.__RestoreSightLockBoneLimit_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.RestoreSightLockBoneLimit(__Params->id);
	}

	// Token: 0x06016868 RID: 92264 RVA: 0x006958E5 File Offset: 0x00693AE5
	protected unsafe static void __CPPCALL_GetCharacterMovementModeInfo_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterMovementModeInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CharacterBlueprintFunctionLibrary.GetCharacterMovementModeInfo(__Params->id));
	}

	// Token: 0x06016869 RID: 92265 RVA: 0x006958FE File Offset: 0x00693AFE
	protected unsafe static void __CPPCALL_GetCharacterMovementStateInfo_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterMovementStateInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CharacterBlueprintFunctionLibrary.GetCharacterMovementStateInfo(__Params->id));
	}

	// Token: 0x0601686A RID: 92266 RVA: 0x00695917 File Offset: 0x00693B17
	protected unsafe static void __CPPCALL_GetVehicleMovementModeInfo_Implementation(CharacterBlueprintFunctionLibrary.__GetVehicleMovementModeInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CharacterBlueprintFunctionLibrary.GetVehicleMovementModeInfo(__Params->id));
	}

	// Token: 0x0601686B RID: 92267 RVA: 0x00695930 File Offset: 0x00693B30
	protected unsafe static void __CPPCALL_GetVehicleMovementStateInfo_Implementation(CharacterBlueprintFunctionLibrary.__GetVehicleMovementStateInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CharacterBlueprintFunctionLibrary.GetVehicleMovementStateInfo(__Params->id));
	}

	// Token: 0x0400BF04 RID: 48900
	[Nullable(1)]
	private const string SAVE_PATH = "Statistics/FightDataRecord/";

	// Token: 0x0400BF05 RID: 48901
	private static SEntityTimeDilation _entityTimeDilation;

	// Token: 0x0400BF06 RID: 48902
	[Nullable(2)]
	private static TimerHandle ResumeTimeHandle;

	// Token: 0x0400BF07 RID: 48903
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/CharacterBlueprintFunctionLibrary.CharacterBlueprintFunctionLibrary_C";

	// Token: 0x0400BF08 RID: 48904
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF09 RID: 48905
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200857F RID: 34175
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetPartCollisionSwitch_FunctionParams
	{
		// Token: 0x0402AFE2 RID: 176098
		[FieldOffset(0)]
		public IntPtr character;

		// Token: 0x0402AFE3 RID: 176099
		[FieldOffset(8)]
		public FString compName;

		// Token: 0x0402AFE4 RID: 176100
		[FieldOffset(24)]
		public bool isBlockPawn;

		// Token: 0x0402AFE5 RID: 176101
		[FieldOffset(25)]
		public bool isBulletDetect;

		// Token: 0x0402AFE6 RID: 176102
		[FieldOffset(26)]
		public bool isBlockCamera;

		// Token: 0x0402AFE7 RID: 176103
		[FieldOffset(27)]
		public bool isActiveOcclusionDither;

		// Token: 0x0402AFE8 RID: 176104
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008580 RID: 34176
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ResetPartCollisionSwitch_FunctionParams
	{
		// Token: 0x0402AFE9 RID: 176105
		[FieldOffset(0)]
		public IntPtr character;

		// Token: 0x0402AFEA RID: 176106
		[FieldOffset(8)]
		public FString compName;

		// Token: 0x0402AFEB RID: 176107
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008581 RID: 34177
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharacterActorByEntityId_FunctionParams
	{
		// Token: 0x0402AFEC RID: 176108
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AFED RID: 176109
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AFEE RID: 176110
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02008582 RID: 34178
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CharacterOperationRecord_FunctionParams
	{
		// Token: 0x0402AFEF RID: 176111
		[FieldOffset(0)]
		public bool open;

		// Token: 0x0402AFF0 RID: 176112
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008583 RID: 34179
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetStatisticsOpen_FunctionParams
	{
		// Token: 0x0402AFF1 RID: 176113
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402AFF2 RID: 176114
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008584 RID: 34180
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SaveCharacterOperationRecord_FunctionParams
	{
		// Token: 0x0402AFF3 RID: 176115
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402AFF4 RID: 176116
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008585 RID: 34181
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetOperationRecordCount_FunctionParams
	{
		// Token: 0x0402AFF5 RID: 176117
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402AFF6 RID: 176118
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x02008586 RID: 34182
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CleanupOperationRecord_FunctionParams
	{
		// Token: 0x0402AFF7 RID: 176119
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008587 RID: 34183
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetHalfLengthRecord_FunctionParams
	{
		// Token: 0x0402AFF8 RID: 176120
		[FieldOffset(0)]
		public float sideLenHalf;

		// Token: 0x0402AFF9 RID: 176121
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008588 RID: 34184
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetCombatStarted_FunctionParams
	{
		// Token: 0x0402AFFA RID: 176122
		[FieldOffset(0)]
		public bool started;

		// Token: 0x0402AFFB RID: 176123
		[FieldOffset(4)]
		public int attackerIndex;

		// Token: 0x0402AFFC RID: 176124
		[FieldOffset(8)]
		public int targetIndex;

		// Token: 0x0402AFFD RID: 176125
		[FieldOffset(12)]
		public bool isDamage;

		// Token: 0x0402AFFE RID: 176126
		[FieldOffset(13)]
		public bool isCure;

		// Token: 0x0402AFFF RID: 176127
		[FieldOffset(14)]
		public bool isSkillUsed;

		// Token: 0x0402B000 RID: 176128
		[FieldOffset(15)]
		public bool isState;

		// Token: 0x0402B001 RID: 176129
		[FieldOffset(16)]
		public bool isKill;

		// Token: 0x0402B002 RID: 176130
		[FieldOffset(17)]
		public bool isReborn;

		// Token: 0x0402B003 RID: 176131
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008589 RID: 34185
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetTypeOpen_FunctionParams
	{
		// Token: 0x0402B004 RID: 176132
		[FieldOffset(0)]
		public bool isDamage;

		// Token: 0x0402B005 RID: 176133
		[FieldOffset(1)]
		public bool isCure;

		// Token: 0x0402B006 RID: 176134
		[FieldOffset(2)]
		public bool isSkillUsed;

		// Token: 0x0402B007 RID: 176135
		[FieldOffset(3)]
		public bool isState;

		// Token: 0x0402B008 RID: 176136
		[FieldOffset(4)]
		public bool isKill;

		// Token: 0x0402B009 RID: 176137
		[FieldOffset(5)]
		public bool isReborn;

		// Token: 0x0402B00A RID: 176138
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200858A RID: 34186
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAttackerCombatEntities_FunctionParams
	{
		// Token: 0x0402B00B RID: 176139
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B00C RID: 176140
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200858B RID: 34187
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetTargetCombatEntities_FunctionParams
	{
		// Token: 0x0402B00D RID: 176141
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B00E RID: 176142
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200858C RID: 34188
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCurrentAttacker_FunctionParams
	{
		// Token: 0x0402B00F RID: 176143
		[FieldOffset(0)]
		public int index;

		// Token: 0x0402B010 RID: 176144
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200858D RID: 34189
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCurrentTarget_FunctionParams
	{
		// Token: 0x0402B011 RID: 176145
		[FieldOffset(0)]
		public int index;

		// Token: 0x0402B012 RID: 176146
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200858E RID: 34190
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetItemsReset_FunctionParams
	{
		// Token: 0x0402B013 RID: 176147
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B014 RID: 176148
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200858F RID: 34191
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __OnItemsResetFinished_FunctionParams
	{
		// Token: 0x0402B015 RID: 176149
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008590 RID: 34192
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSubItemsListView_FunctionParams
	{
		// Token: 0x0402B016 RID: 176150
		[FieldOffset(0)]
		public int startIndex;

		// Token: 0x0402B017 RID: 176151
		[FieldOffset(4)]
		public int length;

		// Token: 0x0402B018 RID: 176152
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B019 RID: 176153
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02008591 RID: 34193
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetItemListViewCount_FunctionParams
	{
		// Token: 0x0402B01A RID: 176154
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B01B RID: 176155
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x02008592 RID: 34194
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TestLeaveSplineMove_FunctionParams
	{
		// Token: 0x0402B01C RID: 176156
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402B01D RID: 176157
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008593 RID: 34195
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __GetBaseCharacterTransform_FunctionParams
	{
		// Token: 0x0402B01E RID: 176158
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B01F RID: 176159
		[FieldOffset(16)]
		public FTransformDouble __Result;
	}

	// Token: 0x02008594 RID: 34196
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetActorExtraSkeletalMeshComponent_FunctionParams
	{
		// Token: 0x0402B020 RID: 176160
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B021 RID: 176161
		[FieldOffset(8)]
		public IntPtr skeletalMeshComponent;

		// Token: 0x0402B022 RID: 176162
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008595 RID: 34197
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanCharacterMonsterOrSummonedDisplayEffect_FunctionParams
	{
		// Token: 0x0402B023 RID: 176163
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402B024 RID: 176164
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B025 RID: 176165
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008596 RID: 34198
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DetachFromHost_FunctionParams
	{
		// Token: 0x0402B026 RID: 176166
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B027 RID: 176167
		[FieldOffset(4)]
		public bool isDetachFollower;

		// Token: 0x0402B028 RID: 176168
		[FieldOffset(5)]
		public bool isRecursion;

		// Token: 0x0402B029 RID: 176169
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008597 RID: 34199
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterGravityDirect_FunctionParams
	{
		// Token: 0x0402B02A RID: 176170
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B02B RID: 176171
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x02008598 RID: 34200
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterGravityUp_FunctionParams
	{
		// Token: 0x0402B02C RID: 176172
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B02D RID: 176173
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x02008599 RID: 34201
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetGravityDirect_FunctionParams
	{
		// Token: 0x0402B02E RID: 176174
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B02F RID: 176175
		[FieldOffset(8)]
		public FVectorDouble gravityDirect;

		// Token: 0x0402B030 RID: 176176
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200859A RID: 34202
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnableSelfCentered_FunctionParams
	{
		// Token: 0x0402B031 RID: 176177
		[FieldOffset(0)]
		public byte selfCenteredMode;

		// Token: 0x0402B032 RID: 176178
		[FieldOffset(4)]
		public float timeDilation;

		// Token: 0x0402B033 RID: 176179
		[FieldOffset(8)]
		public float duration;

		// Token: 0x0402B034 RID: 176180
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200859B RID: 34203
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DisableSelfCentered_FunctionParams
	{
		// Token: 0x0402B035 RID: 176181
		[FieldOffset(0)]
		public byte selfCenteredMode;

		// Token: 0x0402B036 RID: 176182
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200859C RID: 34204
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsAnySelfCenteredModeEnabled_FunctionParams
	{
		// Token: 0x0402B037 RID: 176183
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B038 RID: 176184
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200859D RID: 34205
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsSelfCenteredModeEnabled_FunctionParams
	{
		// Token: 0x0402B039 RID: 176185
		[FieldOffset(0)]
		public byte selfCenteredMode;

		// Token: 0x0402B03A RID: 176186
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B03B RID: 176187
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200859E RID: 34206
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEntityForeverTimeDilation_FunctionParams
	{
		// Token: 0x0402B03C RID: 176188
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B03D RID: 176189
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B03E RID: 176190
		[FieldOffset(16)]
		public SEntityTimeDilation __Result;
	}

	// Token: 0x0200859F RID: 34207
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetSelfCenteredMode_FunctionParams
	{
		// Token: 0x0402B03F RID: 176191
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B040 RID: 176192
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x020085A0 RID: 34208
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetSelfCenteredTimeDilation_FunctionParams
	{
		// Token: 0x0402B041 RID: 176193
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B042 RID: 176194
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x020085A1 RID: 34209
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetInverseSelfCenteredTimeDilation_FunctionParams
	{
		// Token: 0x0402B043 RID: 176195
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B044 RID: 176196
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x020085A2 RID: 34210
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetPlanarReflectionShowPlayers_FunctionParams
	{
		// Token: 0x0402B045 RID: 176197
		[FieldOffset(0)]
		public IntPtr comp;

		// Token: 0x0402B046 RID: 176198
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085A3 RID: 34211
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCharacterDirectlySightLockEnableState_FunctionParams
	{
		// Token: 0x0402B047 RID: 176199
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B048 RID: 176200
		[FieldOffset(4)]
		public bool bEnable;

		// Token: 0x0402B049 RID: 176201
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085A4 RID: 34212
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetCharacterSightLockBoneLimit_FunctionParams
	{
		// Token: 0x0402B04A RID: 176202
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B04B RID: 176203
		[FieldOffset(4)]
		public float yawMin;

		// Token: 0x0402B04C RID: 176204
		[FieldOffset(8)]
		public float yawMax;

		// Token: 0x0402B04D RID: 176205
		[FieldOffset(12)]
		public float pitchMin;

		// Token: 0x0402B04E RID: 176206
		[FieldOffset(16)]
		public float pitchMax;

		// Token: 0x0402B04F RID: 176207
		[FieldOffset(20)]
		public float assistLimit;

		// Token: 0x0402B050 RID: 176208
		[FieldOffset(24)]
		public FVector sightDirectInSightBone;

		// Token: 0x0402B051 RID: 176209
		[FieldOffset(36)]
		public FVector upAxisInSightBone;

		// Token: 0x0402B052 RID: 176210
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085A5 RID: 34213
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RestoreSightLockBoneLimit_FunctionParams
	{
		// Token: 0x0402B053 RID: 176211
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B054 RID: 176212
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085A6 RID: 34214
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterMovementModeInfo_FunctionParams
	{
		// Token: 0x0402B055 RID: 176213
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B056 RID: 176214
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B057 RID: 176215
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020085A7 RID: 34215
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterMovementStateInfo_FunctionParams
	{
		// Token: 0x0402B058 RID: 176216
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B059 RID: 176217
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B05A RID: 176218
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020085A8 RID: 34216
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVehicleMovementModeInfo_FunctionParams
	{
		// Token: 0x0402B05B RID: 176219
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B05C RID: 176220
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B05D RID: 176221
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020085A9 RID: 34217
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVehicleMovementStateInfo_FunctionParams
	{
		// Token: 0x0402B05E RID: 176222
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B05F RID: 176223
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B060 RID: 176224
		[FieldOffset(16)]
		public FString __Result;
	}
}
