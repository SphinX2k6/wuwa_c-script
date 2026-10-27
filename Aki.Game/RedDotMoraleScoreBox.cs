using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033CC RID: 13260
public class RedDotMoraleScoreBox : RedDotBase
{
	// Token: 0x0601CBE7 RID: 117735 RVA: 0x00808FE2 File Offset: 0x008071E2
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Morale);
	}

	// Token: 0x0601CBE8 RID: 117736 RVA: 0x00808FEE File Offset: 0x008071EE
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateMoraleScoreBox, new Action(base.EventCheck));
	}

	// Token: 0x0601CBE9 RID: 117737 RVA: 0x0080900C File Offset: 0x0080720C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateMoraleScoreBox, new Action(base.EventCheck));
	}

	// Token: 0x0601CBEA RID: 117738 RVA: 0x0080902A File Offset: 0x0080722A
	protected override bool OnCheck(int uId = 0)
	{
		return MoraleModel.Instance.RedDotScoreBox();
	}
}
