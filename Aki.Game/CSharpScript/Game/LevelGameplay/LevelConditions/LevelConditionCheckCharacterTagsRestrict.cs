using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DD8 RID: 24024
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionCheckCharacterTagsRestrict : LevelConditionBase, IStaticVariableResetter
	{
		// Token: 0x0603A692 RID: 239250 RVA: 0x010819DD File Offset: 0x0107FBDD
		static LevelConditionCheckCharacterTagsRestrict()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelConditionCheckCharacterTagsRestrict.CreateStaticDefaultValue), new Action(LevelConditionCheckCharacterTagsRestrict.ResetStaticDefaultValue));
		}

		// Token: 0x0603A693 RID: 239251 RVA: 0x010819FC File Offset: 0x0107FBFC
		public static void CreateStaticDefaultValue()
		{
			LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks = new Dictionary<TTagChangedCallback, List<int>>();
			LevelConditionCheckCharacterTagsRestrict.CallbackWrappers = new Dictionary<TTagChangedCallback, BaseTagComponent.TTagSwitchedCallback>();
			LevelConditionCheckCharacterTagsRestrict.SubscribedEntity = null;
		}

		// Token: 0x0603A694 RID: 239252 RVA: 0x01081A18 File Offset: 0x0107FC18
		public static void ResetStaticDefaultValue()
		{
			LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks = null;
			LevelConditionCheckCharacterTagsRestrict.CallbackWrappers = null;
			LevelConditionCheckCharacterTagsRestrict.SubscribedEntity = null;
		}

		// Token: 0x0603A695 RID: 239253 RVA: 0x01081A2C File Offset: 0x0107FC2C
		private static List<string> ParseTagNames([Nullable(2)] string raw)
		{
			if (string.IsNullOrEmpty(raw))
			{
				return new List<string>();
			}
			return raw.TrimStart('[').TrimEnd(']').Split(',', StringSplitOptions.None).ToList<string>();
		}

		// Token: 0x0603A696 RID: 239254 RVA: 0x01081A58 File Offset: 0x0107FC58
		public static List<string> GetTagNames(Condition inConditionInfo)
		{
			List<string> list = new List<string>();
			list.AddRange(LevelConditionCheckCharacterTagsRestrict.ParseTagNames(inConditionInfo.GetLimitParams("RequireTags")));
			list.AddRange(LevelConditionCheckCharacterTagsRestrict.ParseTagNames(inConditionInfo.GetLimitParams("BanTags")));
			return list;
		}

		// Token: 0x0603A697 RID: 239255 RVA: 0x01081A90 File Offset: 0x0107FC90
		private static BaseTagComponent.TTagSwitchedCallback GetWrapper(TTagChangedCallback callback)
		{
			BaseTagComponent.TTagSwitchedCallback ttagSwitchedCallback;
			if (!LevelConditionCheckCharacterTagsRestrict.CallbackWrappers.TryGetValue(callback, out ttagSwitchedCallback))
			{
				ttagSwitchedCallback = delegate(int tagId, bool tagExist)
				{
					callback(new object[]
					{
						tagId,
						tagExist
					});
				};
				LevelConditionCheckCharacterTagsRestrict.CallbackWrappers[callback] = ttagSwitchedCallback;
			}
			return ttagSwitchedCallback;
		}

		// Token: 0x0603A698 RID: 239256 RVA: 0x01081AE0 File Offset: 0x0107FCE0
		public static void RegisterEvents(Condition inConditionInfo, TTagChangedCallback callback)
		{
			if (LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks.Count == 0)
			{
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.OnChangeRole;
				Action<EntityHandle, EntityHandle> handle;
				if ((handle = LevelConditionCheckCharacterTagsRestrict.<>O.<0>__OnChangeRole) == null)
				{
					handle = (LevelConditionCheckCharacterTagsRestrict.<>O.<0>__OnChangeRole = new Action<EntityHandle, EntityHandle>(LevelConditionCheckCharacterTagsRestrict.OnChangeRole));
				}
				instance.Add(name, handle);
				SceneTeamModel instance2 = SceneTeamModel.Instance;
				WorldEntity subscribedEntity;
				if (instance2 == null)
				{
					subscribedEntity = null;
				}
				else
				{
					EntityHandle getCurrentEntity = instance2.GetCurrentEntity;
					subscribedEntity = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
				}
				LevelConditionCheckCharacterTagsRestrict.SubscribedEntity = subscribedEntity;
			}
			List<int> list = new List<int>();
			foreach (string tagName in LevelConditionCheckCharacterTagsRestrict.GetTagNames(inConditionInfo))
			{
				list.Add(GameplayTagUtils.GetTagIdByName(tagName));
			}
			LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks[callback] = list;
			LevelConditionCheckCharacterTagsRestrict.SubscribeCallback(callback, list);
		}

		// Token: 0x0603A699 RID: 239257 RVA: 0x01081BAC File Offset: 0x0107FDAC
		public static void UnRegisterEvents(Condition inConditionInfo, TTagChangedCallback callback)
		{
			if (!LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks.Remove(callback))
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (string tagName in LevelConditionCheckCharacterTagsRestrict.GetTagNames(inConditionInfo))
			{
				list.Add(GameplayTagUtils.GetTagIdByName(tagName));
			}
			LevelConditionCheckCharacterTagsRestrict.UnsubscribeCallback(callback, list);
			LevelConditionCheckCharacterTagsRestrict.CallbackWrappers.Remove(callback);
			if (LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks.Count == 0)
			{
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.OnChangeRole;
				Action<EntityHandle, EntityHandle> handle;
				if ((handle = LevelConditionCheckCharacterTagsRestrict.<>O.<0>__OnChangeRole) == null)
				{
					handle = (LevelConditionCheckCharacterTagsRestrict.<>O.<0>__OnChangeRole = new Action<EntityHandle, EntityHandle>(LevelConditionCheckCharacterTagsRestrict.OnChangeRole));
				}
				instance.Remove(name, handle);
				LevelConditionCheckCharacterTagsRestrict.SubscribedEntity = null;
			}
		}

		// Token: 0x0603A69A RID: 239258 RVA: 0x01081C68 File Offset: 0x0107FE68
		private static void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			foreach (KeyValuePair<TTagChangedCallback, List<int>> keyValuePair in LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks)
			{
				TTagChangedCallback ttagChangedCallback;
				List<int> list;
				keyValuePair.Deconstruct(out ttagChangedCallback, out list);
				TTagChangedCallback callback = ttagChangedCallback;
				List<int> tagIds = list;
				LevelConditionCheckCharacterTagsRestrict.UnsubscribeCallback(callback, tagIds);
			}
			LevelConditionCheckCharacterTagsRestrict.SubscribedEntity = ((newEntity != null) ? newEntity.Entity : null);
			foreach (KeyValuePair<TTagChangedCallback, List<int>> keyValuePair in LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks)
			{
				TTagChangedCallback ttagChangedCallback;
				List<int> list;
				keyValuePair.Deconstruct(out ttagChangedCallback, out list);
				TTagChangedCallback callback2 = ttagChangedCallback;
				List<int> tagIds2 = list;
				LevelConditionCheckCharacterTagsRestrict.SubscribeCallback(callback2, tagIds2);
			}
		}

		// Token: 0x0603A69B RID: 239259 RVA: 0x01081D2C File Offset: 0x0107FF2C
		private static void SubscribeCallback(TTagChangedCallback callback, List<int> tagIds)
		{
			WorldEntity subscribedEntity = LevelConditionCheckCharacterTagsRestrict.SubscribedEntity;
			BaseTagComponent baseTagComponent = (subscribedEntity != null) ? subscribedEntity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent == null)
			{
				return;
			}
			BaseTagComponent.TTagSwitchedCallback wrapper = LevelConditionCheckCharacterTagsRestrict.GetWrapper(callback);
			foreach (int tagId in tagIds)
			{
				baseTagComponent.AddTagAddOrRemoveListener(tagId, wrapper, null);
			}
		}

		// Token: 0x0603A69C RID: 239260 RVA: 0x01081D9C File Offset: 0x0107FF9C
		private static void UnsubscribeCallback(TTagChangedCallback callback, List<int> tagIds)
		{
			WorldEntity subscribedEntity = LevelConditionCheckCharacterTagsRestrict.SubscribedEntity;
			BaseTagComponent baseTagComponent = (subscribedEntity != null) ? subscribedEntity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent == null)
			{
				return;
			}
			BaseTagComponent.TTagSwitchedCallback wrapper = LevelConditionCheckCharacterTagsRestrict.GetWrapper(callback);
			foreach (int tagId in tagIds)
			{
				baseTagComponent.RemoveTagAddOrRemoveListener(tagId, wrapper);
			}
		}

		// Token: 0x0603A69D RID: 239261 RVA: 0x01081E08 File Offset: 0x01080008
		private List<int> ParseTagIds([Nullable(2)] string raw)
		{
			List<int> list = new List<int>();
			foreach (string tagName in LevelConditionCheckCharacterTagsRestrict.ParseTagNames(raw))
			{
				list.Add(GameplayTagUtils.GetTagIdByName(tagName));
			}
			return list;
		}

		// Token: 0x0603A69E RID: 239262 RVA: 0x01081E68 File Offset: 0x01080068
		private TagIdRule GetRule(Condition inConditionInfo)
		{
			TagIdRule tagIdRule;
			if (!this.RuleCache.TryGetValue(inConditionInfo.Id, out tagIdRule))
			{
				tagIdRule = new TagIdRule
				{
					RequireTags = this.ParseTagIds(inConditionInfo.GetLimitParams("RequireTags")),
					BanTags = this.ParseTagIds(inConditionInfo.GetLimitParams("BanTags")),
					LastReached = false
				};
				this.RuleCache[inConditionInfo.Id] = tagIdRule;
			}
			return tagIdRule;
		}

		// Token: 0x0603A69F RID: 239263 RVA: 0x01081EDC File Offset: 0x010800DC
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			LevelConditionCheckCharacterTagsRestrict.<>c__DisplayClass17_0 CS$<>8__locals1 = new LevelConditionCheckCharacterTagsRestrict.<>c__DisplayClass17_0();
			TagIdRule rule = this.GetRule(inConditionInfo);
			if (rule.RequireTags.Count == 0 && rule.BanTags.Count == 0)
			{
				return false;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return false;
			}
			LevelConditionCheckCharacterTagsRestrict.<>c__DisplayClass17_0 CS$<>8__locals2 = CS$<>8__locals1;
			WorldEntity entity = getCurrentEntity.Entity;
			CS$<>8__locals2.tagComp = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			if (CS$<>8__locals1.tagComp == null)
			{
				Log.Instance.Warn(ELogModule.LevelCondition, ELogAuthor.CB, "[CheckRoleStateTag]无法获取当前角色BaseTagComponent组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			bool flag = true;
			bool flag2 = false;
			if (rule.RequireTags.Count > 0)
			{
				flag = rule.RequireTags.TrueForAll((int tagId) => CS$<>8__locals1.tagComp.HasTag(tagId));
			}
			if (rule.BanTags.Count > 0)
			{
				flag2 = rule.BanTags.Exists((int tagId) => CS$<>8__locals1.tagComp.HasTag(tagId));
			}
			rule.LastReached = (flag2 || !flag);
			bool lastReached = rule.LastReached;
			return rule.LastReached;
		}

		// Token: 0x0401EC52 RID: 126034
		private readonly Dictionary<int, TagIdRule> RuleCache = new Dictionary<int, TagIdRule>();

		// Token: 0x0401EC53 RID: 126035
		private static Dictionary<TTagChangedCallback, List<int>> RegisteredCallbacks;

		// Token: 0x0401EC54 RID: 126036
		private static Dictionary<TTagChangedCallback, BaseTagComponent.TTagSwitchedCallback> CallbackWrappers;

		// Token: 0x0401EC55 RID: 126037
		[Nullable(2)]
		private static WorldEntity SubscribedEntity;

		// Token: 0x0200B88D RID: 47245
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04038F9A RID: 233370
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Action<EntityHandle, EntityHandle> <0>__OnChangeRole;
		}
	}
}
