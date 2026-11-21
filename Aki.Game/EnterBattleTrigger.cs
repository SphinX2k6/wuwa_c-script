using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002551 RID: 9553
[NullableContext(1)]
[Nullable(0)]
public class EnterBattleTrigger : Trigger
{
	// Token: 0x060179A2 RID: 96674 RVA: 0x006F8D0C File Offset: 0x006F6F0C
	[NullableContext(2)]
	public EnterBattleTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x060179A3 RID: 96675 RVA: 0x006F8D1D File Offset: 0x006F6F1D
	public override void OnInitParams(string[] triggerParams)
	{
		this.NotTryTriggerOnActive = (Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0") == 1);
	}

	// Token: 0x060179A4 RID: 96676 RVA: 0x006F8D3D File Offset: 0x006F6F3D
	protected override void OnActive()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnEvent));
		if (!this.NotTryTriggerOnActive && FormationDataController.Instance.GlobalIsInFight)
		{
			this.OnEvent(true);
		}
	}

	// Token: 0x060179A5 RID: 96677 RVA: 0x006F8D76 File Offset: 0x006F6F76
	protected override void OnInactive()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnEvent));
	}

	// Token: 0x060179A6 RID: 96678 RVA: 0x006F8D94 File Offset: 0x006F6F94
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

	// Token: 0x060179A7 RID: 96679 RVA: 0x006F8DBA File Offset: 0x006F6FBA
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8BA RID: 51386
	private bool NotTryTriggerOnActive;
}
