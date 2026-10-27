using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FFC RID: 12284
[NullableContext(1)]
[Nullable(0)]
public class EnterBattleTrigger : Trigger
{
	// Token: 0x0601A06E RID: 106606 RVA: 0x006D0E70 File Offset: 0x006CF070
	[NullableContext(2)]
	public EnterBattleTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A06F RID: 106607 RVA: 0x006D0E81 File Offset: 0x006CF081
	public override void OnInitParams(string[] triggerParams)
	{
		this.NotTryTriggerOnActive = (Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0") == 1);
	}

	// Token: 0x0601A070 RID: 106608 RVA: 0x006D0EA1 File Offset: 0x006CF0A1
	protected override void OnActive()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnEvent));
		if (!this.NotTryTriggerOnActive && FormationDataController.Instance.GlobalIsInFight)
		{
			this.OnEvent(true);
		}
	}

	// Token: 0x0601A071 RID: 106609 RVA: 0x006D0EDA File Offset: 0x006CF0DA
	protected override void OnInactive()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnEvent));
	}

	// Token: 0x0601A072 RID: 106610 RVA: 0x006D0EF8 File Offset: 0x006CF0F8
	private void OnEvent(bool isInBattleState)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		if (isInBattleState)
		{
			base.EvaluateAndExecute(new Dictionary<string, TFormulaValue>());
		}
	}

	// Token: 0x0601A073 RID: 106611 RVA: 0x006D0F1E File Offset: 0x006CF11E
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4F2 RID: 50418
	private bool NotTryTriggerOnActive;
}
