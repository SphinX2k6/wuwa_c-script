using System;
using System.Runtime.CompilerServices;

// Token: 0x020018BD RID: 6333
[NullableContext(2)]
public interface IItemGridVariantOne
{
	// Token: 0x17000F5D RID: 3933
	// (get) Token: 0x0600B9AF RID: 47535
	bool IsItemGridVariantOne { get; }

	// Token: 0x0600B9B0 RID: 47536
	void RefreshStar(int[] starNum);

	// Token: 0x0600B9B1 RID: 47537
	void RefreshRecoverSprite(bool showState);

	// Token: 0x0600B9B2 RID: 47538
	void RefreshRightDownLockSprite(bool showState);

	// Token: 0x0600B9B3 RID: 47539
	void RefreshUpgradePanel(bool showState, string showText);
}
