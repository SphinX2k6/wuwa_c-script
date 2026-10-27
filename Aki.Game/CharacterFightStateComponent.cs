using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x0200305A RID: 12378
[NullableContext(1)]
[Nullable(0)]
public class CharacterFightStateComponent : EntityComponent
{
	// Token: 0x0601A53A RID: 107834 RVA: 0x006FC37C File Offset: 0x006FA57C
	protected override bool OnStart()
	{
		this.UnifiedComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		return true;
	}

	// Token: 0x0601A53B RID: 107835 RVA: 0x006FC390 File Offset: 0x006FA590
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

	// Token: 0x0601A53C RID: 107836 RVA: 0x006FC3F0 File Offset: 0x006FA5F0
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

	// Token: 0x0601A53D RID: 107837 RVA: 0x006FC460 File Offset: 0x006FA660
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

	// Token: 0x0601A53E RID: 107838 RVA: 0x006FC4FC File Offset: 0x006FA6FC
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

	// Token: 0x0601A53F RID: 107839 RVA: 0x006FC56C File Offset: 0x006FA76C
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

	// Token: 0x0601A540 RID: 107840 RVA: 0x006FC5DA File Offset: 0x006FA7DA
	public bool CheckSwitchState(ECharacterFightState state, int subStatePriority, bool isLocal = false)
	{
		if (isLocal)
		{
			return this.CheckSwitchStateInternal(this.CurrentState, this.SubStatePriority, state, subStatePriority);
		}
		return !this.WaitConfirm || !this.CheckSwitchStateInternal(state, subStatePriority, this.CurrentState, this.SubStatePriority);
	}

	// Token: 0x0601A541 RID: 107841 RVA: 0x006FC615 File Offset: 0x006FA815
	private bool CheckSwitchStateInternal(ECharacterFightState curState, int curSubState, ECharacterFightState newState, int newSubState)
	{
		if (newState == curState)
		{
			return (newSubState == curSubState && (newState - ECharacterFightState.NormalSkill <= 1 || newState == ECharacterFightState.BeBrokeWeakness || newState == ECharacterFightState.SuperSkill)) || newSubState > curSubState;
		}
		return newState > curState;
	}

	// Token: 0x0601A542 RID: 107842 RVA: 0x006FC644 File Offset: 0x006FA844
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

	// Token: 0x0601A543 RID: 107843 RVA: 0x006FC6F0 File Offset: 0x006FA8F0
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

	// Token: 0x0601A544 RID: 107844 RVA: 0x006FC778 File Offset: 0x006FA978
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

	// Token: 0x0601A545 RID: 107845 RVA: 0x006FC7FC File Offset: 0x006FA9FC
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

	// Token: 0x0601A546 RID: 107846 RVA: 0x006FC880 File Offset: 0x006FAA80
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

	// Token: 0x0601A547 RID: 107847 RVA: 0x006FC93E File Offset: 0x006FAB3E
	public int GetFightState()
	{
		if (this.CurrentHandle == 0)
		{
			return 0;
		}
		return (int)((int)this.CurrentState << 8 | (ECharacterFightState)this.SubStatePriority);
	}

	// Token: 0x0601A548 RID: 107848 RVA: 0x006FC95C File Offset: 0x006FAB5C
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

	// Token: 0x0601A549 RID: 107849 RVA: 0x006FC9C4 File Offset: 0x006FABC4
	private string TargetStateToString(int state, int subState)
	{
		return "[目标状态：" + this.FightStateToString(state, subState) + "]";
	}

	// Token: 0x0601A54A RID: 107850 RVA: 0x006FC9E0 File Offset: 0x006FABE0
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

	// Token: 0x0601A54B RID: 107851 RVA: 0x006FCD0C File Offset: 0x006FAF0C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterFightStateComponent characterFightStateComponent = (CharacterFightStateComponent)componentTemplate;
		if (base.CanResetComponentProperty("IncId"))
		{
			this.IncId = characterFightStateComponent.IncId;
		}
		if (base.CanResetComponentProperty("UnifiedComp"))
		{
			if (characterFightStateComponent.UnifiedComp == null)
			{
				this.UnifiedComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedComp), "UnifiedComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentState"))
		{
			this.CurrentState = characterFightStateComponent.CurrentState;
		}
		if (base.CanResetComponentProperty("SubStatePriority"))
		{
			this.SubStatePriority = characterFightStateComponent.SubStatePriority;
		}
		if (base.CanResetComponentProperty("IsLocal"))
		{
			this.IsLocal = characterFightStateComponent.IsLocal;
		}
		if (base.CanResetComponentProperty("WaitConfirm"))
		{
			this.WaitConfirm = characterFightStateComponent.WaitConfirm;
		}
		if (base.CanResetComponentProperty("CurrentHandle"))
		{
			this.CurrentHandle = characterFightStateComponent.CurrentHandle;
		}
		return true;
	}

	// Token: 0x0400C8D8 RID: 51416
	private int IncId;

	// Token: 0x0400C8D9 RID: 51417
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedComp;

	// Token: 0x0400C8DA RID: 51418
	public ECharacterFightState CurrentState;

	// Token: 0x0400C8DB RID: 51419
	public int SubStatePriority;

	// Token: 0x0400C8DC RID: 51420
	public bool IsLocal;

	// Token: 0x0400C8DD RID: 51421
	public bool WaitConfirm;

	// Token: 0x0400C8DE RID: 51422
	public int CurrentHandle;
}
