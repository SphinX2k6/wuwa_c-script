using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200318E RID: 12686
[NullableContext(1)]
[Nullable(0)]
public abstract class SpecialSkillBase
{
	// Token: 0x0601B4F2 RID: 111858 RVA: 0x00774B5A File Offset: 0x00772D5A
	protected SpecialSkillBase(CharacterSpecialSkillComponent specialSkillComponent)
	{
		this.SpecialSkillComponent = specialSkillComponent;
	}

	// Token: 0x0601B4F3 RID: 111859 RVA: 0x00774B95 File Offset: 0x00772D95
	public static T Spawn<[Nullable(0)] T>(CharacterSpecialSkillComponent specialSkillComponent) where T : SpecialSkillBase
	{
		return (T)((object)Activator.CreateInstance(typeof(T), new object[]
		{
			specialSkillComponent
		}));
	}

	// Token: 0x0601B4F4 RID: 111860 RVA: 0x00774BB5 File Offset: 0x00772DB5
	public virtual void OnStart()
	{
	}

	// Token: 0x0601B4F5 RID: 111861 RVA: 0x00774BB7 File Offset: 0x00772DB7
	public virtual void OnActivate()
	{
	}

	// Token: 0x0601B4F6 RID: 111862 RVA: 0x00774BB9 File Offset: 0x00772DB9
	public virtual void OnEnd()
	{
	}

	// Token: 0x0601B4F7 RID: 111863 RVA: 0x00774BBC File Offset: 0x00772DBC
	public virtual void OnTick(float delta)
	{
		if (this.ActiveCodeSkills.Count == 0)
		{
			return;
		}
		foreach (KeyValuePair<int, CodeSkillBase> keyValuePair in this.ActiveCodeSkills.ToArray<KeyValuePair<int, CodeSkillBase>>())
		{
			int num;
			CodeSkillBase codeSkillBase;
			keyValuePair.Deconstruct(out num, out codeSkillBase);
			int skillId = num;
			CodeSkillBase codeSkillBase2 = codeSkillBase;
			Skill skill = this.GetSkillComp().GetSkill(skillId);
			if (skill != null)
			{
				codeSkillBase2.OnTick(delta, skill);
			}
		}
	}

	// Token: 0x0601B4F8 RID: 111864 RVA: 0x00774C26 File Offset: 0x00772E26
	public virtual void OnEnable()
	{
	}

	// Token: 0x0601B4F9 RID: 111865 RVA: 0x00774C28 File Offset: 0x00772E28
	public virtual void OnDisable()
	{
	}

	// Token: 0x0601B4FA RID: 111866 RVA: 0x00774C2A File Offset: 0x00772E2A
	public static void SetOptimizeEnable(bool enable)
	{
	}

	// Token: 0x0601B4FB RID: 111867 RVA: 0x00774C2C File Offset: 0x00772E2C
	protected void RegisterCodeFunction(string functionName, CodeFunctionBase codeFunction)
	{
		if (string.IsNullOrEmpty(functionName))
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, this.GetOwnerEntity(), "CodeFunction注册名为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CodeFunctions.ContainsKey(functionName))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity ownerEntity = this.GetOwnerEntity();
			string message = "CodeFunction重复注册";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionName", functionName);
			instance.Error(flag, ownerEntity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.CodeFunctions[functionName] = codeFunction;
	}

	// Token: 0x0601B4FC RID: 111868 RVA: 0x00774CA8 File Offset: 0x00772EA8
	public unsafe FKuroCodeFunctionResult ExecuteCodeFunction(string functionName, FKuroCodeFunctionPayload payload)
	{
		if (string.IsNullOrEmpty(functionName))
		{
			return CodeFunctionBase.CreateCodeFunctionFailureResult("FunctionName不能为空");
		}
		CodeFunctionBase codeFunctionBase;
		if (!this.CodeFunctions.TryGetValue(functionName, out codeFunctionBase))
		{
			return CodeFunctionBase.CreateCodeFunctionFailureResult("未注册CodeFunction：" + functionName);
		}
		FKuroCodeFunctionResult result;
		try
		{
			result = codeFunctionBase.Execute(payload);
		}
		catch (Exception ex)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity ownerEntity = this.GetOwnerEntity();
			string message = "CodeFunction执行异常";
			Exception e = ex;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionName", functionName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(flag, ownerEntity, message, e, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			result = CodeFunctionBase.CreateCodeFunctionFailureResult("CodeFunction执行异常：" + functionName + "，" + ex.Message);
		}
		return result;
	}

