using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020025B0 RID: 9648
[NullableContext(1)]
[Nullable(0)]
public class CharacterFightStateComponent : EntityComponent
{
	// Token: 0x06017EDF RID: 98015 RVA: 0x0072333C File Offset: 0x0072153C
	protected override bool OnStart()
	{
		this.UnifiedComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		return true;
	}

	// Token: 0x06017EE0 RID: 98016 RVA: 0x00723350 File Offset: 0x00721550
	public bool PreSwitchRemoteFightState(int fightState)
	{
		int state = fightState >> 8;
		int num = fightState & 255;
		bool flag = this.CheckSwitchState((ECharacterFightState)state, num, false);
		if (!flag)
		{
			CombatLog.Instance.Info(CombatLog.EDebugModule.FightState, base.Entity, "预切换状态失败，" + this.TargetStateToString(state, num) + "，" + this.CurrentStateToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return flag;
	}

	// Token: 0x06017EE1 RID: 98017 RVA: 0x007233B0 File Offset: 0x007215B0
	public int TrySwitchHitState(EHitAnim hitAnim, bool isLocal = false)
	{
		if (hitAnim == EHitAnim.被破弱)
		{
			return this.TrySwitchState(ECharacterFightState.BeBrokeWeakness, 0, isLocal);
		}
		if (hitAnim == EHitAnim.被弹反)
		{
			return this.TrySwitchState(ECharacterFightState.CounterattackBeHit, 0, isLocal);
		}
		if (isLocal && this.UnifiedComp.PositionState == ECharPositionState.Air)
		{
			return this.TrySwitchState(ECharacterFightState.BeHit, 2, isLocal);
		}
		if (hitAnim - EHitAnim.击飞 <= 1)
		{
			return this.TrySwitchState(ECharacterFightState.BeHit, 2, isLocal);
		}
		if (hitAnim != EHitAnim.压制)
		{
			return this.TrySwitchState(ECharacterFightState.BeHit, 0, isLocal);
		}
		return this.TrySwitchState(ECharacterFightState.BeHit, 1, isLocal);
	}

	// Token: 0x06017EE2 RID: 98018 RVA: 0x00723420 File Offset: 0x00721620
	public int TrySwitchSkillState(int interruptLevel, SSkillInfo skillInfo, bool isLocal = false)
	{
		int num = interruptLevel;
		if (num > 255)
		{
			num = 255;
		}
		if (skillInfo.OverrideType == ESkillOverrideType.覆盖受击)
		{
			return this.TrySwitchState(ECharacterFightState.OverrideBeHitSkill, num, isLocal);
		}
		if (skillInfo.OverrideType == ESkillOverrideType.覆盖弹反)
		{
			return this.TrySwitchState(ECharacterFightState.OverrideCounterattackSkill, num, isLocal);
		}
		if (skillInfo.OverrideType == ESkillOverrideType.覆盖破弱)
		{
			return this.TrySwitchState(ECharacterFightState.OverrideBeBrokeWeaknessSkill, num, isLocal);
		}
		if (skillInfo.OverrideType == ESkillOverrideType.顶级)
		{
			return this.TrySwitchState(ECharacterFightState.SuperSkill, num, isLocal);
		}
		return this.TrySwitchState(ECharacterFightState.NormalSkill, num, isLocal);
	}

	// Token: 0x06017EE3 RID: 98019 RVA: 0x007234BC File Offset: 0x007216BC
	public bool CheckSwitchHitState(EHitAnim hitAnim, bool isLocal = false)
	{
		if (hitAnim == EHitAnim.被破弱)
		{
			return this.CheckSwitchState(ECharacterFightState.BeBrokeWeakness, 0, isLocal);
		}
		if (hitAnim == EHitAnim.被弹反)
		{
			return this.CheckSwitchState(ECharacterFightState.CounterattackBeHit, 0, isLocal);
		}
		if (isLocal && this.UnifiedComp.PositionState == ECharPositionState.Air)
		{
			return this.CheckSwitchState(ECharacterFightState.BeHit, 2, isLocal);
		}
		if (hitAnim - EHitAnim.击飞 <= 1)
		{
			return this.CheckSwitchState(ECharacterFightState.BeHit, 2, isLocal);
		}
		if (hitAnim != EHitAnim.压制)
		{
			return this.CheckSwitchState(ECharacterFightState.BeHit, 0, isLocal);
		}
		return this.CheckSwitchState(ECharacterFightState.BeHit, 1, isLocal);
	}

	// Token: 0x06017EE4 RID: 98020 RVA: 0x0072352C File Offset: 0x0072172C
	public int SwitchHitState(EHitAnim hitAnim, bool isLocal = false)
	{
		if (hitAnim == EHitAnim.被破弱)
		{
			return this.SwitchState(ECharacterFightState.BeBrokeWeakness, 0, isLocal);
		}
		if (hitAnim == EHitAnim.被弹反)
		{
			return this.SwitchState(ECharacterFightState.CounterattackBeHit, 0, isLocal);
		}
		if (isLocal && this.UnifiedComp.PositionState == ECharPositionState.Air)
		{
			return this.SwitchState(ECharacterFightState.BeHit, 2, isLocal);
		}
		if (hitAnim - EHitAnim.击飞 <= 1)
		{
			return this.SwitchState(ECharacterFightState.BeHit, 2, isLocal);
		}
		if (hitAnim != EHitAnim.压制)
		{
			return this.SwitchState(ECharacterFightState.BeHit, 0, isLocal);
		}
		return this.SwitchState(ECharacterFightState.BeHit, 1, isLocal);
	}

	// Token: 0x06017EE5 RID: 98021 RVA: 0x0072359A File Offset: 0x0072179A
	public bool CheckSwitchState(ECharacterFightState state, int subStatePriority, bool isLocal = false)
	{
		if (isLocal)
		{
			return this.CheckSwitchStateInternal(this.CurrentState, this.SubStatePriority, state, subStatePriority);
		}
		return !this.WaitConfirm || !this.CheckSwitchStateInternal(state, subStatePriority, this.CurrentState, this.SubStatePriority);
	}

	// Token: 0x06017EE6 RID: 98022 RVA: 0x007235D5 File Offset: 0x007217D5
	private bool CheckSwitchStateInternal(ECharacterFightState curState, int curSubState, ECharacterFightState newState, int newSubState)
	{
		if (newState == curState)
		{
			return (newSubState == curSubState && (newState - ECharacterFightState.NormalSkill <= 1 || newState == ECharacterFightState.BeBrokeWeakness || newState == ECharacterFightState.SuperSkill)) || newSubState > curSubState;
		}
		return newState > curState;
	}

	// Token: 0x06017EE7 RID: 98023 RVA: 0x00723604 File Offset: 0x00721804
	public int TrySwitchState(ECharacterFightState state, int subStatePriority, bool isLocal = false)
	{
		if (this.CheckSwitchState(state, subStatePriority, isLocal))
		{
			this.SwitchState(state, subStatePriority, isLocal);
			return this.CurrentHandle;
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.FightState;
		Entity entity = base.Entity;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 3);
		defaultInterpolatedStringHandler.AppendLiteral("切换");
		defaultInterpolatedStringHandler.AppendFormatted(isLocal ? "本地" : "远端");
		defaultInterpolatedStringHandler.AppendLiteral("主状态失败，");
		defaultInterpolatedStringHandler.AppendFormatted(this.TargetStateToString((int)state, subStatePriority));
		defaultInterpolatedStringHandler.AppendLiteral("，");
		defaultInterpolatedStringHandler.AppendFormatted(this.CurrentStateToString());
		instance.Info(flag, entity, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		return 0;
	}

	// Token: 0x06017EE8 RID: 98024 RVA: 0x007236B0 File Offset: 0x007218B0
	private int SwitchState(ECharacterFightState state, int subStatePriority, bool isLocal = false)
	{
		this.CurrentState = state;
		this.SubStatePriority = subStatePriority;
		this.IsLocal = isLocal;
		this.WaitConfirm = isLocal;
		int num = this.IncId + 1;
		this.IncId = num;
		this.CurrentHandle = num;
		CombatLog.Instance.Info(CombatLog.EDebugModule.FightState, base.Entity, "切换" + (isLocal ? "本地" : "远端") + "主状态成功，" + this.CurrentStateToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		return this.CurrentHandle;
	}

	// Token: 0x06017EE9 RID: 98025 RVA: 0x00723738 File Offset: 0x00721938
	public void ConfirmState(int handle)
	{
		if (this.CurrentHandle == handle)
		{
			this.WaitConfirm = false;
			return;
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.FightState;
		Entity entity = base.Entity;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
		defaultInterpolatedStringHandler.AppendLiteral("确认状态失败[handle:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(handle);
		defaultInterpolatedStringHandler.AppendLiteral("]，当前[handle:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentHandle);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		instance.Info(flag, entity, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06017EEA RID: 98026 RVA: 0x007237BC File Offset: 0x007219BC
	public void ResetState()
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.FightState;
		Entity entity = base.Entity;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
		defaultInterpolatedStringHandler.AppendLiteral("重置主状态[handle:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentHandle);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		instance.Info(flag, entity, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		this.CurrentState = ECharacterFightState.Default;
		this.SubStatePriority = 0;
		this.IsLocal = false;
		this.WaitConfirm = false;
		this.CurrentHandle = 0;
	}

	// Token: 0x06017EEB RID: 98027 RVA: 0x00723840 File Offset: 0x00721A40
	public void ExitState(int handle)
	{
		if (this.CurrentHandle == handle)
		{
			CombatLog.Instance.Info(CombatLog.EDebugModule.FightState, base.Entity, "退出主状态，" + this.CurrentStateToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CurrentState = ECharacterFightState.Default;
			this.SubStatePriority = 0;
			this.IsLocal = false;
			this.WaitConfirm = false;
			this.CurrentHandle = 0;
			return;
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.FightState;
		Entity entity = base.Entity;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
		defaultInterpolatedStringHandler.AppendLiteral("退出主状态失败，[handle:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(handle);
		defaultInterpolatedStringHandler.AppendLiteral("]，");
		defaultInterpolatedStringHandler.AppendFormatted(this.CurrentStateToString());
		instance.Info(flag, entity, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06017EEC RID: 98028 RVA: 0x007238FE File Offset: 0x00721AFE
	public int GetFightState()
	{
		if (this.CurrentHandle == 0)
		{
			return 0;
		}
		return (int)((int)this.CurrentState << 8 | (ECharacterFightState)this.SubStatePriority);
	}

	// Token: 0x06017EED RID: 98029 RVA: 0x0072391C File Offset: 0x00721B1C
	private string CurrentStateToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
		defaultInterpolatedStringHandler.AppendLiteral("[当前状态(");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentHandle);
		defaultInterpolatedStringHandler.AppendLiteral("):");
		defaultInterpolatedStringHandler.AppendFormatted(this.FightStateToString((int)this.CurrentState, this.SubStatePriority));
		defaultInterpolatedStringHandler.AppendLiteral("]");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06017EEE RID: 98030 RVA: 0x00723984 File Offset: 0x00721B84
	private string TargetStateToString(int state, int subState)
	{
		return "[目标状态：" + this.FightStateToString(state, subState) + "]";
	}

	// Token: 0x06017EEF RID: 98031 RVA: 0x007239A0 File Offset: 0x00721BA0
	private string FightStateToString(int state, int subState)
	{
		string result = "";
		switch (state)
		{
		case 1:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
			defaultInterpolatedStringHandler.AppendLiteral("普通技能(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 2:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
			defaultInterpolatedStringHandler.AppendLiteral("普通受击(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 3:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
			defaultInterpolatedStringHandler.AppendLiteral("覆盖受击技能(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 4:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
			defaultInterpolatedStringHandler.AppendLiteral("被弹反受击(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 5:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("覆盖被弹反技能(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 6:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
			defaultInterpolatedStringHandler.AppendLiteral("被破弱(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 7:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("覆盖被破弱技能(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 8:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendLiteral("抓取(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 9:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
			defaultInterpolatedStringHandler.AppendLiteral("特殊技能(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		case 10:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
			defaultInterpolatedStringHandler.AppendLiteral("状态机主状态(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(state);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<int>(subState);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			result = defaultInterpolatedStringHandler.ToStringAndClear();
			break;
		}
		}
		return result;
	}

	// Token: 0x06017EF0 RID: 98032 RVA: 0x00723CCC File Offset: 0x00721ECC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterFightStateComponent characterFightStateComponent = (CharacterFightStateComponent)componentTemplate;
		this.IncId = characterFightStateComponent.IncId;
		if (characterFightStateComponent.UnifiedComp == null)
		{
			this.UnifiedComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedComp), "UnifiedComp"))
		{
			return false;
		}
		this.CurrentState = characterFightStateComponent.CurrentState;
		this.SubStatePriority = characterFightStateComponent.SubStatePriority;
		this.IsLocal = characterFightStateComponent.IsLocal;
		this.WaitConfirm = characterFightStateComponent.WaitConfirm;
		this.CurrentHandle = characterFightStateComponent.CurrentHandle;
		return true;
	}

	// Token: 0x17002565 RID: 9573
	// (get) Token: 0x06017EF1 RID: 98033 RVA: 0x00723D5F File Offset: 0x00721F5F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CCB2 RID: 52402
	private int IncId;

	// Token: 0x0400CCB3 RID: 52403
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedComp;

	// Token: 0x0400CCB4 RID: 52404
	public ECharacterFightState CurrentState;

	// Token: 0x0400CCB5 RID: 52405
	public int SubStatePriority;

	// Token: 0x0400CCB6 RID: 52406
	public bool IsLocal;

	// Token: 0x0400CCB7 RID: 52407
	public bool WaitConfirm;

	// Token: 0x0400CCB8 RID: 52408
	public int CurrentHandle;
}
