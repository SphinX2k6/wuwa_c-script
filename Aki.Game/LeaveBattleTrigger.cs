using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FFD RID: 12285
[NullableContext(1)]
[Nullable(0)]
public class LeaveBattleTrigger : Trigger
{
	// Token: 0x0601A074 RID: 106612 RVA: 0x006D0F25 File Offset: 0x006CF125
	[NullableContext(2)]
	public LeaveBattleTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A075 RID: 106613 RVA: 0x006D0F36 File Offset: 0x006CF136
	public override void OnInitParams(string[] triggerParams)
	{
		this.NotTryTriggerOnActive = (Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0") == 1);
	}

	// Token: 0x0601A076 RID: 106614 RVA: 0x006D0F56 File Offset: 0x006CF156
	protected override void OnActive()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnEvent));
		if (!this.NotTryTriggerOnActive && !FormationDataController.Instance.GlobalIsInFight)
		{
			this.OnEvent(false);
		}
	}

	// Token: 0x0601A077 RID: 106615 RVA: 0x006D0F8F File Offset: 0x006CF18F
	protected override void OnInactive()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnEvent));
	}

	// Token: 0x0601A078 RID: 106616 RVA: 0x006D0FAD File Offset: 0x006CF1AD
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

	// Token: 0x0601A079 RID: 106617 RVA: 0x006D0FD3 File Offset: 0x006CF1D3
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4F3 RID: 50419
	private bool NotTryTriggerOnActive;
}
