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

// Token: 0x02002E39 RID: 11833
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/CharacterBlueprintFunctionLibrary.CharacterBlueprintFunctionLibrary_C")]
public class CharacterBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06018F41 RID: 102209 RVA: 0x0066EABD File Offset: 0x0066CCBD
	static CharacterBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(CharacterBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x06018F42 RID: 102210 RVA: 0x0066EADC File Offset: 0x0066CCDC
	public static void CreateStaticDefaultValue()
	{
		CharacterBlueprintFunctionLibrary._entityTimeDilation = default(SEntityTimeDilation);
	}

	// Token: 0x06018F43 RID: 102211 RVA: 0x0066EAE9 File Offset: 0x0066CCE9
	public static void ResetStaticDefaultValue()
	{
		CharacterBlueprintFunctionLibrary._entityTimeDilation = default(SEntityTimeDilation);
		CharacterBlueprintFunctionLibrary.ResumeTimeHandle = null;
	}

	// Token: 0x06018F44 RID: 102212 RVA: 0x0066EAFC File Offset: 0x0066CCFC
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

	// Token: 0x06018F45 RID: 102213 RVA: 0x0066EB58 File Offset: 0x0066CD58
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

	// Token: 0x06018F46 RID: 102214 RVA: 0x0066EBA0 File Offset: 0x0066CDA0
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

	// Token: 0x06018F47 RID: 102215 RVA: 0x0066EBDD File Offset: 0x0066CDDD
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

	// Token: 0x06018F48 RID: 102216 RVA: 0x0066EBF4 File Offset: 0x0066CDF4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetStatisticsOpen()
	{
		return CharacterStatisticsComponent.OpenOperationRecord;
	}

	// Token: 0x06018F49 RID: 102217 RVA: 0x0066EBFC File Offset: 0x0066CDFC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool SaveCharacterOperationRecord()
	{
		CharacterGasDebugComponent.EndRecord();
		string text = CharacterStatisticsComponent.ExportRecord();
		return text != null && (UKuroStaticLibrary.SaveStringToFile(text, UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/OperationRecord.csv", true) && CharacterBlueprintFunctionLibrary.SaveCharacterStatisticsData());
	}

	// Token: 0x06018F4A RID: 102218 RVA: 0x0066EC3C File Offset: 0x0066CE3C
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

	// Token: 0x06018F4B RID: 102219 RVA: 0x0066ECA2 File Offset: 0x0066CEA2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetOperationRecordCount()
	{
		return (float)CharacterStatisticsComponent.OperationRecordCount();
	}

	// Token: 0x06018F4C RID: 102220 RVA: 0x0066ECAA File Offset: 0x0066CEAA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CleanupOperationRecord()
	{
		CharacterStatisticsComponent.CleanupOperationRecord();
		CharacterStatisticsComponent.CleanupRecordData();
		CharacterGasDebugComponent.CleanupRecord();
	}

	// Token: 0x06018F4D RID: 102221 RVA: 0x0066ECBB File Offset: 0x0066CEBB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetHalfLengthRecord(float sideLenHalf)
	{
		CharacterStatisticsComponent.HalfLengthRecordSquared = Math.Pow((double)sideLenHalf, 2.0);
	}

	// Token: 0x06018F4E RID: 102222 RVA: 0x0066ECD4 File Offset: 0x0066CED4
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

	// Token: 0x06018F4F RID: 102223 RVA: 0x0066ED34 File Offset: 0x0066CF34
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

	// Token: 0x06018F50 RID: 102224 RVA: 0x0066ED8B File Offset: 0x0066CF8B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetAttackerCombatEntities()
	{
		return CharacterStatisticsComponent.GetAttackerCombatEntities();
	}

	// Token: 0x06018F51 RID: 102225 RVA: 0x0066ED92 File Offset: 0x0066CF92
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetTargetCombatEntities()
	{
		return CharacterStatisticsComponent.GetTargetCombatEntities();
	}

	// Token: 0x06018F52 RID: 102226 RVA: 0x0066ED99 File Offset: 0x0066CF99
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCurrentAttacker(int index)
	{
		CharacterStatisticsComponent.SetCurrentAttacker(index);
	}

	// Token: 0x06018F53 RID: 102227 RVA: 0x0066EDA1 File Offset: 0x0066CFA1
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCurrentTarget(int index)
	{
		CharacterStatisticsComponent.SetCurrentTarget(index);
	}

	// Token: 0x06018F54 RID: 102228 RVA: 0x0066EDA9 File Offset: 0x0066CFA9
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetItemsReset()
	{
		return CharacterStatisticsComponent.ItemReset;
	}

	// Token: 0x06018F55 RID: 102229 RVA: 0x0066EDB0 File Offset: 0x0066CFB0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OnItemsResetFinished()
	{
		CharacterStatisticsComponent.OnItemsResetFinished();
	}

	// Token: 0x06018F56 RID: 102230 RVA: 0x0066EDB7 File Offset: 0x0066CFB7
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetSubItemsListView(int startIndex, int length)
	{
		return CharacterStatisticsComponent.GetSubItemsListView(startIndex, length);
	}

	// Token: 0x06018F57 RID: 102231 RVA: 0x0066EDC0 File Offset: 0x0066CFC0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetItemListViewCount()
	{
		return CharacterStatisticsComponent.GetItemListViewCount();
	}

	// Token: 0x06018F58 RID: 102232 RVA: 0x0066EDC7 File Offset: 0x0066CFC7
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TestLeaveSplineMove(TsBaseCharacter actor)
	{
		actor.GetEntityNoBlueprint().GetComponent<CharacterSplineMoveComponent>().EndSplineMove(1);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraSpline();
	}

	// Token: 0x06018F59 RID: 102233 RVA: 0x0066EDF4 File Offset: 0x0066CFF4
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

	// Token: 0x06018F5A RID: 102234 RVA: 0x0066EE28 File Offset: 0x0066D028
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

	// Token: 0x06018F5B RID: 102235 RVA: 0x0066EE64 File Offset: 0x0066D064
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

	// Token: 0x06018F5C RID: 102236 RVA: 0x0066EEA8 File Offset: 0x0066D0A8
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

	// Token: 0x06018F5D RID: 102237 RVA: 0x0066EEF2 File Offset: 0x0066D0F2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetCharacterGravityDirect()
	{
		GravityUtils instance = GravityUtils.Instance;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		return instance.GetGravityDirectForActor((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null).ToUeVector(false);
	}

	// Token: 0x06018F5E RID: 102238 RVA: 0x0066EF15 File Offset: 0x0066D115
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetCharacterGravityUp()
	{
		GravityUtils instance = GravityUtils.Instance;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		return instance.GetGravityUpForActor((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null).ToUeVector(false);
	}

	// Token: 0x06018F5F RID: 102239 RVA: 0x0066EF38 File Offset: 0x0066D138
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

	// Token: 0x06018F60 RID: 102240 RVA: 0x0066EF8C File Offset: 0x0066D18C
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

	// Token: 0x06018F61 RID: 102241 RVA: 0x0066F108 File Offset: 0x0066D308
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

	// Token: 0x06018F62 RID: 102242 RVA: 0x0066F14F File Offset: 0x0066D34F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsAnySelfCenteredModeEnabled()
	{
		CharacterModel instance = CharacterModel.Instance;
		return instance != null && instance.EnabledSelfCentered;
	}

	// Token: 0x06018F63 RID: 102243 RVA: 0x0066F161 File Offset: 0x0066D361
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsSelfCenteredModeEnabled(ESelfCenteredMode selfCenteredMode)
	{
		return CharacterController.Instance.IsSelfCenteredModeEnabled(selfCenteredMode);
	}

	// Token: 0x06018F64 RID: 102244 RVA: 0x0066F170 File Offset: 0x0066D370
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

	// Token: 0x06018F65 RID: 102245 RVA: 0x0066F1E3 File Offset: 0x0066D3E3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ESelfCenteredMode GetSelfCenteredMode()
	{
		return CharacterModel.Instance.SelfCenteredMode;
	}

	// Token: 0x06018F66 RID: 102246 RVA: 0x0066F1EF File Offset: 0x0066D3EF
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetSelfCenteredTimeDilation()
	{
		return CharacterModel.Instance.SelfCenteredTimeDilation;
	}

	// Token: 0x06018F67 RID: 102247 RVA: 0x0066F1FB File Offset: 0x0066D3FB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetInverseSelfCenteredTimeDilation()
	{
		return CharacterModel.Instance.InverseSelfCenteredTimeDilation;
	}

	// Token: 0x06018F68 RID: 102248 RVA: 0x0066F208 File Offset: 0x0066D408
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

	// Token: 0x06018F69 RID: 102249 RVA: 0x0066F298 File Offset: 0x0066D498
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

	// Token: 0x06018F6A RID: 102250 RVA: 0x0066F2D4 File Offset: 0x0066D4D4
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

	// Token: 0x06018F6B RID: 102251 RVA: 0x0066F314 File Offset: 0x0066D514
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

	// Token: 0x06018F6C RID: 102252 RVA: 0x0066F34C File Offset: 0x0066D54C
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

	// Token: 0x06018F6D RID: 102253 RVA: 0x0066F3E8 File Offset: 0x0066D5E8
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

	// Token: 0x06018F6E RID: 102254 RVA: 0x0066F4AC File Offset: 0x0066D6AC
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

	// Token: 0x06018F6F RID: 102255 RVA: 0x0066F528 File Offset: 0x0066D728
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

	// Token: 0x06018F70 RID: 102256 RVA: 0x0066F5FB File Offset: 0x0066D7FB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CharacterBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/CharacterBlueprintFunctionLibrary.CharacterBlueprintFunctionLibrary_C");
		}
		return CharacterBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06018F71 RID: 102257 RVA: 0x0066F620 File Offset: 0x0066D820
	public CharacterBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(CharacterBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018F72 RID: 102258 RVA: 0x0066F648 File Offset: 0x0066D848
	[NullableContext(1)]
	public CharacterBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharacterBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018F73 RID: 102259 RVA: 0x0066F67B File Offset: 0x0066D87B
	protected CharacterBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06018F74 RID: 102260 RVA: 0x0066F684 File Offset: 0x0066D884
	protected unsafe static void __CPPCALL_SetPartCollisionSwitch_Implementation(CharacterBlueprintFunctionLibrary.__SetPartCollisionSwitch_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->character);
		string compName = FString.ToString((void*)(&__Params->compName));
		CharacterBlueprintFunctionLibrary.SetPartCollisionSwitch(orCreateUObjectByNativePointer, compName, __Params->isBlockPawn, __Params->isBulletDetect, __Params->isBlockCamera, __Params->isActiveOcclusionDither);
	}

	// Token: 0x06018F75 RID: 102261 RVA: 0x0066F6C8 File Offset: 0x0066D8C8
	protected unsafe static void __CPPCALL_ResetPartCollisionSwitch_Implementation(CharacterBlueprintFunctionLibrary.__ResetPartCollisionSwitch_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->character);
		string compName = FString.ToString((void*)(&__Params->compName));
		CharacterBlueprintFunctionLibrary.ResetPartCollisionSwitch(orCreateUObjectByNativePointer, compName);
	}

	// Token: 0x06018F76 RID: 102262 RVA: 0x0066F6F3 File Offset: 0x0066D8F3
	protected unsafe static void __CPPCALL_GetCharacterActorByEntityId_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterActorByEntityId_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter characterActorByEntityId = CharacterBlueprintFunctionLibrary.GetCharacterActorByEntityId(__Params->id);
		ptr = ((characterActorByEntityId != null) ? characterActorByEntityId.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06018F77 RID: 102263 RVA: 0x0066F715 File Offset: 0x0066D915
	protected unsafe static void __CPPCALL_CharacterOperationRecord_Implementation(CharacterBlueprintFunctionLibrary.__CharacterOperationRecord_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.CharacterOperationRecord(__Params->open);
	}

	// Token: 0x06018F78 RID: 102264 RVA: 0x0066F722 File Offset: 0x0066D922
	protected unsafe static void __CPPCALL_GetStatisticsOpen_Implementation(CharacterBlueprintFunctionLibrary.__GetStatisticsOpen_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetStatisticsOpen();
	}

	// Token: 0x06018F79 RID: 102265 RVA: 0x0066F72F File Offset: 0x0066D92F
	protected unsafe static void __CPPCALL_SaveCharacterOperationRecord_Implementation(CharacterBlueprintFunctionLibrary.__SaveCharacterOperationRecord_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.SaveCharacterOperationRecord();
	}

	// Token: 0x06018F7A RID: 102266 RVA: 0x0066F73C File Offset: 0x0066D93C
	protected unsafe static void __CPPCALL_GetOperationRecordCount_Implementation(CharacterBlueprintFunctionLibrary.__GetOperationRecordCount_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetOperationRecordCount();
	}

	// Token: 0x06018F7B RID: 102267 RVA: 0x0066F749 File Offset: 0x0066D949
	protected unsafe static void __CPPCALL_CleanupOperationRecord_Implementation(CharacterBlueprintFunctionLibrary.__CleanupOperationRecord_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.CleanupOperationRecord();
	}

	// Token: 0x06018F7C RID: 102268 RVA: 0x0066F750 File Offset: 0x0066D950
	protected unsafe static void __CPPCALL_SetHalfLengthRecord_Implementation(CharacterBlueprintFunctionLibrary.__SetHalfLengthRecord_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetHalfLengthRecord(__Params->sideLenHalf);
	}

	// Token: 0x06018F7D RID: 102269 RVA: 0x0066F760 File Offset: 0x0066D960
	protected unsafe static void __CPPCALL_SetCombatStarted_Implementation(CharacterBlueprintFunctionLibrary.__SetCombatStarted_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCombatStarted(__Params->started, __Params->attackerIndex, __Params->targetIndex, __Params->isDamage, __Params->isCure, __Params->isSkillUsed, __Params->isState, __Params->isKill, __Params->isReborn);
	}

	// Token: 0x06018F7E RID: 102270 RVA: 0x0066F7A8 File Offset: 0x0066D9A8
	protected unsafe static void __CPPCALL_SetTypeOpen_Implementation(CharacterBlueprintFunctionLibrary.__SetTypeOpen_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetTypeOpen(__Params->isDamage, __Params->isCure, __Params->isSkillUsed, __Params->isState, __Params->isKill, __Params->isReborn);
	}

	// Token: 0x06018F7F RID: 102271 RVA: 0x0066F7D4 File Offset: 0x0066D9D4
	protected unsafe static void __CPPCALL_GetAttackerCombatEntities_Implementation(CharacterBlueprintFunctionLibrary.__GetAttackerCombatEntities_FunctionParams* __Params)
	{
		TArray<string> attackerCombatEntities = CharacterBlueprintFunctionLibrary.GetAttackerCombatEntities();
		if (attackerCombatEntities == null)
		{
			return;
		}
		attackerCombatEntities.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06018F80 RID: 102272 RVA: 0x0066F800 File Offset: 0x0066DA00
	protected unsafe static void __CPPCALL_GetTargetCombatEntities_Implementation(CharacterBlueprintFunctionLibrary.__GetTargetCombatEntities_FunctionParams* __Params)
	{
		TArray<string> targetCombatEntities = CharacterBlueprintFunctionLibrary.GetTargetCombatEntities();
		if (targetCombatEntities == null)
		{
			return;
		}
		targetCombatEntities.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06018F81 RID: 102273 RVA: 0x0066F82C File Offset: 0x0066DA2C
	protected unsafe static void __CPPCALL_SetCurrentAttacker_Implementation(CharacterBlueprintFunctionLibrary.__SetCurrentAttacker_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCurrentAttacker(__Params->index);
	}

	// Token: 0x06018F82 RID: 102274 RVA: 0x0066F839 File Offset: 0x0066DA39
	protected unsafe static void __CPPCALL_SetCurrentTarget_Implementation(CharacterBlueprintFunctionLibrary.__SetCurrentTarget_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCurrentTarget(__Params->index);
	}

	// Token: 0x06018F83 RID: 102275 RVA: 0x0066F846 File Offset: 0x0066DA46
	protected unsafe static void __CPPCALL_GetItemsReset_Implementation(CharacterBlueprintFunctionLibrary.__GetItemsReset_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetItemsReset();
	}

	// Token: 0x06018F84 RID: 102276 RVA: 0x0066F853 File Offset: 0x0066DA53
	protected unsafe static void __CPPCALL_OnItemsResetFinished_Implementation(CharacterBlueprintFunctionLibrary.__OnItemsResetFinished_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.OnItemsResetFinished();
	}

	// Token: 0x06018F85 RID: 102277 RVA: 0x0066F85C File Offset: 0x0066DA5C
	protected unsafe static void __CPPCALL_GetSubItemsListView_Implementation(CharacterBlueprintFunctionLibrary.__GetSubItemsListView_FunctionParams* __Params)
	{
		TArray<string> subItemsListView = CharacterBlueprintFunctionLibrary.GetSubItemsListView(__Params->startIndex, __Params->length);
		if (subItemsListView == null)
		{
			return;
		}
		subItemsListView.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06018F86 RID: 102278 RVA: 0x0066F894 File Offset: 0x0066DA94
	protected unsafe static void __CPPCALL_GetItemListViewCount_Implementation(CharacterBlueprintFunctionLibrary.__GetItemListViewCount_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetItemListViewCount();
	}

	// Token: 0x06018F87 RID: 102279 RVA: 0x0066F8A1 File Offset: 0x0066DAA1
	protected unsafe static void __CPPCALL_TestLeaveSplineMove_Implementation(CharacterBlueprintFunctionLibrary.__TestLeaveSplineMove_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.TestLeaveSplineMove(BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->actor));
	}

	// Token: 0x06018F88 RID: 102280 RVA: 0x0066F8B3 File Offset: 0x0066DAB3
	protected unsafe static void __CPPCALL_GetBaseCharacterTransform_Implementation(CharacterBlueprintFunctionLibrary.__GetBaseCharacterTransform_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetBaseCharacterTransform();
	}

	// Token: 0x06018F89 RID: 102281 RVA: 0x0066F8C0 File Offset: 0x0066DAC0
	protected unsafe static void __CPPCALL_SetActorExtraSkeletalMeshComponent_Implementation(CharacterBlueprintFunctionLibrary.__SetActorExtraSkeletalMeshComponent_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->skeletalMeshComponent);
		CharacterBlueprintFunctionLibrary.SetActorExtraSkeletalMeshComponent(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06018F8A RID: 102282 RVA: 0x0066F8E8 File Offset: 0x0066DAE8
	protected unsafe static void __CPPCALL_CanCharacterMonsterOrSummonedDisplayEffect_Implementation(CharacterBlueprintFunctionLibrary.__CanCharacterMonsterOrSummonedDisplayEffect_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		__Params->__Result = CharacterBlueprintFunctionLibrary.CanCharacterMonsterOrSummonedDisplayEffect(orCreateUObjectByNativePointer);
	}

	// Token: 0x06018F8B RID: 102283 RVA: 0x0066F90D File Offset: 0x0066DB0D
	protected unsafe static void __CPPCALL_DetachFromHost_Implementation(CharacterBlueprintFunctionLibrary.__DetachFromHost_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.DetachFromHost(__Params->id, __Params->isDetachFollower, __Params->isRecursion);
	}

	// Token: 0x06018F8C RID: 102284 RVA: 0x0066F926 File Offset: 0x0066DB26
	protected unsafe static void __CPPCALL_GetCharacterGravityDirect_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterGravityDirect_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetCharacterGravityDirect();
	}

	// Token: 0x06018F8D RID: 102285 RVA: 0x0066F933 File Offset: 0x0066DB33
	protected unsafe static void __CPPCALL_GetCharacterGravityUp_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterGravityUp_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetCharacterGravityUp();
	}

	// Token: 0x06018F8E RID: 102286 RVA: 0x0066F940 File Offset: 0x0066DB40
	protected unsafe static void __CPPCALL_SetGravityDirect_Implementation(CharacterBlueprintFunctionLibrary.__SetGravityDirect_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetGravityDirect(__Params->entityId, __Params->gravityDirect);
	}

	// Token: 0x06018F8F RID: 102287 RVA: 0x0066F953 File Offset: 0x0066DB53
	protected unsafe static void __CPPCALL_EnableSelfCentered_Implementation(CharacterBlueprintFunctionLibrary.__EnableSelfCentered_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.EnableSelfCentered((ESelfCenteredMode)__Params->selfCenteredMode, __Params->timeDilation, __Params->duration);
	}

	// Token: 0x06018F90 RID: 102288 RVA: 0x0066F96C File Offset: 0x0066DB6C
	protected unsafe static void __CPPCALL_DisableSelfCentered_Implementation(CharacterBlueprintFunctionLibrary.__DisableSelfCentered_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.DisableSelfCentered((ESelfCenteredMode)__Params->selfCenteredMode);
	}

	// Token: 0x06018F91 RID: 102289 RVA: 0x0066F979 File Offset: 0x0066DB79
	protected unsafe static void __CPPCALL_IsAnySelfCenteredModeEnabled_Implementation(CharacterBlueprintFunctionLibrary.__IsAnySelfCenteredModeEnabled_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.IsAnySelfCenteredModeEnabled();
	}

	// Token: 0x06018F92 RID: 102290 RVA: 0x0066F988 File Offset: 0x0066DB88
	protected unsafe static void __CPPCALL_IsSelfCenteredModeEnabled_Implementation(CharacterBlueprintFunctionLibrary.__IsSelfCenteredModeEnabled_FunctionParams* __Params)
	{
		ESelfCenteredMode selfCenteredMode = (ESelfCenteredMode)__Params->selfCenteredMode;
		__Params->__Result = CharacterBlueprintFunctionLibrary.IsSelfCenteredModeEnabled(selfCenteredMode);
	}

	// Token: 0x06018F93 RID: 102291 RVA: 0x0066F9A8 File Offset: 0x0066DBA8
	protected unsafe static void __CPPCALL_GetEntityForeverTimeDilation_Implementation(CharacterBlueprintFunctionLibrary.__GetEntityForeverTimeDilation_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetEntityForeverTimeDilation(__Params->entityId);
	}

	// Token: 0x06018F94 RID: 102292 RVA: 0x0066F9BB File Offset: 0x0066DBBB
	protected unsafe static void __CPPCALL_GetSelfCenteredMode_Implementation(CharacterBlueprintFunctionLibrary.__GetSelfCenteredMode_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)CharacterBlueprintFunctionLibrary.GetSelfCenteredMode();
	}

	// Token: 0x06018F95 RID: 102293 RVA: 0x0066F9CA File Offset: 0x0066DBCA
	protected unsafe static void __CPPCALL_GetSelfCenteredTimeDilation_Implementation(CharacterBlueprintFunctionLibrary.__GetSelfCenteredTimeDilation_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetSelfCenteredTimeDilation();
	}

	// Token: 0x06018F96 RID: 102294 RVA: 0x0066F9D7 File Offset: 0x0066DBD7
	protected unsafe static void __CPPCALL_GetInverseSelfCenteredTimeDilation_Implementation(CharacterBlueprintFunctionLibrary.__GetInverseSelfCenteredTimeDilation_FunctionParams* __Params)
	{
		__Params->__Result = CharacterBlueprintFunctionLibrary.GetInverseSelfCenteredTimeDilation();
	}

	// Token: 0x06018F97 RID: 102295 RVA: 0x0066F9E4 File Offset: 0x0066DBE4
	protected unsafe static void __CPPCALL_SetPlanarReflectionShowPlayers_Implementation(CharacterBlueprintFunctionLibrary.__SetPlanarReflectionShowPlayers_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetPlanarReflectionShowPlayers(BuiltinUtils.GetOrCreateUObjectByNativePointer<UPlanarReflectionComponent>(__Params->comp));
	}

	// Token: 0x06018F98 RID: 102296 RVA: 0x0066F9F6 File Offset: 0x0066DBF6
	protected unsafe static void __CPPCALL_SetCharacterDirectlySightLockEnableState_Implementation(CharacterBlueprintFunctionLibrary.__SetCharacterDirectlySightLockEnableState_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCharacterDirectlySightLockEnableState(__Params->id, __Params->bEnable);
	}

	// Token: 0x06018F99 RID: 102297 RVA: 0x0066FA09 File Offset: 0x0066DC09
	protected unsafe static void __CPPCALL_SetCharacterSightLockBoneLimit_Implementation(CharacterBlueprintFunctionLibrary.__SetCharacterSightLockBoneLimit_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.SetCharacterSightLockBoneLimit(__Params->id, __Params->yawMin, __Params->yawMax, __Params->pitchMin, __Params->pitchMax, __Params->assistLimit, __Params->sightDirectInSightBone, __Params->upAxisInSightBone);
	}

	// Token: 0x06018F9A RID: 102298 RVA: 0x0066FA40 File Offset: 0x0066DC40
	protected unsafe static void __CPPCALL_RestoreSightLockBoneLimit_Implementation(CharacterBlueprintFunctionLibrary.__RestoreSightLockBoneLimit_FunctionParams* __Params)
	{
		CharacterBlueprintFunctionLibrary.RestoreSightLockBoneLimit(__Params->id);
	}

	// Token: 0x06018F9B RID: 102299 RVA: 0x0066FA4D File Offset: 0x0066DC4D
	protected unsafe static void __CPPCALL_GetCharacterMovementModeInfo_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterMovementModeInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CharacterBlueprintFunctionLibrary.GetCharacterMovementModeInfo(__Params->id));
	}

	// Token: 0x06018F9C RID: 102300 RVA: 0x0066FA66 File Offset: 0x0066DC66
	protected unsafe static void __CPPCALL_GetCharacterMovementStateInfo_Implementation(CharacterBlueprintFunctionLibrary.__GetCharacterMovementStateInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CharacterBlueprintFunctionLibrary.GetCharacterMovementStateInfo(__Params->id));
	}

	// Token: 0x06018F9D RID: 102301 RVA: 0x0066FA7F File Offset: 0x0066DC7F
	protected unsafe static void __CPPCALL_GetVehicleMovementModeInfo_Implementation(CharacterBlueprintFunctionLibrary.__GetVehicleMovementModeInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CharacterBlueprintFunctionLibrary.GetVehicleMovementModeInfo(__Params->id));
	}

	// Token: 0x06018F9E RID: 102302 RVA: 0x0066FA98 File Offset: 0x0066DC98
	protected unsafe static void __CPPCALL_GetVehicleMovementStateInfo_Implementation(CharacterBlueprintFunctionLibrary.__GetVehicleMovementStateInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), CharacterBlueprintFunctionLibrary.GetVehicleMovementStateInfo(__Params->id));
	}

	// Token: 0x0400BB76 RID: 47990
	[Nullable(1)]
	private const string SAVE_PATH = "Statistics/FightDataRecord/";

	// Token: 0x0400BB77 RID: 47991
	private static SEntityTimeDilation _entityTimeDilation;

	// Token: 0x0400BB78 RID: 47992
	[Nullable(2)]
	private static TimerHandle ResumeTimeHandle;

	// Token: 0x0400BB79 RID: 47993
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/CharacterBlueprintFunctionLibrary.CharacterBlueprintFunctionLibrary_C";

	// Token: 0x0400BB7A RID: 47994
	private static IntPtr _ClassPtr;

	// Token: 0x0400BB7B RID: 47995
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009359 RID: 37721
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetPartCollisionSwitch_FunctionParams
	{
		// Token: 0x0402F95C RID: 194908
		[FieldOffset(0)]
		public IntPtr character;

		// Token: 0x0402F95D RID: 194909
		[FieldOffset(8)]
		public FString compName;

		// Token: 0x0402F95E RID: 194910
		[FieldOffset(24)]
		public bool isBlockPawn;

		// Token: 0x0402F95F RID: 194911
		[FieldOffset(25)]
		public bool isBulletDetect;

		// Token: 0x0402F960 RID: 194912
		[FieldOffset(26)]
		public bool isBlockCamera;

		// Token: 0x0402F961 RID: 194913
		[FieldOffset(27)]
		public bool isActiveOcclusionDither;

		// Token: 0x0402F962 RID: 194914
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200935A RID: 37722
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ResetPartCollisionSwitch_FunctionParams
	{
		// Token: 0x0402F963 RID: 194915
		[FieldOffset(0)]
		public IntPtr character;

		// Token: 0x0402F964 RID: 194916
		[FieldOffset(8)]
		public FString compName;

		// Token: 0x0402F965 RID: 194917
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200935B RID: 37723
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharacterActorByEntityId_FunctionParams
	{
		// Token: 0x0402F966 RID: 194918
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F967 RID: 194919
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F968 RID: 194920
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200935C RID: 37724
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CharacterOperationRecord_FunctionParams
	{
		// Token: 0x0402F969 RID: 194921
		[FieldOffset(0)]
		public bool open;

		// Token: 0x0402F96A RID: 194922
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200935D RID: 37725
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetStatisticsOpen_FunctionParams
	{
		// Token: 0x0402F96B RID: 194923
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F96C RID: 194924
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200935E RID: 37726
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SaveCharacterOperationRecord_FunctionParams
	{
		// Token: 0x0402F96D RID: 194925
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F96E RID: 194926
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200935F RID: 37727
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetOperationRecordCount_FunctionParams
	{
		// Token: 0x0402F96F RID: 194927
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F970 RID: 194928
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x02009360 RID: 37728
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CleanupOperationRecord_FunctionParams
	{
		// Token: 0x0402F971 RID: 194929
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009361 RID: 37729
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetHalfLengthRecord_FunctionParams
	{
		// Token: 0x0402F972 RID: 194930
		[FieldOffset(0)]
		public float sideLenHalf;

		// Token: 0x0402F973 RID: 194931
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009362 RID: 37730
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetCombatStarted_FunctionParams
	{
		// Token: 0x0402F974 RID: 194932
		[FieldOffset(0)]
		public bool started;

		// Token: 0x0402F975 RID: 194933
		[FieldOffset(4)]
		public int attackerIndex;

		// Token: 0x0402F976 RID: 194934
		[FieldOffset(8)]
		public int targetIndex;

		// Token: 0x0402F977 RID: 194935
		[FieldOffset(12)]
		public bool isDamage;

		// Token: 0x0402F978 RID: 194936
		[FieldOffset(13)]
		public bool isCure;

		// Token: 0x0402F979 RID: 194937
		[FieldOffset(14)]
		public bool isSkillUsed;

		// Token: 0x0402F97A RID: 194938
		[FieldOffset(15)]
		public bool isState;

		// Token: 0x0402F97B RID: 194939
		[FieldOffset(16)]
		public bool isKill;

		// Token: 0x0402F97C RID: 194940
		[FieldOffset(17)]
		public bool isReborn;

		// Token: 0x0402F97D RID: 194941
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009363 RID: 37731
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetTypeOpen_FunctionParams
	{
		// Token: 0x0402F97E RID: 194942
		[FieldOffset(0)]
		public bool isDamage;

		// Token: 0x0402F97F RID: 194943
		[FieldOffset(1)]
		public bool isCure;

		// Token: 0x0402F980 RID: 194944
		[FieldOffset(2)]
		public bool isSkillUsed;

		// Token: 0x0402F981 RID: 194945
		[FieldOffset(3)]
		public bool isState;

		// Token: 0x0402F982 RID: 194946
		[FieldOffset(4)]
		public bool isKill;

		// Token: 0x0402F983 RID: 194947
		[FieldOffset(5)]
		public bool isReborn;

		// Token: 0x0402F984 RID: 194948
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009364 RID: 37732
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAttackerCombatEntities_FunctionParams
	{
		// Token: 0x0402F985 RID: 194949
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F986 RID: 194950
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02009365 RID: 37733
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetTargetCombatEntities_FunctionParams
	{
		// Token: 0x0402F987 RID: 194951
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F988 RID: 194952
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02009366 RID: 37734
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCurrentAttacker_FunctionParams
	{
		// Token: 0x0402F989 RID: 194953
		[FieldOffset(0)]
		public int index;

		// Token: 0x0402F98A RID: 194954
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009367 RID: 37735
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCurrentTarget_FunctionParams
	{
		// Token: 0x0402F98B RID: 194955
		[FieldOffset(0)]
		public int index;

		// Token: 0x0402F98C RID: 194956
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009368 RID: 37736
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetItemsReset_FunctionParams
	{
		// Token: 0x0402F98D RID: 194957
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F98E RID: 194958
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02009369 RID: 37737
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __OnItemsResetFinished_FunctionParams
	{
		// Token: 0x0402F98F RID: 194959
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200936A RID: 37738
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSubItemsListView_FunctionParams
	{
		// Token: 0x0402F990 RID: 194960
		[FieldOffset(0)]
		public int startIndex;

		// Token: 0x0402F991 RID: 194961
		[FieldOffset(4)]
		public int length;

		// Token: 0x0402F992 RID: 194962
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F993 RID: 194963
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200936B RID: 37739
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetItemListViewCount_FunctionParams
	{
		// Token: 0x0402F994 RID: 194964
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F995 RID: 194965
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x0200936C RID: 37740
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TestLeaveSplineMove_FunctionParams
	{
		// Token: 0x0402F996 RID: 194966
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402F997 RID: 194967
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200936D RID: 37741
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __GetBaseCharacterTransform_FunctionParams
	{
		// Token: 0x0402F998 RID: 194968
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F999 RID: 194969
		[FieldOffset(16)]
		public FTransformDouble __Result;
	}

	// Token: 0x0200936E RID: 37742
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetActorExtraSkeletalMeshComponent_FunctionParams
	{
		// Token: 0x0402F99A RID: 194970
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402F99B RID: 194971
		[FieldOffset(8)]
		public IntPtr skeletalMeshComponent;

		// Token: 0x0402F99C RID: 194972
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200936F RID: 37743
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanCharacterMonsterOrSummonedDisplayEffect_FunctionParams
	{
		// Token: 0x0402F99D RID: 194973
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402F99E RID: 194974
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F99F RID: 194975
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009370 RID: 37744
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DetachFromHost_FunctionParams
	{
		// Token: 0x0402F9A0 RID: 194976
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F9A1 RID: 194977
		[FieldOffset(4)]
		public bool isDetachFollower;

		// Token: 0x0402F9A2 RID: 194978
		[FieldOffset(5)]
		public bool isRecursion;

		// Token: 0x0402F9A3 RID: 194979
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009371 RID: 37745
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterGravityDirect_FunctionParams
	{
		// Token: 0x0402F9A4 RID: 194980
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9A5 RID: 194981
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009372 RID: 37746
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterGravityUp_FunctionParams
	{
		// Token: 0x0402F9A6 RID: 194982
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9A7 RID: 194983
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009373 RID: 37747
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetGravityDirect_FunctionParams
	{
		// Token: 0x0402F9A8 RID: 194984
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402F9A9 RID: 194985
		[FieldOffset(8)]
		public FVectorDouble gravityDirect;

		// Token: 0x0402F9AA RID: 194986
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009374 RID: 37748
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnableSelfCentered_FunctionParams
	{
		// Token: 0x0402F9AB RID: 194987
		[FieldOffset(0)]
		public byte selfCenteredMode;

		// Token: 0x0402F9AC RID: 194988
		[FieldOffset(4)]
		public float timeDilation;

		// Token: 0x0402F9AD RID: 194989
		[FieldOffset(8)]
		public float duration;

		// Token: 0x0402F9AE RID: 194990
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009375 RID: 37749
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DisableSelfCentered_FunctionParams
	{
		// Token: 0x0402F9AF RID: 194991
		[FieldOffset(0)]
		public byte selfCenteredMode;

		// Token: 0x0402F9B0 RID: 194992
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009376 RID: 37750
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsAnySelfCenteredModeEnabled_FunctionParams
	{
		// Token: 0x0402F9B1 RID: 194993
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9B2 RID: 194994
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02009377 RID: 37751
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsSelfCenteredModeEnabled_FunctionParams
	{
		// Token: 0x0402F9B3 RID: 194995
		[FieldOffset(0)]
		public byte selfCenteredMode;

		// Token: 0x0402F9B4 RID: 194996
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9B5 RID: 194997
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009378 RID: 37752
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEntityForeverTimeDilation_FunctionParams
	{
		// Token: 0x0402F9B6 RID: 194998
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402F9B7 RID: 194999
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9B8 RID: 195000
		[FieldOffset(16)]
		public SEntityTimeDilation __Result;
	}

	// Token: 0x02009379 RID: 37753
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetSelfCenteredMode_FunctionParams
	{
		// Token: 0x0402F9B9 RID: 195001
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9BA RID: 195002
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200937A RID: 37754
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetSelfCenteredTimeDilation_FunctionParams
	{
		// Token: 0x0402F9BB RID: 195003
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9BC RID: 195004
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x0200937B RID: 37755
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetInverseSelfCenteredTimeDilation_FunctionParams
	{
		// Token: 0x0402F9BD RID: 195005
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9BE RID: 195006
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x0200937C RID: 37756
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetPlanarReflectionShowPlayers_FunctionParams
	{
		// Token: 0x0402F9BF RID: 195007
		[FieldOffset(0)]
		public IntPtr comp;

		// Token: 0x0402F9C0 RID: 195008
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200937D RID: 37757
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCharacterDirectlySightLockEnableState_FunctionParams
	{
		// Token: 0x0402F9C1 RID: 195009
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F9C2 RID: 195010
		[FieldOffset(4)]
		public bool bEnable;

		// Token: 0x0402F9C3 RID: 195011
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200937E RID: 37758
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetCharacterSightLockBoneLimit_FunctionParams
	{
		// Token: 0x0402F9C4 RID: 195012
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F9C5 RID: 195013
		[FieldOffset(4)]
		public float yawMin;

		// Token: 0x0402F9C6 RID: 195014
		[FieldOffset(8)]
		public float yawMax;

		// Token: 0x0402F9C7 RID: 195015
		[FieldOffset(12)]
		public float pitchMin;

		// Token: 0x0402F9C8 RID: 195016
		[FieldOffset(16)]
		public float pitchMax;

		// Token: 0x0402F9C9 RID: 195017
		[FieldOffset(20)]
		public float assistLimit;

		// Token: 0x0402F9CA RID: 195018
		[FieldOffset(24)]
		public FVector sightDirectInSightBone;

		// Token: 0x0402F9CB RID: 195019
		[FieldOffset(36)]
		public FVector upAxisInSightBone;

		// Token: 0x0402F9CC RID: 195020
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200937F RID: 37759
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RestoreSightLockBoneLimit_FunctionParams
	{
		// Token: 0x0402F9CD RID: 195021
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F9CE RID: 195022
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009380 RID: 37760
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterMovementModeInfo_FunctionParams
	{
		// Token: 0x0402F9CF RID: 195023
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F9D0 RID: 195024
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9D1 RID: 195025
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02009381 RID: 37761
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterMovementStateInfo_FunctionParams
	{
		// Token: 0x0402F9D2 RID: 195026
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F9D3 RID: 195027
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9D4 RID: 195028
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02009382 RID: 37762
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVehicleMovementModeInfo_FunctionParams
	{
		// Token: 0x0402F9D5 RID: 195029
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F9D6 RID: 195030
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9D7 RID: 195031
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02009383 RID: 37763
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVehicleMovementStateInfo_FunctionParams
	{
		// Token: 0x0402F9D8 RID: 195032
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F9D9 RID: 195033
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F9DA RID: 195034
		[FieldOffset(16)]
		public FString __Result;
	}
}
