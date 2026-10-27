using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003427 RID: 13351
public class RedDotHuluSkinTab : RedDotBase
{
	// Token: 0x0601CDA3 RID: 118179 RVA: 0x0080CAA6 File Offset: 0x0080ACA6
	protected override bool IsMultiple()
	{
		return false;
	}

	// Token: 0x0601CDA4 RID: 118180 RVA: 0x0080CAA9 File Offset: 0x0080ACA9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.HuluSkinRedDotRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CDA5 RID: 118181 RVA: 0x0080CAC7 File Offset: 0x0080ACC7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.HuluSkinRedDotRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CDA6 RID: 118182 RVA: 0x0080CAE5 File Offset: 0x0080ACE5
	protected override bool OnCheck(int uId = 0)
	{
		return CalabashSkinModel.Instance.CheckCalabashSkinHasRedDot();
	}
}
