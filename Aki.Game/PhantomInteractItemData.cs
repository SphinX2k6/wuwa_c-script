using System;

// Token: 0x0200245B RID: 9307
public class PhantomInteractItemData : IPhantomInteractItemData
{
	// Token: 0x17001845 RID: 6213
	// (get) Token: 0x06012AC2 RID: 76482 RVA: 0x0049C531 File Offset: 0x0049A731
	// (set) Token: 0x06012AC3 RID: 76483 RVA: 0x0049C539 File Offset: 0x0049A739
	public int ItemIndex { get; set; }

	// Token: 0x17001846 RID: 6214
	// (get) Token: 0x06012AC4 RID: 76484 RVA: 0x0049C542 File Offset: 0x0049A742
	// (set) Token: 0x06012AC5 RID: 76485 RVA: 0x0049C54A File Offset: 0x0049A74A
	public int MonsterId { get; set; }

	// Token: 0x06012AC6 RID: 76486 RVA: 0x0049C553 File Offset: 0x0049A753
	public void LoadData(int index, int monsterId)
	{
		this.ItemIndex = index;
		this.MonsterId = monsterId;
	}

	// Token: 0x06012AC7 RID: 76487 RVA: 0x0049C563 File Offset: 0x0049A763
	public void LoadEmpty(int index)
	{
		this.ItemIndex = index;
		this.MonsterId = 0;
	}
}
