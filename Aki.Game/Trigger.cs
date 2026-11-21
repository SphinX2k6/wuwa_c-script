using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Utils;

// Token: 0x02002534 RID: 9524
[NullableContext(2)]
[Nullable(0)]
public abstract class Trigger
{
	// Token: 0x1700247C RID: 9340
	// (get) Token: 0x060178C3 RID: 96451 RVA: 0x006F3CA9 File Offset: 0x006F1EA9
	// (set) Token: 0x060178C4 RID: 96452 RVA: 0x006F3CB1 File Offset: 0x006F1EB1
	public ITriggerConfig Config { get; set; }

	// Token: 0x1700247D RID: 9341
	// (get) Token: 0x060178C5 RID: 96453 RVA: 0x006F3CBA File Offset: 0x006F1EBA
	// (set) Token: 0x060178C6 RID: 96454 RVA: 0x006F3CC2 File Offset: 0x006F1EC2
	public int Handle { get; set; }

	// Token: 0x1700247E RID: 9342
	// (get) Token: 0x060178C7 RID: 96455 RVA: 0x006F3CCB File Offset: 0x006F1ECB
	// (set) Token: 0x060178C8 RID: 96456 RVA: 0x006F3CD3 File Offset: 0x006F1ED3
	public CharacterTriggerComponent OwnerTriggerComp { get; set; }

	// Token: 0x1700247F RID: 9343
	// (get) Token: 0x060178C9 RID: 96457 RVA: 0x006F3CDC File Offset: 0x006F1EDC
	// (set) Token: 0x060178CA RID: 96458 RVA: 0x006F3CE4 File Offset: 0x006F1EE4
	public TTriggerCallback Callback { get; set; }

	// Token: 0x17002480 RID: 9344
	// (get) Token: 0x060178CB RID: 96459 RVA: 0x006F3CED File Offset: 0x006F1EED
	// (set) Token: 0x060178CC RID: 96460 RVA: 0x006F3CF5 File Offset: 0x006F1EF5
	public TTriggerChecker Checker { get; set; }

