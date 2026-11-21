using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028E1 RID: 10465
public class RedDotVisionRecovery : RedDotBase
{
	// Token: 0x0601A73B RID: 108347 RVA: 0x0082C325 File Offset: 0x0082A525
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnVisionRecoveryStorage, new Action(base.EventCheck));
	}

	// Token: 0x0601A73C RID: 108348 RVA: 0x0082C343 File Offset: 0x0082A543
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionRecoveryStorage, new Action(base.EventCheck));
	}

	// Token: 0x0601A73D RID: 108349 RVA: 0x0082C361 File Offset: 0x0082A561
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomBattleModel.Instance.GetVisionRecoveryBatchRedDot() || PhantomBattleModel.Instance.GetVisionRecoveryBatchAimRedDot();
	}
}
