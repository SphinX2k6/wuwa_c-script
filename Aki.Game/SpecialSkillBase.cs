using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026FB RID: 9979
[NullableContext(1)]
[Nullable(0)]
public abstract class SpecialSkillBase
{
	// Token: 0x06018FF7 RID: 102391 RVA: 0x0079C4BE File Offset: 0x0079A6BE
	protected SpecialSkillBase(CharacterSpecialSkillComponent specialSkillComponent)
	{
		this.SpecialSkillComponent = specialSkillComponent;
	}

	// Token: 0x06018FF8 RID: 102392 RVA: 0x0079C4F9 File Offset: 0x0079A6F9
	public static T Spawn<[Nullable(0)] T>(CharacterSpecialSkillComponent specialSkillComponent) where T : SpecialSkillBase
	{
		return (T)((object)Activator.CreateInstance(typeof(T), new object[]
		{
			specialSkillComponent
		}));
	}

	// Token: 0x06018FF9 RID: 102393 RVA: 0x0079C519 File Offset: 0x0079A719
	public virtual void OnStart()
	{
	}

	// Token: 0x06018FFA RID: 102394 RVA: 0x0079C51B File Offset: 0x0079A71B
	public virtual void OnActivate()
	{
	}

	// Token: 0x06018FFB RID: 102395 RVA: 0x0079C51D File Offset: 0x0079A71D
	public virtual void OnEnd()
	{
	}

	// Token: 0x06018FFC RID: 102396 RVA: 0x0079C520 File Offset: 0x0079A720
	public virtual void OnTick(float delta)
	{
		if (this.ActiveCodeSkills.Count == 0)
		{
			return;
		}
		KeyValuePair<int, CodeSkillBase>[] array = new KeyValuePair<int, CodeSkillBase>[this.ActiveCodeSkills.Count];
		((ICollection<KeyValuePair<int, CodeSkillBase>>)this.ActiveCodeSkills).CopyTo(array, 0);
		foreach (KeyValuePair<int, CodeSkillBase> keyValuePair in array)
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

	// Token: 0x06018FFD RID: 102397 RVA: 0x0079C5A0 File Offset: 0x0079A7A0
	public virtual void OnEnable()
	{
	}

	// Token: 0x06018FFE RID: 102398 RVA: 0x0079C5A2 File Offset: 0x0079A7A2
	public virtual void OnDisable()
	{
	}

	// Token: 0x06018FFF RID: 102399 RVA: 0x0079C5A4 File Offset: 0x0079A7A4
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

	// Token: 0x06019000 RID: 102400 RVA: 0x0079C620 File Offset: 0x0079A820
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

	// Token: 0x06019001 RID: 102401 RVA: 0x0079C6F8 File Offset: 0x0079A8F8
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

	// Token: 0x06019002 RID: 102402 RVA: 0x0079C774 File Offset: 0x0079A974
	public void DispatchCodeAnimNotify(string eventName, FKuroCodeFunctionPayload payload)
	{
		this.InvokeCodeAnimNotify(eventName, "OnNotify", delegate(CodeAnimNotifyBase codeAnimNotify)
		{
			codeAnimNotify.OnNotify(payload);
		});
	}

	// Token: 0x06019003 RID: 102403 RVA: 0x0079C7A8 File Offset: 0x0079A9A8
	public void DispatchCodeAnimNotifyBegin(string eventName, float totalDuration, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		this.InvokeCodeAnimNotify(eventName, "OnNotifyBegin", delegate(CodeAnimNotifyBase codeAnimNotify)
		{
			codeAnimNotify.OnNotifyBegin(totalDuration, payload, animation);
		});
	}

	// Token: 0x06019004 RID: 102404 RVA: 0x0079C7EC File Offset: 0x0079A9EC
	public void DispatchCodeAnimNotifyTick(string eventName, float delta, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		this.InvokeCodeAnimNotify(eventName, "OnNotifyTick", delegate(CodeAnimNotifyBase codeAnimNotify)
		{
			codeAnimNotify.OnNotifyTick(delta, payload, animation);
		});
	}

	// Token: 0x06019005 RID: 102405 RVA: 0x0079C830 File Offset: 0x0079AA30
	public void DispatchCodeAnimNotifyEnd(string eventName, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		this.InvokeCodeAnimNotify(eventName, "OnNotifyEnd", delegate(CodeAnimNotifyBase codeAnimNotify)
		{
			codeAnimNotify.OnNotifyEnd(payload, animation);
		});
	}

	// Token: 0x06019006 RID: 102406 RVA: 0x0079C86C File Offset: 0x0079AA6C
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

	// Token: 0x06019007 RID: 102407 RVA: 0x0079C97C File Offset: 0x0079AB7C
	public Entity GetOwnerEntity()
	{
		return this.SpecialSkillComponent.Entity;
	}

	// Token: 0x06019008 RID: 102408 RVA: 0x0079C989 File Offset: 0x0079AB89
	public BaseSkillComponent GetSkillComp()
	{
		if (this.SkillCompCache == null)
		{
			this.SkillCompCache = this.SpecialSkillComponent.Entity.GetComponent<BaseSkillComponent>();
		}
		return this.SkillCompCache;
	}

	// Token: 0x06019009 RID: 102409 RVA: 0x0079C9AF File Offset: 0x0079ABAF
	protected void RegisterCodeSkill(int skillId, CodeSkillBase codeSkill)
	{
		this.CodeSkills[skillId] = codeSkill;
	}

	// Token: 0x0601900A RID: 102410 RVA: 0x0079C9C0 File Offset: 0x0079ABC0
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

	// Token: 0x0601900B RID: 102411 RVA: 0x0079CA00 File Offset: 0x0079AC00
	public void OnCodeSkillEnd(Skill skill)
	{
		CodeSkillBase codeSkillBase;
		if (!this.ActiveCodeSkills.Remove(skill.SkillId, out codeSkillBase))
		{
			return;
		}
		codeSkillBase.OnEnd(skill);
	}

	// Token: 0x0601900C RID: 102412 RVA: 0x0079CA2C File Offset: 0x0079AC2C
	public void OnCodeSkillInterrupt(Skill skill)
	{
		CodeSkillBase codeSkillBase;
		if (this.ActiveCodeSkills.TryGetValue(skill.SkillId, out codeSkillBase))
		{
			codeSkillBase.OnInterrupt(skill);
		}
	}

	// Token: 0x0601900D RID: 102413 RVA: 0x0079CA55 File Offset: 0x0079AC55
	public virtual void EndAddMoveByInputDirect()
	{
	}

	// Token: 0x0400D9E3 RID: 55779
	protected readonly CharacterSpecialSkillComponent SpecialSkillComponent;

	// Token: 0x0400D9E4 RID: 55780
	private readonly Dictionary<string, CodeFunctionBase> CodeFunctions = new Dictionary<string, CodeFunctionBase>();

	// Token: 0x0400D9E5 RID: 55781
	private readonly Dictionary<int, CodeSkillBase> CodeSkills = new Dictionary<int, CodeSkillBase>();

	// Token: 0x0400D9E6 RID: 55782
	private readonly Dictionary<string, CodeAnimNotifyBase> CodeAnimNotifies = new Dictionary<string, CodeAnimNotifyBase>();

	// Token: 0x0400D9E7 RID: 55783
	private readonly Dictionary<int, CodeSkillBase> ActiveCodeSkills = new Dictionary<int, CodeSkillBase>();

	// Token: 0x0400D9E8 RID: 55784
	[Nullable(2)]
	private BaseSkillComponent SkillCompCache;
}
