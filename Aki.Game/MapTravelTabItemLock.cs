using System;
using System.Runtime.CompilerServices;

// Token: 0x020012E3 RID: 4835
public class MapTravelTabItemLock : MapTravelTabItemBase
{
	// Token: 0x06008556 RID: 34134 RVA: 0x001C5B24 File Offset: 0x001C3D24
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(true);
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x06008557 RID: 34135 RVA: 0x001C5B4D File Offset: 0x001C3D4D
	[NullableContext(1)]
	public void RefreshByData(SoarChallengePlayData data)
	{
		this.Data = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameTextId, Array.Empty<object>());
	}

	// Token: 0x020078F8 RID: 30968
	private class ETabComponents
	{
		// Token: 0x04027D9A RID: 163226
		public const int Toggle = 0;

		// Token: 0x04027D9B RID: 163227
		public const int Name = 1;

		// Token: 0x04027D9C RID: 163228
		public const int SpriteDone = 2;

		// Token: 0x04027D9D RID: 163229
		public const int SpriteLock = 3;

		// Token: 0x04027D9E RID: 163230
		public const int RedDot = 4;

		// Token: 0x04027D9F RID: 163231
		public const int ItemNew = 5;
	}
}