	// Token: 0x060178CD RID: 96461 RVA: 0x006F3D00 File Offset: 0x006F1F00
	public Trigger(ITriggerConfig config, int handle, CharacterTriggerComponent ownerTriggerComp, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> functions, TTriggerCallback callback, TTriggerChecker checker)
	{
		if (config == null)
		{
			throw new Exception("找不到对应的Trigger配置");
		}
		this.Config = config;
		this.Handle = handle;
		this.OwnerTriggerComp = ownerTriggerComp;
		this.Callback = callback;
		this.Checker = checker;
		ETriggerEvent triggerType;
		if (!Enum.TryParse<ETriggerEvent>((config.Type == "temp_hittrigger1.0") ? "temp_hittrigger1_0" : config.Type, out triggerType))
		{
			throw new Exception("找不到对应的Trigger触发器类型");
		}
		this.TriggerType = triggerType;
		this.ExecuteType = config.ExecuteType;
		this.LastFormulaResult = false;
		string formula = config.Formula;
		Dictionary<string, Func<TFormulaValue[], TFormulaValue>> builtinFunctions = new Dictionary<string, Func<TFormulaValue[], TFormulaValue>>(functions);
		this.Formula = new Formula(formula).SetBuiltinFunctions(builtinFunctions).AddBuiltinFunction("Accumulate", delegate(TFormulaValue[] args)
		{
			float num = (float)args[0];
			float num2 = (float)args[1];
			if (args.Length >= 3 && !(bool)args[2])
			{
				return TFormulaValue.FromBool(false);
			}
			this.accumulateValue += (double)num;
			if (this.accumulateValue >= (double)num2)
			{
				this.accumulateValue = 0.0;
				return TFormulaValue.FromBool(true);
			}
			return TFormulaValue.FromBool(false);
		}).SetDefaultParams(config.Params).SetDefaultParam("Owner", TFormulaValue.FromEntity((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null));
	}

	// Token: 0x060178CE RID: 96462 RVA: 0x006F3DF8 File Offset: 0x006F1FF8
	private static TFormulaValue FromJsonElement(JsonElement json)
	{
		switch (json.ValueKind)
		{
		case JsonValueKind.String:
			return TFormulaValue.FromString(json.GetString() ?? string.Empty);
		case JsonValueKind.Number:
		{
			int value;
			if (json.TryGetInt32(out value))
			{
				return TFormulaValue.FromInt(value);
			}
			long value2;
			if (json.TryGetInt64(out value2))
			{
				return TFormulaValue.FromLong(value2);
			}
			float value3;
			if (json.TryGetSingle(out value3))
			{
				return TFormulaValue.FromFloat(value3);
			}
			break;
		}
		case JsonValueKind.True:
		case JsonValueKind.False:
			return TFormulaValue.FromBool(json.GetBoolean());
		}
		return default(TFormulaValue);
	}

	// Token: 0x060178CF RID: 96463 RVA: 0x006F3E8A File Offset: 0x006F208A
	public bool CanContinuousTrigger()
	{
		return this.ExecuteType != EExecuteType.DisableContinuousTrigger;
	}

	// Token: 0x060178D0 RID: 96464 RVA: 0x006F3E98 File Offset: 0x006F2098
	public unsafe void EvaluateAndExecute([Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, TFormulaValue> extraParams = null)
	{
		bool flag;
		if (!this.Formula.Evaluate(extraParams, null).TryGetBool(out flag) || !flag)
		{
			this.LastFormulaResult = false;
			return;
		}
		if (!this.CanContinuousTrigger() && this.LastFormulaResult)
		{
			return;
		}
		this.LastFormulaResult = true;
		try
		{
			if (this.TryLock())
			{
				TTriggerCallback callback = this.Callback;
				if (callback != null)
				{
					callback(this.Formula.Params, extraParams);
				}
				this.Unlock();
			}
			else
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.PassiveSkill;
				CharacterTriggerComponent ownerTriggerComp = this.OwnerTriggerComp;
				Entity entity = (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null;
				string message = "被动技能不能在同一个调用栈中递归触发";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("触发器", this.GetDebugName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Formula", this.Formula.GetTotalFormulaString());
				instance.Error(flag2, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		catch (Exception ex)
		{
			this.Unlock();
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.PassiveSkill;
			CharacterTriggerComponent ownerTriggerComp2 = this.OwnerTriggerComp;
			Entity entity2 = (ownerTriggerComp2 != null) ? ownerTriggerComp2.Entity : null;
			string message2 = "触发器回调函数执行错误";
			Exception e = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("触发器", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Formula", this.Formula.GetTotalFormulaString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("错误信息", ex.Message);
			instance2.ErrorWithStack(flag3, entity2, message2, e, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
	}

	// Token: 0x060178D1 RID: 96465 RVA: 0x006F4034 File Offset: 0x006F2234
	protected bool TryLock()
	{
		if (this.IterationLock == Time.Instance.Frame)
		{
			return false;
		}
		this.IterationLock = Time.Instance.Frame;
		return true;
	}

	// Token: 0x060178D2 RID: 96466 RVA: 0x006F405B File Offset: 0x006F225B
	protected void Unlock()
	{
		this.IterationLock = -1;
	}

	// Token: 0x060178D3 RID: 96467 RVA: 0x006F4064 File Offset: 0x006F2264
	[NullableContext(1)]
	public virtual void OnInitParams(string[] triggerParams)
	{
	}

	// Token: 0x060178D4 RID: 96468 RVA: 0x006F4066 File Offset: 0x006F2266
	public void SetActive(bool isActive)
	{
		if (this.IsActive == isActive)
		{
			return;
		}
		this.IsActive = isActive;
		if (isActive)
		{
			this.OnActive();
			return;
		}
		this.OnInactive();
	}

	// Token: 0x060178D5 RID: 96469
	protected abstract void OnActive();

	// Token: 0x060178D6 RID: 96470
	protected abstract void OnInactive();

	// Token: 0x060178D7 RID: 96471 RVA: 0x006F4089 File Offset: 0x006F2289
	public virtual void Destroy()
	{
		this.SetActive(false);
		Formula formula = this.Formula;
		if (formula != null)
		{
			formula.Dispose();
		}
		this.OwnerTriggerComp = null;
		this.Config = null;
		this.ExecuteType = EExecuteType.Default;
		this.LastFormulaResult = false;
		this.Callback = null;
	}

	// Token: 0x060178D8 RID: 96472 RVA: 0x006F40C6 File Offset: 0x006F22C6
	[NullableContext(1)]
	public string GetLastFormulaResult()
	{
		return string.Empty;
	}

	// Token: 0x060178D9 RID: 96473 RVA: 0x006F40CD File Offset: 0x006F22CD
	[NullableContext(1)]
	[Conditional("DEBUG")]
	public void SetDebugName(string name)
	{
	}

	// Token: 0x060178DA RID: 96474 RVA: 0x006F40CF File Offset: 0x006F22CF
	[NullableContext(1)]
	public virtual string GetDebugName()
	{
		return string.Empty;
	}

	// Token: 0x060178DB RID: 96475 RVA: 0x006F40D6 File Offset: 0x006F22D6
	[NullableContext(1)]
	public virtual string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x060178DC RID: 96476 RVA: 0x006F40DD File Offset: 0x006F22DD
	[NullableContext(1)]
	protected static string GetDamageCalculationTypeText(ECalculationType calculationType)
	{
		switch (calculationType)
		{
		case ECalculationType.Hurt:
			return "伤害";
		case ECalculationType.Heal:
			return "治疗";
		case ECalculationType.Cost:
			return "Cost";
		default:
			return calculationType.ToString();
		}
	}

	// Token: 0x060178DD RID: 96477 RVA: 0x006F4112 File Offset: 0x006F2312
	public string GetDebugFormulaString()
	{
		return null;
	}

	// Token: 0x060178DE RID: 96478 RVA: 0x006F4118 File Offset: 0x006F2318
	public static Trigger Create(ETriggerEvent triggerType, ITriggerConfig config, int handle, CharacterTriggerComponent ownerTriggerComp, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> functions, TTriggerCallback callback, TTriggerChecker checker)
	{
		switch (triggerType)
		{
		case ETriggerEvent.BeHitTrigger:
			return new BeHitTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.HitTrigger:
			return new HitTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.AttributeChangedTrigger:
			return new AttributeChangedTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.TeamAttributeChangeTrigger:
			return new TeamAttributeChangedTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.TagTrigger:
			return new TagTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.LimitDodgeTrigger:
			return new LimitDodgeTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.SkillTrigger:
			return new SkillTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.DamageTrigger:
			return new DamageTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.BeDamageTrigger:
			return new BeDamageTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.GameplayEventTrigger:
			return new GameplayEventTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.temp_hittrigger1_0:
			return new HitTriggerIncludingVision(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.GlobalDamageTrigger:
			return new GlobalDamageTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.QteGoBattleTrigger:
			return new QteGoBattleTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.QteGoDownTrigger:
			return new QteGoDownTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.DeathTrigger:
			return new DeathTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.KillTrigger:
			return new KillTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.BuffInstigatorTrigger:
			return new BuffInstigatorTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.BuffVictimTrigger:
			return new BuffVictimTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.TagStackTrigger:
			return new TagStackTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.VisionTrigger:
			return new VisionTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.DamageIdTrigger:
			return new DamageIdTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.BuffAddFailureTrigger:
			return new BuffAddFailureTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.ShieldTrigger:
			return new ShieldTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.ShowTargetTrigger:
			return new ShowTargetTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.RegionDetectTrigger:
			return new RegionDetectTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.BreakWeaknessTrigger:
			return new BreakWeaknessTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.EnterBattleTrigger:
			return new EnterBattleTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.LeaveBattleTrigger:
			return new LeaveBattleTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.ClearShowTargetTrigger:
			return new ClearShowTargetTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.BuffStackInstigatorTrigger:
			return new BuffStackInstigatorTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.SquadAttributeChangeTrigger:
			return new SquadAttributeChangeTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		case ETriggerEvent.BuffStackMaxTrigger:
			return new BuffStackMaxTrigger(config, handle, ownerTriggerComp, functions, callback, checker);
		}
		return null;
	}

	// Token: 0x0400C86B RID: 51307
	[Nullable(1)]
	private readonly Formula Formula;

	// Token: 0x0400C86C RID: 51308
	protected ETriggerEvent TriggerType;

	// Token: 0x0400C86D RID: 51309
	private bool IsActive;

	// Token: 0x0400C86E RID: 51310
	protected EExecuteType ExecuteType;

	// Token: 0x0400C86F RID: 51311
	private bool LastFormulaResult;

	// Token: 0x0400C870 RID: 51312
	private double accumulateValue;

	// Token: 0x0400C876 RID: 51318
	public int IterationLock = -1;

	// Token: 0x0400C877 RID: 51319
	protected string DebugName;
}
