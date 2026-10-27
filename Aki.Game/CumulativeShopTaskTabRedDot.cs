using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003377 RID: 13175
public class CumulativeShopTaskTabRedDot : RedDotBase
{
	// Token: 0x0601CA63 RID: 117347 RVA: 0x008060D4 File Offset: 0x008042D4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.CumulativeShopTaskRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA64 RID: 117348 RVA: 0x008060F2 File Offset: 0x008042F2
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.CumulativeShopTaskRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA65 RID: 117349 RVA: 0x00806110 File Offset: 0x00804310
	protected override bool OnCheck(int uId = 0)
	{
		CumulativeShopData cumulativeShopData = CumulativeShopController.Instance.GetCumulativeShopData();
		return cumulativeShopData != null && cumulativeShopData.GetTaskTabRedDot(uId);
	}
}
