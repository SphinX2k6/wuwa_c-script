using System;

// Token: 0x02001940 RID: 6464
public class PhantomInteractItemData : IPhantomInteractItemData
{
	// Token: 0x1700187F RID: 6271
	// (get) Token: 0x0600FF7A RID: 65402 RVA: 0x004A9C9D File Offset: 0x004A7E9D
	// (set) Token: 0x0600FF7B RID: 65403 RVA: 0x004A9CA5 File Offset: 0x004A7EA5
	public int ItemIndex { get; set; }

	// Token: 0x17001880 RID: 6272
	// (get) Token: 0x0600FF7C RID: 65404 RVA: 0x004A9CAE File Offset: 0x004A7EAE
	// (set) Token: 0x0600FF7D RID: 65405 RVA: 0x004A9CB6 File Offset: 0x004A7EB6
	public int MonsterId { get; set; }

	// Token: 0x0600FF7E RID: 65406 RVA: 0x004A9CBF File Offset: 0x004A7EBF
	public void LoadData(int index, int monsterId)
	{
		this.ItemIndex = index;
		this.MonsterId = monsterId;
	}

	// Token: 0x0600FF7F RID: 65407 RVA: 0x004A9CCF File Offset: 0x004A7ECF
	public void LoadEmpty(int index)
	{
		this.ItemIndex = index;
		this.MonsterId = 0;
	}
}
