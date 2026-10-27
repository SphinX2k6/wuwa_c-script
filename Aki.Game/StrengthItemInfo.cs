using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F1E RID: 7966
[NullableContext(1)]
[Nullable(0)]
public class StrengthItemInfo
{
	// Token: 0x0600F56D RID: 62829 RVA: 0x003B3361 File Offset: 0x003B1561
	public StrengthItemInfo(EStrengthItemType itemType, StrengthItemConfig config)
	{
		this.ItemType = itemType;
		this.Config = config;
	}

	// Token: 0x04007175 RID: 29045
	public EStrengthItemType ItemType;

	// Token: 0x04007176 RID: 29046
	public StrengthItemConfig Config;

	// Token: 0x04007177 RID: 29047
	public bool Enable;

	// Token: 0x04007178 RID: 29048
	public bool Visible;

	// Token: 0x04007179 RID: 29049
	[Nullable(2)]
	public StrengthItemBase StrengthItem;
}