	// Token: 0x0601B4FD RID: 111869 RVA: 0x00774D80 File Offset: 0x00772F80
	protected void RegisterCodeAnimNotify(string eventName, CodeAnimNotifyBase codeAnimNotify)
	{
		if (string.IsNullOrEmpty(eventName))
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, this.GetOwnerEntity(), "CodeAnimNotify注册名为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CodeAnimNotifies.ContainsKey(eventName))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity ownerEntity = this.GetOwnerEntity();
			string message = "CodeAnimNotify重复注册";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventName", eventName);
			instance.Error(flag, ownerEntity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.CodeAnimNotifies[eventName] = codeAnimNotify;
	}

	// Token: 0x0601B4FE RID: 111870 RVA: 0x00774DFC File Offset: 0x00772FFC
	public void DispatchCodeAnimNotify(string eventName, FKuroCodeFunctionPayload payload)
	{
		this.InvokeCodeAnimNotify(eventName, "OnNotify", delegate(CodeAnimNotifyBase codeAnimNotify)
		{
			codeAnimNotify.OnNotify(payload);
		});
	}

	// Token: 0x0601B4FF RID: 111871 RVA: 0x00774E30 File Offset: 0x00773030
	public void DispatchCodeAnimNotifyBegin(string eventName, float totalDuration, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		this.InvokeCodeAnimNotify(eventName, "OnNotifyBegin", delegate(CodeAnimNotifyBase codeAnimNotify)
		{
			codeAnimNotify.OnNotifyBegin(totalDuration, payload, animation);
		});
	}

	// Token: 0x0601B500 RID: 111872 RVA: 0x00774E74 File Offset: 0x00773074
	public void DispatchCodeAnimNotifyTick(string eventName, float delta, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		this.InvokeCodeAnimNotify(eventName, "OnNotifyTick", delegate(CodeAnimNotifyBase codeAnimNotify)
		{
			codeAnimNotify.OnNotifyTick(delta, payload, animation);
		});
	}

	// Token: 0x0601B501 RID: 111873 RVA: 0x00774EB8 File Offset: 0x007730B8
	public void DispatchCodeAnimNotifyEnd(string eventName, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		this.InvokeCodeAnimNotify(eventName, "OnNotifyEnd", delegate(CodeAnimNotifyBase codeAnimNotify)
		{
			codeAnimNotify.OnNotifyEnd(payload, animation);
		});
	}

	// Token: 0x0601B502 RID: 111874 RVA: 0x00774EF4 File Offset: 0x007730F4
	private unsafe void InvokeCodeAnimNotify(string eventName, string phase, Action<CodeAnimNotifyBase> invoke)
	{
		if (string.IsNullOrEmpty(eventName))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity ownerEntity = this.GetOwnerEntity();
			string message = "CodeAnimNotify事件名为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("phase", phase);
			instance.Error(flag, ownerEntity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CodeAnimNotifyBase obj;
		if (!this.CodeAnimNotifies.TryGetValue(eventName, out obj))
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
			Entity ownerEntity2 = this.GetOwnerEntity();
			string message2 = "未注册CodeAnimNotify";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("eventName", eventName);
			instance2.Error(flag2, ownerEntity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		try
		{
			invoke(obj);
		}
		catch (Exception ex)
		{
			CombatLog instance3 = CombatLog.Instance;
			CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Skill;
			Entity ownerEntity3 = this.GetOwnerEntity();
			string message3 = "CodeAnimNotify执行异常";
			Exception e = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("eventName", eventName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("phase", phase);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance3.ErrorWithStack(flag3, ownerEntity3, message3, e, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x0601B503 RID: 111875 RVA: 0x00775004 File Offset: 0x00773204
	public Entity GetOwnerEntity()
	{
		return this.SpecialSkillComponent.Entity;
	}

	// Token: 0x0601B504 RID: 111876 RVA: 0x00775011 File Offset: 0x00773211
	public BaseSkillComponent GetSkillComp()
	{
		if (this.SkillCompCache == null)
		{
			this.SkillCompCache = this.SpecialSkillComponent.Entity.GetComponent<BaseSkillComponent>();
		}
		return this.SkillCompCache;
	}

	// Token: 0x0601B505 RID: 111877 RVA: 0x00775037 File Offset: 0x00773237
	protected void RegisterCodeSkill(int skillId, CodeSkillBase codeSkill)
	{
		this.CodeSkills[skillId] = codeSkill;
	}

	// Token: 0x0601B506 RID: 111878 RVA: 0x00775048 File Offset: 0x00773248
	public bool OnCodeSkillBegin(Skill skill)
	{
		CodeSkillBase codeSkillBase;
		if (!this.CodeSkills.TryGetValue(skill.SkillId, out codeSkillBase))
		{
			return false;
		}
		this.ActiveCodeSkills[skill.SkillId] = codeSkillBase;
		codeSkillBase.OnBegin(skill);
		return true;
	}

	// Token: 0x0601B507 RID: 111879 RVA: 0x00775088 File Offset: 0x00773288
	public void OnCodeSkillEnd(Skill skill)
	{
		CodeSkillBase codeSkillBase;
		if (!this.ActiveCodeSkills.Remove(skill.SkillId, out codeSkillBase))
		{
			return;
		}
		codeSkillBase.OnEnd(skill);
	}

	// Token: 0x0601B508 RID: 111880 RVA: 0x007750B4 File Offset: 0x007732B4
	public void OnCodeSkillInterrupt(Skill skill)
	{
		CodeSkillBase codeSkillBase;
		if (this.ActiveCodeSkills.TryGetValue(skill.SkillId, out codeSkillBase))
		{
			codeSkillBase.OnInterrupt(skill);
		}
	}

	// Token: 0x0601B509 RID: 111881 RVA: 0x007750DD File Offset: 0x007732DD
	public virtual void EndAddMoveByInputDirect()
	{
	}

	// Token: 0x0400D580 RID: 54656
	protected readonly CharacterSpecialSkillComponent SpecialSkillComponent;

	// Token: 0x0400D581 RID: 54657
	private readonly Dictionary<string, CodeFunctionBase> CodeFunctions = new Dictionary<string, CodeFunctionBase>();

	// Token: 0x0400D582 RID: 54658
	private readonly Dictionary<int, CodeSkillBase> CodeSkills = new Dictionary<int, CodeSkillBase>();

	// Token: 0x0400D583 RID: 54659
	private readonly Dictionary<string, CodeAnimNotifyBase> CodeAnimNotifies = new Dictionary<string, CodeAnimNotifyBase>();

	// Token: 0x0400D584 RID: 54660
	private readonly Dictionary<int, CodeSkillBase> ActiveCodeSkills = new Dictionary<int, CodeSkillBase>();

	// Token: 0x0400D585 RID: 54661
	[Nullable(2)]
	private BaseSkillComponent SkillCompCache;
}
