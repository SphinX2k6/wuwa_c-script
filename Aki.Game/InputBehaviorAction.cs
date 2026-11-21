using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020026AD RID: 9901
[NullableContext(1)]
[Nullable(0)]
public class InputBehaviorAction
{
	// Token: 0x06018D23 RID: 101667 RVA: 0x00789620 File Offset: 0x00787820
	public unsafe static void ExecuteGroup(TArray<SInputBehaviorAction> actions, IInputBehaviorParam param)
	{
		for (int i = 0; i < actions.Num(); i++)
		{
			SInputBehaviorAction sinputBehaviorAction = actions.Get(i);
			try
			{
				InputBehaviorAction.Execute(sinputBehaviorAction, param);
			}
			catch (Exception ex)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				Entity entity = param.Entity;
				string message = "InputBehaviorAction行为执行异常";
				Exception e = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", param.Skill.SkillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名", param.Skill.SkillName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("行为类型", sinputBehaviorAction.ActionType);
				instance.ErrorWithStack(flag, entity, message, e, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}
	}

	// Token: 0x06018D24 RID: 101668 RVA: 0x00789700 File Offset: 0x00787900
	private static void Execute(SInputBehaviorAction action, IInputBehaviorParam param)
	{
		switch (action.ActionType)
		{
		case EInputBehaviorActionType.播放蒙太奇:
			InputBehaviorAction.PlaySkillMontage(action, param);
			return;
		case EInputBehaviorActionType.Tag增删:
			InputBehaviorAction.ModifyTags(action, param);
			return;
		case EInputBehaviorActionType.结束技能:
			InputBehaviorAction.EndSkill(action, param);
			return;
		default:
			return;
		}
	}

	// Token: 0x06018D25 RID: 101669 RVA: 0x00789744 File Offset: 0x00787944
	private static void PlaySkillMontage(SInputBehaviorAction action, IInputBehaviorParam param)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(param.Entity.Id);
		if (component != null && component.Valid)
		{
			component.PlaySkillMontageWithEndAbility(param.Skill, action.MontageIndex, action.StartSection, action.StartTime);
		}
	}

	// Token: 0x06018D26 RID: 101670 RVA: 0x00789794 File Offset: 0x00787994
	private static void ModifyTags(SInputBehaviorAction action, IInputBehaviorParam param)
	{
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(param.Entity.Id);
		TArray<FGameplayTag> gameplayTags = action.Tags.GameplayTags;
		if (component != null && component.Valid)
		{
			for (int i = 0; i < gameplayTags.Num(); i++)
			{
				FGameplayTag fgameplayTag = gameplayTags.Get(i);
				if (!(fgameplayTag.TagName == "None"))
				{
					if (action.bAdd)
					{
						component.AddTag(new int?(fgameplayTag.TagId()));
					}
					else
					{
						component.RemoveTag(new int?(fgameplayTag.TagId()));
					}
				}
			}
		}
	}

	// Token: 0x06018D27 RID: 101671 RVA: 0x0078982C File Offset: 0x00787A2C
	private static void EndSkill(SInputBehaviorAction action, IInputBehaviorParam param)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(param.Entity.Id);
		if (component == null || !component.Valid || component.CurrentSkill != param.Skill)
		{
			return;
		}
		component.EndSkill(param.Skill.SkillId, "InputBehaviorAction.EndSkill");
	}
}
