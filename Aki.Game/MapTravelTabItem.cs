using System;
using System.Runtime.CompilerServices;

// Token: 0x020012E2 RID: 4834
public class MapTravelTabItem : MapTravelTabItemBase
{
	// Token: 0x06008553 RID: 34131 RVA: 0x001C5A7C File Offset: 0x001C3C7C
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

	// Token: 0x06008554 RID: 34132 RVA: 0x001C5B0D File Offset: 0x001C3D0D
	public void SetItemNewVisible(bool bVisible)
	{
		base.GetItem(5).SetUIActive(bVisible);
	}

	// Token: 0x020078F7 RID: 30967
	private class ETabComponents
	{
		// Token: 0x04027D94 RID: 163220
		public const int Toggle = 0;

		// Token: 0x04027D95 RID: 163221
		public const int Name = 1;

		// Token: 0x04027D96 RID: 163222
		public const int SpriteDone = 2;

		// Token: 0x04027D97 RID: 163223
		public const int SpriteLock = 3;

		// Token: 0x04027D98 RID: 163224
		public const int RedDot = 4;

		// Token: 0x04027D99 RID: 163225
		public const int ItemNew = 5;
	}
}
