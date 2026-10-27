using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Utils;

// Token: 0x02002FDF RID: 12255
[NullableContext(2)]
[Nullable(0)]
public abstract class Trigger
{
	// Token: 0x170023BA RID: 9146
	// (get) Token: 0x06019F8F RID: 106383 RVA: 0x006CBE21 File Offset: 0x006CA021
	// (set) Token: 0x06019F90 RID: 106384 RVA: 0x006CBE29 File Offset: 0x006CA029
	public ITriggerConfig Config { get; set; }

	// Token: 0x170023BB RID: 9147
	// (get) Token: 0x06019F91 RID: 106385 RVA: 0x006CBE32 File Offset: 0x006CA032
	// (set) Token: 0x06019F92 RID: 106386 RVA: 0x006CBE3A File Offset: 0x006CA03A
	public int Handle { get; set; }

	// Token: 0x170023BC RID: 9148
	// (get) Token: 0x06019F93 RID: 106387 RVA: 0x006CBE43 File Offset: 0x006CA043
	// (set) Token: 0x06019F94 RID: 106388 RVA: 0x006CBE4B File Offset: 0x006CA04B
	public CharacterTriggerComponent OwnerTriggerComp { get; set; }

	// Token: 0x170023BD RID: 9149
	// (get) Token: 0x06019F95 RID: 106389 RVA: 0x006CBE54 File Offset: 0x006CA054
	// (set) Token: 0x06019F96 RID: 106390 RVA: 0x006CBE5C File Offset: 0x006CA05C
	public TTriggerCallback Callback { get; set; }

	// Token: 0x170023BE RID: 9150
	// (get) Token: 0x06019F97 RID: 106391 RVA: 0x006CBE65 File Offset: 0x006CA065
	// (set) Token: 0x06019F98 RID: 106392 RVA: 0x006CBE6D File Offset: 0x006CA06D
	public TTriggerChecker Checker { get; set; }

	// Token: 0x06019F99 RID: 106393 RVA: 0x006CBE78 File Offset: 0x006CA078
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

	// Token: 0x06019F9A RID: 106394 RVA: 0x006CBF70 File Offset: 0x006CA170
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

	// Token: 0x06019F9B RID: 106395 RVA: 0x006CC002 File Offset: 0x006CA202
	public bool CanContinuousTrigger()
	{
		return this.ExecuteType != EExecuteType.DisableContinuousTrigger;
	}

	// Token: 0x06019F9C RID: 106396 RVA: 0x006CC010 File Offset: 0x006CA210
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

	// Token: 0x06019F9D RID: 106397 RVA: 0x006CC1AC File Offset: 0x006CA3AC
	protected bool TryLock()
	{
		if (this.IterationLock == Time.Instance.Frame)
		{
			return false;
		}
		this.IterationLock = Time.Instance.Frame;
		return true;
	}

	// Token: 0x06019F9E RID: 106398 RVA: 0x006CC1D3 File Offset: 0x006CA3D3
	protected void Unlock()
	{
		this.IterationLock = -1;
	}

	// Token: 0x06019F9F RID: 106399 RVA: 0x006CC1DC File Offset: 0x006CA3DC
	[NullableContext(1)]
	public virtual void OnInitParams(string[] triggerParams)
	{
	}

	// Token: 0x06019FA0 RID: 106400 RVA: 0x006CC1DE File Offset: 0x006CA3DE
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

	// Token: 0x06019FA1 RID: 106401
	protected abstract void OnActive();

	// Token: 0x06019FA2 RID: 106402
	protected abstract void OnInactive();

	// Token: 0x06019FA3 RID: 106403 RVA: 0x006CC201 File Offset: 0x006CA401
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

	// Token: 0x06019FA4 RID: 106404 RVA: 0x006CC23E File Offset: 0x006CA43E
	[NullableContext(1)]
	public string GetLastFormulaResult()
	{
		return string.Empty;
	}

	// Token: 0x06019FA5 RID: 106405 RVA: 0x006CC245 File Offset: 0x006CA445
	[NullableContext(1)]
	[Conditional("DEBUG")]
	public void SetDebugName(string name)
	{
	}

	// Token: 0x06019FA6 RID: 106406 RVA: 0x006CC247 File Offset: 0x006CA447
	[NullableContext(1)]
	public virtual string GetDebugName()
	{
		return string.Empty;
	}

	// Token: 0x06019FA7 RID: 106407 RVA: 0x006CC24E File Offset: 0x006CA44E
	[NullableContext(1)]
	public virtual string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x06019FA8 RID: 106408 RVA: 0x006CC255 File Offset: 0x006CA455
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

	// Token: 0x06019FA9 RID: 106409 RVA: 0x006CC28A File Offset: 0x006CA48A
	public string GetDebugFormulaString()
	{
		return null;
	}

	// Token: 0x06019FAA RID: 106410 RVA: 0x006CC290 File Offset: 0x006CA490
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
		default:
			return null;
		}
	}

	// Token: 0x0400C4A3 RID: 50339
	[Nullable(1)]
	private readonly Formula Formula;

	// Token: 0x0400C4A4 RID: 50340
	protected ETriggerEvent TriggerType;

	// Token: 0x0400C4A5 RID: 50341
	private bool IsActive;

	// Token: 0x0400C4A6 RID: 50342
	protected EExecuteType ExecuteType;

	// Token: 0x0400C4A7 RID: 50343
	private bool LastFormulaResult;

	// Token: 0x0400C4A8 RID: 50344
	private double accumulateValue;

	// Token: 0x0400C4AE RID: 50350
	public int IterationLock = -1;

	// Token: 0x0400C4AF RID: 50351
	protected string DebugName;
}
