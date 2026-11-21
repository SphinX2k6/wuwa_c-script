using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.CreatureTools;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

// Token: 0x02000399 RID: 921
[NullableContext(1)]
[Nullable(0)]
public class LevelGeneralCommons : IStaticVariableResetter
{
	// Token: 0x060032EB RID: 13035 RVA: 0x001251B1 File Offset: 0x001233B1
	static LevelGeneralCommons()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelGeneralCommons.CreateStaticDefaultValue), new Action(LevelGeneralCommons.ResetStaticDefaultValue));
	}

	// Token: 0x060032EC RID: 13036 RVA: 0x001251D0 File Offset: 0x001233D0
	public static void Init()
	{
		LevelGeneralCommons.TempTags = new List<string>();
		LevelGeneralCommons.TempFindEntities = new List<EntityHandle>();
	}

	// Token: 0x060032ED RID: 13037 RVA: 0x001251E6 File Offset: 0x001233E6
	public static void Clear()
	{
		if (LevelGeneralCommons.TempTags != null)
		{
			LevelGeneralCommons.TempTags.Clear();
		}
		if (LevelGeneralCommons.TempFindEntities != null)
		{
			LevelGeneralCommons.TempFindEntities.Clear();
		}
	}

	// Token: 0x060032EE RID: 13038 RVA: 0x0012520C File Offset: 0x0012340C
	public static void AddPublicTag(string inTag, AActor inTarget)
	{
		if (LevelGeneralCommons.TempTags == null)
		{
			return;
		}
		IBPI_CreatureInterface_C ibpi_CreatureInterface_C = inTarget as IBPI_CreatureInterface_C;
		if (ibpi_CreatureInterface_C == null)
		{
			return;
		}
		LevelGeneralCommons.TempTags.Clear();
		LevelGeneralCommons.TempTags.Add(inTag);
		CreatureController.Instance.AddPublicTags(ibpi_CreatureInterface_C.GetEntityId(), LevelGeneralCommons.TempTags);
	}

	// Token: 0x060032EF RID: 13039 RVA: 0x00125258 File Offset: 0x00123458
	public static void RemovePublicTag(string inTag, AActor inTarget)
	{
		if (LevelGeneralCommons.TempTags == null)
		{
			return;
		}
		IBPI_CreatureInterface_C ibpi_CreatureInterface_C = inTarget as IBPI_CreatureInterface_C;
		if (ibpi_CreatureInterface_C == null)
		{
			return;
		}
		LevelGeneralCommons.TempTags.Clear();
		LevelGeneralCommons.TempTags.Add(inTag);
		CreatureController.Instance.RemovePublicTags(ibpi_CreatureInterface_C.GetEntityId(), LevelGeneralCommons.TempTags);
	}

	// Token: 0x060032F0 RID: 13040 RVA: 0x001252A2 File Offset: 0x001234A2
	[return: Nullable(2)]
	public static AActor FindTargetWithTag(string inTag)
	{
		if (LevelGeneralCommons.TempFindEntities == null)
		{
			return null;
		}
		CreatureModel.Instance.GetEntitiesWithTag(inTag, ref LevelGeneralCommons.TempFindEntities);
		if (LevelGeneralCommons.TempFindEntities.Count == 0)
		{
			return null;
		}
		return CharacterController.Instance.GetActor(LevelGeneralCommons.TempFindEntities[0]);
	}

	// Token: 0x060032F1 RID: 13041 RVA: 0x001252E0 File Offset: 0x001234E0
	public static void FindTargetsWithTag(string inTag, ref List<AActor> refActors)
	{
		if (LevelGeneralCommons.TempFindEntities == null)
		{
			return;
		}
		refActors.Clear();
		CreatureModel.Instance.GetEntitiesWithTag(inTag, ref LevelGeneralCommons.TempFindEntities);
		if (LevelGeneralCommons.TempFindEntities.Count == 0)
		{
			return;
		}
		foreach (EntityHandle entity in LevelGeneralCommons.TempFindEntities)
		{
			AActor actor = CharacterController.Instance.GetActor(entity);
			if (actor != null)
			{
				refActors.Add(actor);
			}
		}
	}

	// Token: 0x060032F2 RID: 13042 RVA: 0x00125370 File Offset: 0x00123570
	public unsafe static void UpdateEntityTag(int inEntityId, string inTag, bool isAdd)
	{
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(inEntityId);
		if (entityById == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[ControllerHolder.LevelGeneralController.UpdateEntityTag] 无法找到对应entity 修改tag";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", inEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Tag", inTag);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		AActor actor = CharacterController.Instance.GetActor(entityById);
		if (actor == null)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Level;
			ELogAuthor author2 = ELogAuthor.YZH;
			string message2 = "[ControllerHolder.LevelGeneralController.UpdateEntityTag] 无法找到对应表现Actor 修改tag";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", inEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Tag", inTag);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		FName value = FNameUtil.GetDynamicFName(inTag).Value;
		if (isAdd)
		{
			actor.Tags.Add(value);
			LevelGeneralCommons.AddPublicTag(inTag, actor);
			return;
		}
		int num = actor.Tags.FindIndex(value);
		if (num == -1)
		{
			return;
		}
		actor.Tags.RemoveAt(num);
		LevelGeneralCommons.RemovePublicTag(inTag, actor);
	}

	// Token: 0x060032F3 RID: 13043 RVA: 0x0012549C File Offset: 0x0012369C
	[NullableContext(2)]
	public static string GetConditionGroupHintText(int inConditionGroupId)
	{
		ConditionGroup? config = ConfigConditionGroupById.GetConfig(inConditionGroupId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().HintText;
	}

	// Token: 0x060032F4 RID: 13044 RVA: 0x001254CC File Offset: 0x001236CC
	public static string GetReachedConditionIds(int inConditionGroupId)
	{
		ConditionGroup? config = ConfigConditionGroupById.GetConfig(inConditionGroupId, true);
		if (config == null)
		{
			return string.Empty;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < config.Value.GroupIdLength; i++)
		{
			int p0Id = config.Value.GroupId(i);
			Condition? config2 = ConfigConditionById.GetConfig(p0Id, true);
			if (config2 != null && LevelGeneralController.Instance.HandleCondition(config2.Value, null, inConditionGroupId.ToString(), Array.Empty<object>()))
			{
				list.Add(p0Id.ToString());
			}
		}
		return string.Join(",", list);
	}

	// Token: 0x060032F5 RID: 13045 RVA: 0x00125570 File Offset: 0x00123770
	public static void PrechangeStateTag(int pbDataId, int tagId, string reason)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
		if (entityByPbDataId == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[ChangePerformanceTag] 找不到对应的Entity";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", pbDataId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (entityByPbDataId.IsInit)
		{
			LevelGeneralCommons.PrechangeStateTagInternal(pbDataId, entityByPbDataId, tagId);
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.Level;
		ELogAuthor author2 = ELogAuthor.CH;
		string message2 = "[ChangePerformanceTag] 对应的Entity并未初始化完成";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("pbDataId", pbDataId);
		instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
	}

	// Token: 0x060032F6 RID: 13046 RVA: 0x001255F8 File Offset: 0x001237F8
	private unsafe static void PrechangeStateTagInternal(int pbDataId, EntityHandle handle, int tagId)
	{
		WorldEntity entity = handle.Entity;
		LevelTagComponent levelTagComponent = (entity != null) ? entity.GetComponent<LevelTagComponent>() : null;
		if (levelTagComponent == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[ChangePerformanceTag] 找不到对应的LevelTagComponent";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", pbDataId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
		if (levelTagComponent.HasTag(tagId))
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Level;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "[ChangePerformanceTag] 已经拥有该状态Tag, 无需再切状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TagName", nameByTagId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pbDataId", pbDataId);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		WorldEntity entity2 = handle.Entity;
		CreatureDataComponent creatureDataComponent = (entity2 != null) ? entity2.GetComponent<CreatureDataComponent>() : null;
		EntityStateComponent component = TdUtils.GetComponent<EntityStateComponent>(((creatureDataComponent != null) ? creatureDataComponent.GetPbEntityInitData() : null).ComponentsData, EConfigComponent.EntityStateComponent);
		foreach (string state in IActionDefine.GetStatesByType(component.Type))
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(IActionDefine.GetEntityStateTag(component.Type, state));
			levelTagComponent.RemoveServerTagByIdLocal(tagIdByName, "ChangePerformanceTag");
		}
		levelTagComponent.AddServerTagByIdLocal(tagId, "ChangePerformanceTag");
		EventSystem.Instance.EmitWithTarget<int>(handle.Entity, EEventName.OnSceneItemStatePreChangeInSequence, tagId);
	}

	// Token: 0x060032F7 RID: 13047 RVA: 0x00125764 File Offset: 0x00123964
	public static void ChangeToDestroyState(int pbDataId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
		if (entityByPbDataId == null)
		{
			return;
		}
		if (!entityByPbDataId.IsInit)
		{
			return;
		}
		WorldEntity entity = entityByPbDataId.Entity;
		LevelTagComponent levelTagComponent = (entity != null) ? entity.GetComponent<LevelTagComponent>() : null;
		WorldEntity entity2 = entityByPbDataId.Entity;
		SceneItemStateComponent sceneItemStateComponent = (entity2 != null) ? entity2.GetComponent<SceneItemStateComponent>() : null;
		if (sceneItemStateComponent != null)
		{
			int stateTagId = sceneItemStateComponent.StateTagId;
			if (levelTagComponent != null)
			{
				levelTagComponent.RemoveServerTagByIdLocal(sceneItemStateComponent.StateTagId, "ChangeToDestroyState");
			}
		}
		if (levelTagComponent != null)
		{
			levelTagComponent.AddServerTagByIdLocal(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.销毁"], "ChangeToDestroyState");
		}
	}

	// Token: 0x060032F8 RID: 13048 RVA: 0x001257EC File Offset: 0x001239EC
	public static void RollbackDestroyState(int pbDataId, int tagId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
		if (entityByPbDataId == null)
		{
			return;
		}
		if (!entityByPbDataId.IsInit)
		{
			return;
		}
		WorldEntity entity = entityByPbDataId.Entity;
		LevelTagComponent levelTagComponent = (entity != null) ? entity.GetComponent<LevelTagComponent>() : null;
		WorldEntity entity2 = entityByPbDataId.Entity;
		SceneItemStateComponent sceneItemStateComponent = (entity2 != null) ? entity2.GetComponent<SceneItemStateComponent>() : null;
		bool flag;
		if (sceneItemStateComponent == null)
		{
			flag = false;
		}
		else
		{
			int stateTagId = sceneItemStateComponent.StateTagId;
			flag = true;
		}
		if (flag && levelTagComponent != null)
		{
			levelTagComponent.RemoveServerTagByIdLocal(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.销毁"], "RollbackDestroyState");
		}
		if (levelTagComponent != null)
		{
			levelTagComponent.AddServerTagByIdLocal(tagId, "RollbackDestroyState");
		}
	}

	// Token: 0x060032F9 RID: 13049 RVA: 0x00125873 File Offset: 0x00123A73
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060032FA RID: 13050 RVA: 0x00125875 File Offset: 0x00123A75
	public static void ResetStaticDefaultValue()
	{
		LevelGeneralCommons.TempTags = null;
		LevelGeneralCommons.TempFindEntities = null;
	}

	// Token: 0x04002BD5 RID: 11221
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> TempTags;

	// Token: 0x04002BD6 RID: 11222
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<EntityHandle> TempFindEntities;
}
