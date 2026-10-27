using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200336F RID: 13167
public class RedDotVisionRecovery : RedDotBase
{
	// Token: 0x0601CA43 RID: 117315 RVA: 0x00805D61 File Offset: 0x00803F61
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnVisionRecoveryStorage, new Action(base.EventCheck));
	}

	// Token: 0x0601CA44 RID: 117316 RVA: 0x00805D7F File Offset: 0x00803F7F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionRecoveryStorage, new Action(base.EventCheck));
	}

	// Token: 0x0601CA45 RID: 117317 RVA: 0x00805D9D File Offset: 0x00803F9D
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomBattleModel.Instance.GetVisionRecoveryBatchRedDot() || PhantomBattleModel.Instance.GetVisionRecoveryBatchAimRedDot();
	}
}
