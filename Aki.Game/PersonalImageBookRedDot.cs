using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x0200295A RID: 10586
public class PersonalImageBookRedDot : RedDotBase
{
	// Token: 0x0601A96B RID: 108907 RVA: 0x00830717 File Offset: 0x0082E917
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPersonalTipStateSet, new Action(base.EventCheck));
	}

	// Token: 0x0601A96C RID: 108908 RVA: 0x00830735 File Offset: 0x0082E935
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPersonalTipStateSet, new Action(base.EventCheck));
	}

	// Token: 0x0601A96D RID: 108909 RVA: 0x00830753 File Offset: 0x0082E953
	protected override bool OnCheck(int uId = 0)
	{
		return PersonalModel.Instance.CheckCanShowPersonalTip();
	}
}
