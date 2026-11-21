using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200293D RID: 10557
public class RedDotMoraleFlagBox : RedDotBase
{
	// Token: 0x0601A8DA RID: 108762 RVA: 0x0082F54A File Offset: 0x0082D74A
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Morale);
	}

	// Token: 0x0601A8DB RID: 108763 RVA: 0x0082F556 File Offset: 0x0082D756
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateMoraleFlagBox, new Action(base.EventCheck));
	}

	// Token: 0x0601A8DC RID: 108764 RVA: 0x0082F574 File Offset: 0x0082D774
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateMoraleFlagBox, new Action(base.EventCheck));
	}

	// Token: 0x0601A8DD RID: 108765 RVA: 0x0082F592 File Offset: 0x0082D792
	protected override bool OnCheck(int uId = 0)
	{
		return MoraleModel.Instance.RedDotFlagBox();
	}
}
