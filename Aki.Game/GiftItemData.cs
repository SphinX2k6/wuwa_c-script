using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001FB0 RID: 8112
public class GiftItemData
{
	// Token: 0x0600FCC5 RID: 64709 RVA: 0x003D62BC File Offset: 0x003D44BC
	public GiftItemData(int itemId, int itemCount, int incId)
	{
		this.ItemId = itemId;
		this.ItemCount = itemCount;
		this.IncId = incId;
	}

	// Token: 0x0600FCC6 RID: 64710 RVA: 0x003D62D9 File Offset: 0x003D44D9
	[NullableContext(1)]
	public void SetPhantomItemData(PhantomItem data)
	{
		this.PhantomItemData = data;
	}

	// Token: 0x0400756F RID: 30063
	public readonly int ItemId;

	// Token: 0x04007570 RID: 30064
	public readonly int ItemCount;

	// Token: 0x04007571 RID: 30065
	public readonly int IncId;

	// Token: 0x04007572 RID: 30066
	[Nullable(2)]
	public PhantomItem PhantomItemData;
}
