using System;
using System.Runtime.CompilerServices;

// Token: 0x02000796 RID: 1942
public class MapTravelTabItem : MapTravelTabItemBase
{
	// Token: 0x060058EE RID: 22766 RVA: 0x001CE8D8 File Offset: 0x001CCAD8
	[NullableContext(1)]
	public void RefreshByData(SoarChallengePlayData data)
	{
		this.Data = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameTextId, Array.Empty<object>());
		base.GetItem(2).SetUIActive(data.IsFinished);
		base.GetItem(3).SetUIActive(!data.IsUnlock);
		base.GetItem(4).SetUIActive(data.HasRedDot);
		base.GetItem(5).SetUIActive(data.IsUnlock && data.IsNew && !data.HasRedDot);
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x001CE969 File Offset: 0x001CCB69
	public void SetItemNewVisible(bool bVisible)
	{
		base.GetItem(5).SetUIActive(bVisible);
	}

	// Token: 0x02006A81 RID: 27265
	private class ETabComponents
	{
		// Token: 0x040230C2 RID: 143554
		public const int Toggle = 0;

		// Token: 0x040230C3 RID: 143555
		public const int Name = 1;

		// Token: 0x040230C4 RID: 143556
		public const int SpriteDone = 2;

		// Token: 0x040230C5 RID: 143557
		public const int SpriteLock = 3;

		// Token: 0x040230C6 RID: 143558
		public const int RedDot = 4;

		// Token: 0x040230C7 RID: 143559
		public const int ItemNew = 5;
	}
}
