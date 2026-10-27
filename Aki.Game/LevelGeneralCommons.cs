using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.CreatureTools;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

// Token: 0x02000EE4 RID: 3812
[NullableContext(1)]
[Nullable(0)]
public class LevelGeneralCommons : IStaticVariableResetter
{
	// Token: 0x06005F55 RID: 24405 RVA: 0x0011D42D File Offset: 0x0011B62D
	static LevelGeneralCommons()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelGeneralCommons.CreateStaticDefaultValue), new Action(LevelGeneralCommons.ResetStaticDefaultValue));
	}

	// Token: 0x06005F56 RID: 24406 RVA: 0x0011D44C File Offset: 0x0011B64C
	public static void Init()
	{
		LevelGeneralCommons.TempTags = new List<string>();
		LevelGeneralCommons.TempFindEntities = new List<EntityHandle>();
	}

	// Token: 0x06005F57 RID: 24407 RVA: 0x0011D462 File Offset: 0x0011B662
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

	// Token: 0x06005F58 RID: 24408 RVA: 0x0011D488 File Offset: 0x0011B688
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

	// Token: 0x06005F59 RID: 24409 RVA: 0x0011D4D4 File Offset: 0x0011B6D4
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

	// Token: 0x06005F5A RID: 24410 RVA: 0x0011D51E File Offset: 0x0011B71E
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

	// Token: 0x06005F5B RID: 24411 RVA: 0x0011D55C File Offset: 0x0011B75C
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

	// Token: 0x06005F5C RID: 24412 RVA: 0x0011D5EC File Offset: 0x0011B7EC
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

	// Token: 0x06005F5D RID: 24413 RVA: 0x0011D718 File Offset: 0x0011B918
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

	// Token: 0x06005F5E RID: 24414 RVA: 0x0011D748 File Offset: 0x0011B948
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

	// Token: 0x06005F5F RID: 24415 RVA: 0x0011D7D0 File Offset: 0x0011B9D0
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

	// Token: 0x06005F60 RID: 24416 RVA: 0x0011D93C File Offset: 0x0011BB3C
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

	// Token: 0x06005F61 RID: 24417 RVA: 0x0011D9C4 File Offset: 0x0011BBC4
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

	// Token: 0x06005F62 RID: 24418 RVA: 0x0011DA4B File Offset: 0x0011BC4B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005F63 RID: 24419 RVA: 0x0011DA4D File Offset: 0x0011BC4D
	public static void ResetStaticDefaultValue()
	{
		LevelGeneralCommons.TempTags = null;
		LevelGeneralCommons.TempFindEntities = null;
	}

	// Token: 0x04002B3B RID: 11067
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> TempTags;

	// Token: 0x04002B3C RID: 11068
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<EntityHandle> TempFindEntities;
}
