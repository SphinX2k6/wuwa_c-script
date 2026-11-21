using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028E2 RID: 10466
public class RedDotVisionRefine : RedDotBase
{
	// Token: 0x0601A73F RID: 108351 RVA: 0x0082C383 File Offset: 0x0082A583
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnVisionRefineStorage, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotStart, new Action(base.EventCheck));
	}

	// Token: 0x0601A740 RID: 108352 RVA: 0x0082C3BD File Offset: 0x0082A5BD
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionRefineStorage, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotStart, new Action(base.EventCheck));
	}

	// Token: 0x0601A741 RID: 108353 RVA: 0x0082C3F7 File Offset: 0x0082A5F7
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomBattleModel.Instance.GetVisionRefineRedDot();
	}
}
