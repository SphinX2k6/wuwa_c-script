using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033CB RID: 13259
public class RedDotMoraleFlagBox : RedDotBase
{
	// Token: 0x0601CBE2 RID: 117730 RVA: 0x00808F86 File Offset: 0x00807186
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Morale);
	}

	// Token: 0x0601CBE3 RID: 117731 RVA: 0x00808F92 File Offset: 0x00807192
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateMoraleFlagBox, new Action(base.EventCheck));
	}

	// Token: 0x0601CBE4 RID: 117732 RVA: 0x00808FB0 File Offset: 0x008071B0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateMoraleFlagBox, new Action(base.EventCheck));
	}

	// Token: 0x0601CBE5 RID: 117733 RVA: 0x00808FCE File Offset: 0x008071CE
	protected override bool OnCheck(int uId = 0)
	{
		return MoraleModel.Instance.RedDotFlagBox();
	}
}
