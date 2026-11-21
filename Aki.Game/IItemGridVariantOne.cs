using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D76 RID: 3446
[NullableContext(2)]
public interface IItemGridVariantOne
{
	// Token: 0x17000F80 RID: 3968
	// (get) Token: 0x06008D98 RID: 36248
	bool IsItemGridVariantOne { get; }

	// Token: 0x06008D99 RID: 36249
	void RefreshStar(int[] starNum);

	// Token: 0x06008D9A RID: 36250
	void RefreshRecoverSprite(bool showState);

	// Token: 0x06008D9B RID: 36251
	void RefreshRightDownLockSprite(bool showState);

	// Token: 0x06008D9C RID: 36252
	void RefreshUpgradePanel(bool showState, string showText);
}
