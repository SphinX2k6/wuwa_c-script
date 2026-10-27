using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003370 RID: 13168
public class RedDotVisionRefine : RedDotBase
{
	// Token: 0x0601CA47 RID: 117319 RVA: 0x00805DBF File Offset: 0x00803FBF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnVisionRefineStorage, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotStart, new Action(base.EventCheck));
	}

	// Token: 0x0601CA48 RID: 117320 RVA: 0x00805DF9 File Offset: 0x00803FF9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionRefineStorage, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotStart, new Action(base.EventCheck));
	}

	// Token: 0x0601CA49 RID: 117321 RVA: 0x00805E33 File Offset: 0x00804033
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomBattleModel.Instance.GetVisionRefineRedDot();
	}
}
