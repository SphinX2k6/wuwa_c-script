using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002552 RID: 9554
[NullableContext(1)]
[Nullable(0)]
public class LeaveBattleTrigger : Trigger
{
	// Token: 0x060179A8 RID: 96680 RVA: 0x006F8DC1 File Offset: 0x006F6FC1
	[NullableContext(2)]
	public LeaveBattleTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x060179A9 RID: 96681 RVA: 0x006F8DD2 File Offset: 0x006F6FD2
	public override void OnInitParams(string[] triggerParams)
	{
		this.NotTryTriggerOnActive = (Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0") == 1);
	}

	// Token: 0x060179AA RID: 96682 RVA: 0x006F8DF2 File Offset: 0x006F6FF2
	protected override void OnActive()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnEvent));
		if (!this.NotTryTriggerOnActive && !FormationDataController.Instance.GlobalIsInFight)
		{
			this.OnEvent(false);
		}
	}

	// Token: 0x060179AB RID: 96683 RVA: 0x006F8E2B File Offset: 0x006F702B
	protected override void OnInactive()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnEvent));
	}

	// Token: 0x060179AC RID: 96684 RVA: 0x006F8E49 File Offset: 0x006F7049
	private void OnEvent(bool isInBattleState)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		if (!isInBattleState)
		{
			base.EvaluateAndExecute(new Dictionary<string, TFormulaValue>());
		}
	}

	// Token: 0x060179AD RID: 96685 RVA: 0x006F8E6F File Offset: 0x006F706F
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8BB RID: 51387
	private bool NotTryTriggerOnActive;
}
