using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x02003152 RID: 12626
[NullableContext(1)]
[Nullable(0)]
public class SkillBehaviorCondition
{
	// Token: 0x0601B2CE RID: 111310 RVA: 0x00767394 File Offset: 0x00765594
	public unsafe static bool SatisfyGroup(TArray<SSkillBehaviorCondition> skillBehaviorConditionGroup, string skillBehaviorConditionFormula, IBeginSkillBehaviorConditionParam param)
	{
		List<bool> list = new List<bool>();
		for (int i = 0; i < skillBehaviorConditionGroup.Num(); i++)
		{
			bool flag = SkillBehaviorCondition.Satisfy(skillBehaviorConditionGroup.Get(i), param);
			if (!string.IsNullOrEmpty(skillBehaviorConditionFormula))
			{
				list.Add(flag);
			}
			else if (!flag)
			{
				return false;
			}
		}
		if (list.Count > 0)
		{
			try
			{
				ILogicalStructure structure = new Parser(skillBehaviorConditionFormula).Parse();
				return new ConditionArray(list.ToArray(), structure).Evaluate();
			}
			catch (Exception ex)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
				Entity entity = param.Entity;
				string message = "SkillBehaviorCondition.SatisfyGroup技能行为条件公式解析异常";
				Exception e = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "技能Id";
				Skill skill = param.Skill;
				ptr = new ValueTuple<string, object>(item, (skill != null) ? skill.SkillId : 0);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item2 = "技能名";
				Skill skill2 = param.Skill;
				ptr2 = new ValueTuple<string, object>(item2, ((skill2 != null) ? skill2.SkillName : null) ?? string.Empty);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("formula", skillBehaviorConditionFormula);
				instance.ErrorWithStack(flag2, entity, message, e, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			return true;
		}
		return true;
	}

	// Token: 0x0601B2CF RID: 111311 RVA: 0x007674CC File Offset: 0x007656CC
	public unsafe static bool Satisfy(SSkillBehaviorCondition skillBehaviorCondition, IBeginSkillBehaviorConditionParam param)
	{
		bool flag = false;
		string item = "未知条件类型";
		switch (skillBehaviorCondition.ConditionType)
		{
		case ESkillBehaviorConditionType.是否有技能目标:
			item = "是否有技能目标";
			flag = SkillBehaviorCondition.ConditionTarget(skillBehaviorCondition, param);
			break;
		case ESkillBehaviorConditionType.与技能目标锁定点距离:
			item = "与技能目标锁定点距离";
			flag = SkillBehaviorCondition.ConditionDistance(skillBehaviorCondition, param);
			break;
		case ESkillBehaviorConditionType.与技能目标锁定点角度:
			item = "与技能目标锁定点角度";
			flag = SkillBehaviorCondition.ConditionAngle(skillBehaviorCondition, param);
			break;
		case ESkillBehaviorConditionType.施法者标签检测:
			item = "施法者标签检测";
			flag = SkillBehaviorCondition.ConditionTag(skillBehaviorCondition, param);
			break;
		case ESkillBehaviorConditionType.施法者属性检测:
			item = "施法者属性检测";
			flag = SkillBehaviorCondition.ConditionAttribute(skillBehaviorCondition, param);
			break;
		case ESkillBehaviorConditionType.空中高度检测:
			item = "空中高度检测";
			flag = SkillBehaviorCondition.ConditionHeightAboveGround(skillBehaviorCondition, param);
			break;
		case ESkillBehaviorConditionType.与技能目标锁定点高度:
			item = "与技能目标锁定点高度";
			flag = SkillBehaviorCondition.ConditionHeight(skillBehaviorCondition, param);
			break;
		case ESkillBehaviorConditionType.是否有技能目标和是否战斗单位:
			item = "是否有技能目标和是否战斗单位";
			flag = SkillBehaviorCondition.ConditionTargetOnlyCombat(skillBehaviorCondition, param);
			break;
		case ESkillBehaviorConditionType.是否有摇杆输入:
			item = "是否有摇杆输入";
			flag = SkillBehaviorCondition.ConditionHasAxisInput(skillBehaviorCondition, param);
			break;
		}
		CombatLog.ELogType logType = CombatLog.ELogType.Debug;
		ESkillLogType skillLogType = ESkillLogType.SkillBehavior;
		Entity entity = param.Entity;
		string message = "SkillBehaviorCondition.Satisfy技能行为条件判断";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item2 = "技能Id";
		Skill skill = param.Skill;
		ptr = new ValueTuple<string, object>(item2, (skill != null) ? skill.SkillId : 0);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item3 = "技能名";
		Skill skill2 = param.Skill;
		ptr2 = new ValueTuple<string, object>(item3, ((skill2 != null) ? skill2.SkillName : null) ?? string.Empty);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("条件", item);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("结果", flag);
		SkillUtils.Log(logType, skillLogType, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		return flag;
	}

	// Token: 0x0601B2D0 RID: 111312 RVA: 0x00767664 File Offset: 0x00765864
	private static bool ConditionTarget(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		bool flag = false;
		BaseSkillComponent skillComponent = param.SkillComponent;
		if (((skillComponent != null) ? skillComponent.SkillTarget : null) != null)
		{
			flag = true;
		}
		if (!condition.Reverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x0601B2D1 RID: 111313 RVA: 0x00767698 File Offset: 0x00765898
	private static bool ConditionDistance(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		bool flag = false;
		BaseSkillComponent skillComponent = param.SkillComponent;
		if (((skillComponent != null) ? skillComponent.SkillTarget : null) != null)
		{
			global::Vector actorLocationProxy = param.Entity.GetComponent<BaseActorComponent>().ActorLocationProxy;
			global::Vector v = global::Vector.Create(param.SkillComponent.GetTargetTransform().GetLocation());
			float lValue = condition.IgnoreZ ? ((float)global::Vector.Dist2D(actorLocationProxy, v)) : ((float)global::Vector.Distance(actorLocationProxy, v));
			flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, lValue, condition.Value, condition.RangeL, condition.RangeR);
		}
		if (!condition.Reverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x0601B2D2 RID: 111314 RVA: 0x00767738 File Offset: 0x00765938
	private static bool ConditionAngle(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		bool flag = false;
		BaseSkillComponent skillComponent = param.SkillComponent;
		if (((skillComponent != null) ? skillComponent.SkillTarget : null) != null)
		{
			BaseActorComponent component = param.Entity.GetComponent<BaseActorComponent>();
			global::Vector actorLocationProxy = component.ActorLocationProxy;
			global::Vector vector = global::Vector.Create(param.SkillComponent.GetTargetTransform().GetLocation());
			global::Vector vector2 = global::Vector.Create();
			vector.Subtraction(actorLocationProxy, vector2);
			if (condition.IgnoreZ)
			{
				vector2.Z = 0.0;
			}
			vector2.Normalize(9.99999993922529E-09);
			float lValue = condition.Sign ? ((float)MathUtils.Instance.SignedAngleOnPlaneDeg(component.ActorForwardProxy, vector2, global::Vector.UpVectorDouble)) : ((float)MathUtils.Instance.GetAngleByVectorDot(component.ActorForwardProxy, vector2));
			flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, lValue, condition.Value, condition.RangeL, condition.RangeR);
		}
		if (!condition.Reverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x0601B2D3 RID: 111315 RVA: 0x00767834 File Offset: 0x00765A34
	private static bool ConditionTag(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		BaseTagComponent component = param.Entity.GetComponent<BaseTagComponent>();
		bool flag = condition.AnyTag ? component.HasAnyTag(GameplayTagUtils.ConvertFromUeContainer(condition.TagToCheck)) : component.HasAllTag(GameplayTagUtils.ConvertFromUeContainer(condition.TagToCheck));
		if (!condition.Reverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x0601B2D4 RID: 111316 RVA: 0x0076788C File Offset: 0x00765A8C
	private static bool ConditionAttribute(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		BaseAttributeComponent component = param.Entity.GetComponent<BaseAttributeComponent>();
		float currentValue = component.GetCurrentValue((EAttributeType)condition.AttributeId1);
		float num = (condition.AttributeId2 > 0) ? component.GetCurrentValue((EAttributeType)condition.AttributeId2) : 0f;
		bool flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, currentValue, condition.Value + num * (float)condition.AttributeRate * 0.0001f, condition.RangeL, condition.RangeR);
		if (!condition.Reverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x0601B2D5 RID: 111317 RVA: 0x00767914 File Offset: 0x00765B14
	private static bool ConditionHeightAboveGround(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		float heightAboveGround = param.Entity.GetComponent<CharacterMoveComponent>().GetHeightAboveGround(500f);
		bool flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, heightAboveGround, condition.Value, condition.RangeL, condition.RangeR);
		if (!condition.Reverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x0601B2D6 RID: 111318 RVA: 0x0076796C File Offset: 0x00765B6C
	private static bool ConditionHeight(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		bool flag = false;
		BaseSkillComponent skillComponent = param.SkillComponent;
		if (((skillComponent != null) ? skillComponent.SkillTarget : null) != null)
		{
			global::Vector actorLocationProxy = param.Entity.GetComponent<BaseActorComponent>().ActorLocationProxy;
			global::Vector vector = global::Vector.Create(param.SkillComponent.GetTargetTransform().GetLocation());
			float lValue = (float)(actorLocationProxy.Z - vector.Z);
			flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, lValue, condition.Value, condition.RangeL, condition.RangeR);
		}
		if (!condition.Reverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x0601B2D7 RID: 111319 RVA: 0x00767A00 File Offset: 0x00765C00
	private static bool ConditionTargetOnlyCombat(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		bool flag = false;
		BaseSkillComponent skillComponent = param.SkillComponent;
		if (SkillUtils.IsTsActor((skillComponent != null) ? skillComponent.SkillTarget : null))
		{
			flag = true;
		}
		if (!condition.Reverse)
		{
			return flag;
		}
		return !flag;
	}

	// Token: 0x0601B2D8 RID: 111320 RVA: 0x00767A38 File Offset: 0x00765C38
	private static bool ConditionHasAxisInput(SSkillBehaviorCondition condition, IBeginSkillBehaviorConditionParam param)
	{
		bool flag = false;
		Dictionary<EInputAxis, float> axisValues = InputModel.Instance.GetAxisValues();
		if (axisValues != null)
		{
			float num;
			bool flag2 = axisValues.TryGetValue(EInputAxis.MoveForward, out num);
			float num2;
			bool flag3 = axisValues.TryGetValue(EInputAxis.MoveRight, out num2);
			if ((flag2 && num != 0f) || (flag3 && num2 != 0f))
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
}
