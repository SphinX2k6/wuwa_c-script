using System;
using System.Runtime.CompilerServices;

// Token: 0x020013E0 RID: 5088
[NullableContext(1)]
[Nullable(0)]
public class StrengthItemInfo
{
	// Token: 0x0600C98C RID: 51596 RVA: 0x003BEE4D File Offset: 0x003BD04D
	public StrengthItemInfo(EStrengthItemType itemType, StrengthItemConfig config)
	{
		this.ItemType = itemType;
		this.Config = config;
	}

	// Token: 0x04007256 RID: 29270
	public EStrengthItemType ItemType;

	// Token: 0x04007257 RID: 29271
	public StrengthItemConfig Config;

	// Token: 0x04007258 RID: 29272
	public bool Enable;

	// Token: 0x04007259 RID: 29273
	public bool Visible;

	// Token: 0x0400725A RID: 29274
	[Nullable(2)]
	public StrengthItemBase StrengthItem;
}
