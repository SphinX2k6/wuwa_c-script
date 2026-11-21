using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200293E RID: 10558
public class RedDotMoraleScoreBox : RedDotBase
{
	// Token: 0x0601A8DF RID: 108767 RVA: 0x0082F5A6 File Offset: 0x0082D7A6
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Morale);
	}

	// Token: 0x0601A8E0 RID: 108768 RVA: 0x0082F5B2 File Offset: 0x0082D7B2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateMoraleScoreBox, new Action(base.EventCheck));
	}

	// Token: 0x0601A8E1 RID: 108769 RVA: 0x0082F5D0 File Offset: 0x0082D7D0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateMoraleScoreBox, new Action(base.EventCheck));
	}

	// Token: 0x0601A8E2 RID: 108770 RVA: 0x0082F5EE File Offset: 0x0082D7EE
	protected override bool OnCheck(int uId = 0)
	{
		return MoraleModel.Instance.RedDotScoreBox();
	}
}
