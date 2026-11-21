using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001472 RID: 5234
public class GiftItemData
{
	// Token: 0x0600D0EB RID: 53483 RVA: 0x003E1C70 File Offset: 0x003DFE70
	public GiftItemData(int itemId, int itemCount, int incId)
	{
		this.ItemId = itemId;
		this.ItemCount = itemCount;
		this.IncId = incId;
	}

	// Token: 0x0600D0EC RID: 53484 RVA: 0x003E1C8D File Offset: 0x003DFE8D
	[NullableContext(1)]
	public void SetPhantomItemData(PhantomItem data)
	{
		this.PhantomItemData = data;
	}

	// Token: 0x04007651 RID: 30289
	public readonly int ItemId;

	// Token: 0x04007652 RID: 30290
	public readonly int ItemCount;

	// Token: 0x04007653 RID: 30291
	public readonly int IncId;

	// Token: 0x04007654 RID: 30292
	[Nullable(2)]
	public PhantomItem PhantomItemData;
}
