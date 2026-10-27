using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C5E RID: 27742
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionCheckCharacterTagsRestrict : LevelConditionBase, IStaticVariableResetter
	{
		// Token: 0x06044538 RID: 279864 RVA: 0x010D7A45 File Offset: 0x010D5C45
		static LevelConditionCheckCharacterTagsRestrict()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelConditionCheckCharacterTagsRestrict.CreateStaticDefaultValue), new Action(LevelConditionCheckCharacterTagsRestrict.ResetStaticDefaultValue));
		}

		// Token: 0x06044539 RID: 279865 RVA: 0x010D7A64 File Offset: 0x010D5C64
		public static void CreateStaticDefaultValue()
		{
			LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks = new Dictionary<TTagChangedCallback, List<int>>();
			LevelConditionCheckCharacterTagsRestrict.CallbackWrappers = new Dictionary<TTagChangedCallback, BaseTagComponent.TTagSwitchedCallback>();
			LevelConditionCheckCharacterTagsRestrict.SubscribedEntity = null;
		}

		// Token: 0x0604453A RID: 279866 RVA: 0x010D7A80 File Offset: 0x010D5C80
		public static void ResetStaticDefaultValue()
		{
			LevelConditionCheckCharacterTagsRestrict.RegisteredCallbacks = null;
			LevelConditionCheckCharacterTagsRestrict.CallbackWrappers = null;
			LevelConditionCheckCharacterTagsRestrict.SubscribedEntity = null;
		}

		// Token: 0x0604453B RID: 279867 RVA: 0x010D7A94 File Offset: 0x010D5C94
		private static List<string> ParseTagNames([Nullable(2)] string raw)
		{
			if (string.IsNullOrEmpty(raw))
			{
				return new List<string>();
			}
			return raw.TrimStart('[').TrimEnd(']').Split(',', StringSplitOptions.None).ToList<string>();
		}

		// Token: 0x0604453C RID: 279868 RVA: 0x010D7AC0 File Offset: 0x010D5CC0
		public static List<string> GetTagNames(Condition inConditionInfo)
		{
			List<string> list = new List<string>();
			list.AddRange(LevelConditionCheckCharacterTagsRestrict.ParseTagNames(inConditionInfo.GetLimitParams("RequireTags")));
			list.AddRange(LevelConditionCheckCharacterTagsRestrict.ParseTagNames(inConditionInfo.GetLimitParams("BanTags")));
			return list;
		}

		// Token: 0x0604453D RID: 279869 RVA: 0x010D7AF8 File Offset: 0x010D5CF8
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

		// Token: 0x0604453E RID: 279870 RVA: 0x010D7B48 File Offset: 0x010D5D48
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

		// Token: 0x0604453F RID: 279871 RVA: 0x010D7C14 File Offset: 0x010D5E14
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

		// Token: 0x06044540 RID: 279872 RVA: 0x010D7CD0 File Offset: 0x010D5ED0
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

		// Token: 0x06044541 RID: 279873 RVA: 0x010D7D94 File Offset: 0x010D5F94
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

		// Token: 0x06044542 RID: 279874 RVA: 0x010D7E04 File Offset: 0x010D6004
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

		// Token: 0x06044543 RID: 279875 RVA: 0x010D7E70 File Offset: 0x010D6070
		private List<int> ParseTagIds([Nullable(2)] string raw)
		{
			List<int> list = new List<int>();
			foreach (string tagName in LevelConditionCheckCharacterTagsRestrict.ParseTagNames(raw))
			{
				list.Add(GameplayTagUtils.GetTagIdByName(tagName));
			}
			return list;
		}

		// Token: 0x06044544 RID: 279876 RVA: 0x010D7ED0 File Offset: 0x010D60D0
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

		// Token: 0x06044545 RID: 279877 RVA: 0x010D7F44 File Offset: 0x010D6144
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
				flag = rule.RequireTags.All((int tagId) => CS$<>8__locals1.tagComp.HasTag(tagId));
			}
			if (rule.BanTags.Count > 0)
			{
				flag2 = rule.BanTags.Any((int tagId) => CS$<>8__locals1.tagComp.HasTag(tagId));
			}
			rule.LastReached = (flag2 || !flag);
			bool lastReached = rule.LastReached;
			return rule.LastReached;
		}

		// Token: 0x040239B0 RID: 145840
		private readonly Dictionary<int, TagIdRule> RuleCache = new Dictionary<int, TagIdRule>();

		// Token: 0x040239B1 RID: 145841
		private static Dictionary<TTagChangedCallback, List<int>> RegisteredCallbacks;

		// Token: 0x040239B2 RID: 145842
		private static Dictionary<TTagChangedCallback, BaseTagComponent.TTagSwitchedCallback> CallbackWrappers;

		// Token: 0x040239B3 RID: 145843
		[Nullable(2)]
		private static WorldEntity SubscribedEntity;

		// Token: 0x0200CC9D RID: 52381
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403DB78 RID: 252792
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
