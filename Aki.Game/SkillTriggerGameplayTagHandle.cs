using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003160 RID: 12640
[NullableContext(1)]
[Nullable(0)]
public class SkillTriggerGameplayTagHandle : SkillTriggerBaseHandle
{
	// Token: 0x0601B323 RID: 111395 RVA: 0x007687F0 File Offset: 0x007669F0
	public SkillTriggerGameplayTagHandle(Entity entity) : base(entity)
	{
	}

	// Token: 0x0601B324 RID: 111396 RVA: 0x0076880F File Offset: 0x00766A0F
	public override void Create()
	{
		this.SkillComp = this.Entity.CheckGetComponent<BaseSkillComponent>();
		this.AbilityComp = this.Entity.CheckGetComponent<CharacterAbilityComponent>();
		this.TagComponent = this.Entity.CheckGetComponent<BaseTagComponent>();
	}

	// Token: 0x0601B325 RID: 111397 RVA: 0x00768844 File Offset: 0x00766A44
	public override void Destroy()
	{
		if (this.GameplayEventTask != null)
		{
			this.GameplayEventTask.EndTask();
		}
		foreach (ITagTask tagTask in this.TagListeners)
		{
			tagTask.EndTask();
		}
	}

	// Token: 0x0601B326 RID: 111398 RVA: 0x007688A8 File Offset: 0x00766AA8
	public unsafe override void AddSkillTrigger(SkillTriggerBase skillTrigger, int skillId, SSkillInfo info)
	{
		SkillTriggerGameplayTag skillTriggerGameplayTag = skillTrigger as SkillTriggerGameplayTag;
		if (skillTriggerGameplayTag == null || skillTriggerGameplayTag.TriggerData == null)
		{
			return;
		}
		if (skillTriggerGameplayTag.TriggerData.TriggerTag.TagName == "None")
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = this.Entity;
			string message = "注册技能触发器失败，触发标签为空";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", skillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名", info.SkillName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("触发器", skillTriggerGameplayTag);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		EGameplayAbilityTriggerSource key = skillTriggerGameplayTag.TriggerData.TriggerSource;
		int num = skillTriggerGameplayTag.TriggerData.TriggerTag.TagId();
		Dictionary<int, ValueTuple<int, SkillTriggerGameplayTag>> dictionary;
		if (!this.SkillTriggerGameplayTagMap.TryGetValue(key, out dictionary))
		{
			dictionary = new Dictionary<int, ValueTuple<int, SkillTriggerGameplayTag>>();
			this.SkillTriggerGameplayTagMap[key] = dictionary;
		}
		if (dictionary.ContainsKey(num))
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
			Entity entity2 = this.Entity;
			string message2 = "注册技能触发器失败，重复的触发器";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("技能Id", skillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("技能名", info.SkillName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("触发器", skillTriggerGameplayTag);
			instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return;
		}
		dictionary[num] = new ValueTuple<int, SkillTriggerGameplayTag>(skillId, skillTriggerGameplayTag);
		switch (key)
		{
		case EGameplayAbilityTriggerSource.GameplayEvent:
			if (this.GameplayEventTask == null)
			{
				this.GameplayEventTask = this.AbilityComp.CreateGameplayEventTask(new Action<FGameplayTag, FGameplayEventData>(this.GameplayEventCallback));
			}
			break;
		case EGameplayAbilityTriggerSource.OwnedTagAdded:
			this.TagListeners.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(num), new BaseTagComponent.TTagSwitchedCallback(this.OnOwnedTagAdded), null));
			break;
		case EGameplayAbilityTriggerSource.OwnedTagPresent:
			this.TagListeners.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(num), new BaseTagComponent.TTagSwitchedCallback(this.OnOwnedTagPresent), null));
			break;
		}
		CombatLog instance3 = CombatLog.Instance;
		CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Skill;
		Entity entity3 = this.Entity;
		string message3 = "注册技能触发器成功";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("技能Id", skillId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("技能名", info.SkillName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("触发器", skillTriggerGameplayTag);
		instance3.Info(flag3, entity3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
	}

	// Token: 0x0601B327 RID: 111399 RVA: 0x00768B54 File Offset: 0x00766D54
	private void GameplayEventCallback(FGameplayTag eventTag, FGameplayEventData payload)
	{
		int num = eventTag.TagId();
		if (num == 0)
		{
			return;
		}
		ValueTuple<bool, int> valueTuple = this.CheckCondition(EGameplayAbilityTriggerSource.GameplayEvent, num);
		bool item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		if (!item)
		{
			return;
		}
		this.SkillComp.BeginSkill(item2, new SkillParam
		{
			Reason = "技能触发器GameplayEvent"
		});
	}

	// Token: 0x0601B328 RID: 111400 RVA: 0x00768BA4 File Offset: 0x00766DA4
	private void OnOwnedTagAdded(int tagId, bool bTagExists)
	{
		if (!bTagExists)
		{
			return;
		}
		ValueTuple<bool, int> valueTuple = this.CheckCondition(EGameplayAbilityTriggerSource.OwnedTagAdded, tagId);
		bool item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		if (!item)
		{
			return;
		}
		this.SkillComp.BeginSkill(item2, new SkillParam
		{
			Reason = "技能触发器OwnedTagAdded"
		});
	}

	// Token: 0x0601B329 RID: 111401 RVA: 0x00768BEC File Offset: 0x00766DEC
	private void OnOwnedTagPresent(int tagId, bool bTagExists)
	{
		ValueTuple<bool, int> valueTuple = this.CheckCondition(EGameplayAbilityTriggerSource.OwnedTagPresent, tagId);
		bool item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		if (!item)
		{
			return;
		}
		if (bTagExists)
		{
			this.SkillComp.BeginSkill(item2, new SkillParam
			{
				Reason = "技能触发器OwnedTagPresent"
			});
			return;
		}
		this.SkillComp.EndSkill(item2, "技能触发器OwnedTagPresent");
	}

	// Token: 0x0601B32A RID: 111402 RVA: 0x00768C44 File Offset: 0x00766E44
	[NullableContext(0)]
	private unsafe ValueTuple<bool, int> CheckCondition(EGameplayAbilityTriggerSource triggerSource, int tagId)
	{
		Dictionary<int, ValueTuple<int, SkillTriggerGameplayTag>> dictionary;
		if (!this.SkillTriggerGameplayTagMap.TryGetValue(triggerSource, out dictionary))
		{
			return new ValueTuple<bool, int>(false, 0);
		}
		ValueTuple<int, SkillTriggerGameplayTag> valueTuple;
		if (!dictionary.TryGetValue(tagId, out valueTuple))
		{
			return new ValueTuple<bool, int>(false, 0);
		}
		ValueTuple<int, SkillTriggerGameplayTag> valueTuple2 = valueTuple;
		int item = valueTuple2.Item1;
		SkillTriggerGameplayTag item2 = valueTuple2.Item2;
		if (!SkillBehaviorCondition.SatisfyGroup(item2.TriggerConditionGroup, item2.TriggerConditionFormula, new BeginSkillBehaviorConditionParam
		{
			Entity = this.Entity,
			SkillComponent = this.SkillComp,
			Skill = this.SkillComp.GetSkill(item)
		}))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = this.Entity;
			string message = "技能触发器条件不满足";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名", item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("触发标签", GameplayTagUtils.GetNameByTagId(tagId));
			instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return new ValueTuple<bool, int>(false, 0);
		}
		return new ValueTuple<bool, int>(true, item);
	}

	// Token: 0x0400D3B0 RID: 54192
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D3B1 RID: 54193
	[Nullable(2)]
	private CharacterAbilityComponent AbilityComp;

	// Token: 0x0400D3B2 RID: 54194
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400D3B3 RID: 54195
	[Nullable(2)]
	private UAsyncTaskWaitGameplayEvent GameplayEventTask;

	// Token: 0x0400D3B4 RID: 54196
	[Nullable(new byte[]
	{
		1,
		1,
		0,
		1
	})]
	private readonly Dictionary<EGameplayAbilityTriggerSource, Dictionary<int, ValueTuple<int, SkillTriggerGameplayTag>>> SkillTriggerGameplayTagMap = new Dictionary<EGameplayAbilityTriggerSource, Dictionary<int, ValueTuple<int, SkillTriggerGameplayTag>>>();

	// Token: 0x0400D3B5 RID: 54197
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();
}
