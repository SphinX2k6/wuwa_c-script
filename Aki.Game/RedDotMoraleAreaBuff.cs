using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200293B RID: 10555
public class RedDotMoraleAreaBuff : RedDotBase
{
	// Token: 0x0601A8D3 RID: 108755 RVA: 0x0082F4DA File Offset: 0x0082D6DA
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoraleBuff);
	}

	// Token: 0x0601A8D4 RID: 108756 RVA: 0x0082F4E6 File Offset: 0x0082D6E6
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateMoraleAreaBuff, new Action(base.EventCheck));
	}

	// Token: 0x0601A8D5 RID: 108757 RVA: 0x0082F504 File Offset: 0x0082D704
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateMoraleAreaBuff, new Action(base.EventCheck));
	}

	// Token: 0x0601A8D6 RID: 108758 RVA: 0x0082F522 File Offset: 0x0082D722
	protected override bool OnCheck(int uId = 0)
	{
		return MoraleModel.Instance.RedDotAreaBuff();
	}
}
