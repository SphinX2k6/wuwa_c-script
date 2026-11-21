using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002999 RID: 10649
public class RedDotHuluSkinTab : RedDotBase
{
	// Token: 0x0601AA9B RID: 109211 RVA: 0x0083306A File Offset: 0x0083126A
	protected override bool IsMultiple()
	{
		return false;
	}

	// Token: 0x0601AA9C RID: 109212 RVA: 0x0083306D File Offset: 0x0083126D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.HuluSkinRedDotRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AA9D RID: 109213 RVA: 0x0083308B File Offset: 0x0083128B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.HuluSkinRedDotRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AA9E RID: 109214 RVA: 0x008330A9 File Offset: 0x008312A9
	protected override bool OnCheck(int uId = 0)
	{
		return CalabashSkinModel.Instance.CheckCalabashSkinHasRedDot();
	}
}
