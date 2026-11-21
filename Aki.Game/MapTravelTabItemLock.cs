using System;
using System.Runtime.CompilerServices;

// Token: 0x02000797 RID: 1943
public class MapTravelTabItemLock : MapTravelTabItemBase
{
	// Token: 0x060058F1 RID: 22769 RVA: 0x001CE980 File Offset: 0x001CCB80
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(true);
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x060058F2 RID: 22770 RVA: 0x001CE9A9 File Offset: 0x001CCBA9
	[NullableContext(1)]
	public void RefreshByData(SoarChallengePlayData data)
	{
		this.Data = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameTextId, Array.Empty<object>());
	}

	// Token: 0x02006A82 RID: 27266
	private class ETabComponents
	{
		// Token: 0x040230C8 RID: 143560
		public const int Toggle = 0;

		// Token: 0x040230C9 RID: 143561
		public const int Name = 1;

		// Token: 0x040230CA RID: 143562
		public const int SpriteDone = 2;

		// Token: 0x040230CB RID: 143563
		public const int SpriteLock = 3;

		// Token: 0x040230CC RID: 143564
		public const int RedDot = 4;

		// Token: 0x040230CD RID: 143565
		public const int ItemNew = 5;
	}
}
