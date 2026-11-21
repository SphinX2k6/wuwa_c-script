using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028E9 RID: 10473
public class CumulativeShopTaskTabRedDot : RedDotBase
{
	// Token: 0x0601A75B RID: 108379 RVA: 0x0082C698 File Offset: 0x0082A898
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.CumulativeShopTaskRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A75C RID: 108380 RVA: 0x0082C6B6 File Offset: 0x0082A8B6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.CumulativeShopTaskRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A75D RID: 108381 RVA: 0x0082C6D4 File Offset: 0x0082A8D4
	protected override bool OnCheck(int uId = 0)
	{
		CumulativeShopData cumulativeShopData = CumulativeShopController.Instance.GetCumulativeShopData();
		return cumulativeShopData != null && cumulativeShopData.GetTaskTabRedDot(uId);
	}
}
