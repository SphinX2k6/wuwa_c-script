using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x020026B0 RID: 9904
[NullableContext(1)]
[Nullable(0)]
public class InputBehaviorCondition
{
	// Token: 0x06018D34 RID: 101684 RVA: 0x0078991C File Offset: 0x00787B1C
	[return: Nullable(2)]
	public unsafe static InputBehaviorConditionContext CreateContext(SInputBehavior behavior, IInputBehaviorParam param)
	{
		TArray<SInputBehaviorCondition> behaviorConditionArray = behavior.BehaviorConditionArray;
		if (behaviorConditionArray.Num() == 0)
		{
			return null;
		}
		bool[] array = new bool[behaviorConditionArray.Num()];
		ConditionArray formulaSolver = null;
		if (!string.IsNullOrEmpty(behavior.ConditionFormula))
		{
			try
			{
				Parser parser = new Parser(behavior.ConditionFormula);
				formulaSolver = new ConditionArray(array, parser.Parse());
			}
			catch (Exception ex)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				Entity entity = param.Entity;
				string message = "InputBehaviorCondition条件公式解析异常";
				Exception e = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", param.Skill.SkillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("技能名", param.Skill.SkillName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("formula", behavior.ConditionFormula);
				instance.ErrorWithStack(flag, entity, message, e, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
		}
		InputBehaviorConditionContext inputBehaviorConditionContext = new InputBehaviorConditionContext(behavior, array, formulaSolver);
		for (int i = 0; i < behaviorConditionArray.Num(); i++)
		{
			SInputBehaviorCondition sinputBehaviorCondition = behaviorConditionArray.Get(i);
			if (sinputBehaviorCondition.ConditionType == EInputBehaviorConditionType.按键未按下)
			{
				inputBehaviorConditionContext.Results[i] = InputBehaviorCondition.ConditionInputNotDown(sinputBehaviorCondition, param);
			}
		}
		return inputBehaviorConditionContext;
	}

	// Token: 0x06018D35 RID: 101685 RVA: 0x00789A68 File Offset: 0x00787C68
	public static bool SatisfyGroup(InputBehaviorConditionContext context, IInputBehaviorParam param, [Nullable(2)] IInputBehaviorInputFrame inputFrame = null)
	{
		TArray<SInputBehaviorCondition> behaviorConditionArray = context.Behavior.BehaviorConditionArray;
		bool flag = !string.IsNullOrEmpty(context.Behavior.ConditionFormula);
		context.PendingHoldConsumptions.Clear();
		bool flag2 = true;
		for (int i = 0; i < behaviorConditionArray.Num(); i++)
		{
			SInputBehaviorCondition sinputBehaviorCondition = behaviorConditionArray.Get(i);
			bool flag3;
			if (sinputBehaviorCondition.ConditionType == EInputBehaviorConditionType.按键未按下)
			{
				flag3 = context.Results[i];
			}
			else
			{
				flag3 = InputBehaviorCondition.Satisfy(sinputBehaviorCondition, param, inputFrame, context, i);
			}
			if (flag)
			{
				context.Results[i] = flag3;
			}
			else if (!flag3)
			{
				flag2 = false;
			}
		}
		bool flag4;
		if (!flag)
		{
			flag4 = flag2;
		}
		else
		{
			ConditionArray formulaSolver = context.FormulaSolver;
			flag4 = (formulaSolver != null && formulaSolver.EvaluateByConditions(context.Results));
		}
		bool flag5 = flag4;
		if (flag5)
		{
			foreach (IPendingHoldConsumption pendingHoldConsumption in context.PendingHoldConsumptions)
			{
				context.HoldTriggeredPressIds[pendingHoldConsumption.ConditionIndex] = pendingHoldConsumption.PressId;
			}
		}
		context.PendingHoldConsumptions.Clear();
		return flag5;
	}

	// Token: 0x06018D36 RID: 101686 RVA: 0x00789B84 File Offset: 0x00787D84
	private static bool Satisfy(SInputBehaviorCondition condition, IInputBehaviorParam param, [Nullable(2)] IInputBehaviorInputFrame inputFrame = null, [Nullable(2)] InputBehaviorConditionContext context = null, int conditionIndex = 0)
	{
		switch (condition.ConditionType)
		{
		case EInputBehaviorConditionType.按键按下:
			return InputBehaviorCondition.ConditionInputPress(condition, inputFrame);
		case EInputBehaviorConditionType.按键抬起:
			return InputBehaviorCondition.ConditionInputRelease(condition, inputFrame);
		case EInputBehaviorConditionType.按键持续按住:
			return InputBehaviorCondition.ConditionInputHold(condition, inputFrame, context, conditionIndex);
		case EInputBehaviorConditionType.施法者Tag检测:
			return InputBehaviorCondition.ConditionTag(condition, param);
		case EInputBehaviorConditionType.施法者属性检测:
			return InputBehaviorCondition.ConditionAttribute(condition, param);
		case EInputBehaviorConditionType.是否有技能目标:
			return InputBehaviorCondition.ConditionTarget(condition, param);
		default:
			return false;
		}
	}

	// Token: 0x06018D37 RID: 101687 RVA: 0x00789BF4 File Offset: 0x00787DF4
	private static bool ConditionInputNotDown(SInputBehaviorCondition condition, IInputBehaviorParam param)
	{
		EInputAction? inputAction = InputBehaviorInputHandler.GetInputAction(condition.InputType);
		if (inputAction == null)
		{
			return false;
		}
		BattleInputModel instance = BattleInputModel.Instance;
		if (instance == null || !instance.GetInputEnable(inputAction.Value))
		{
			return false;
		}
		CharacterInputComponent component = param.Entity.GetComponent<CharacterInputComponent>();
		return component != null && !component.GetInputFilter().BlockAction(inputAction.Value) && !InputController.Instance.IsKeyDown(inputAction.Value);
	}

	// Token: 0x06018D38 RID: 101688 RVA: 0x00789C78 File Offset: 0x00787E78
	private static bool ConditionInputPress(SInputBehaviorCondition condition, [Nullable(2)] IInputBehaviorInputFrame inputFrame = null)
	{
		EInputAction? inputAction = InputBehaviorInputHandler.GetInputAction(condition.InputType);
		return inputAction != null && inputFrame != null && inputFrame.PressedActions.Contains(inputAction.Value);
	}

	// Token: 0x06018D39 RID: 101689 RVA: 0x00789CB8 File Offset: 0x00787EB8
	private static bool ConditionInputRelease(SInputBehaviorCondition condition, [Nullable(2)] IInputBehaviorInputFrame inputFrame = null)
	{
		EInputAction? action = InputBehaviorInputHandler.GetInputAction(condition.InputType);
		return action != null && inputFrame != null && inputFrame.ReleaseEvents.Exists((IInputBehaviorReleaseEvent inputEvent) => inputEvent.Action == action.Value && InputBehaviorCondition.IsReleaseTimeValid(condition, inputEvent.ElapsedSinceAnsBegin));
	}

	// Token: 0x06018D3A RID: 101690 RVA: 0x00789D18 File Offset: 0x00787F18
	[NullableContext(2)]
	private static bool ConditionInputHold([Nullable(1)] SInputBehaviorCondition condition, IInputBehaviorInputFrame inputFrame = null, InputBehaviorConditionContext context = null, int conditionIndex = 0)
	{
		EInputAction? action = InputBehaviorInputHandler.GetInputAction(condition.InputType);
		if (action == null || inputFrame == null || context == null)
		{
			return false;
		}
		IInputBehaviorHoldState inputBehaviorHoldState = inputFrame.HoldStates.Find((IInputBehaviorHoldState state) => state.Action == action.Value);
		bool flag = inputBehaviorHoldState != null && (!condition.bRequirePressInNotify || inputBehaviorHoldState.PressedInNotify) && (condition.HoldDuration <= 0f || inputBehaviorHoldState.HoldDuration >= (double)condition.HoldDuration) && context.HoldTriggeredPressIds[conditionIndex] != inputBehaviorHoldState.PressId;
		if (flag)
		{
			context.PendingHoldConsumptions.Add(new IPendingHoldConsumption
			{
				ConditionIndex = conditionIndex,
				PressId = inputBehaviorHoldState.PressId
			});
		}
		return flag;
	}

	// Token: 0x06018D3B RID: 101691 RVA: 0x00789DDC File Offset: 0x00787FDC
	private static bool IsReleaseTimeValid(SInputBehaviorCondition condition, double elapsedTime)
	{
		bool flag = condition.MinReleaseTime <= 0f || elapsedTime >= (double)condition.MinReleaseTime;
		bool flag2 = condition.MaxReleaseTime <= condition.MinReleaseTime || elapsedTime <= (double)condition.MaxReleaseTime;
		return flag && flag2;
	}

	// Token: 0x06018D3C RID: 101692 RVA: 0x00789E28 File Offset: 0x00788028
	private static bool ConditionTag(SInputBehaviorCondition condition, IInputBehaviorParam param)
	{
		BaseTagComponent component = param.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return false;
		}
		List<int> tagIds = GameplayTagUtils.ConvertFromUeContainer(condition.TagsToCheck);
		bool flag = condition.bAnyTag ? component.HasAnyTag(tagIds) : component.HasAllTag(tagIds);
		if (!condition.bReverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x06018D3D RID: 101693 RVA: 0x00789E7C File Offset: 0x0078807C
	private static bool ConditionAttribute(SInputBehaviorCondition condition, IInputBehaviorParam param)
	{
		BaseAttributeComponent component = param.Entity.GetComponent<BaseAttributeComponent>();
		if (component == null || condition.ComparisonLogic == ESkillBehaviorComparisonLogic.Range)
		{
			return false;
		}
		float currentValue = component.GetCurrentValue((EAttributeType)condition.AttributeId1);
		float num = (condition.AttributeId2 > 0) ? component.GetCurrentValue((EAttributeType)condition.AttributeId2) : 0f;
		bool flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, currentValue, condition.ComparisonValue + num * (float)condition.AttributeRate * 0.0001f, 0f, 0f);
		if (!condition.bReverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x06018D3E RID: 101694 RVA: 0x00789F14 File Offset: 0x00788114
	private static bool ConditionTarget(SInputBehaviorCondition condition, IInputBehaviorParam param)
	{
		bool flag = param.SkillComponent.SkillTarget != null;
		if (!condition.bReverse)
		{
			return flag;
		}
		return !flag;
	}
}
