using System;

// Token: 0x02003167 RID: 12647
internal sealed class FoxPickUpOperation
{
	// Token: 0x170025B3 RID: 9651
	// (get) Token: 0x0601B34C RID: 111436 RVA: 0x0076A545 File Offset: 0x00768745
	public int Handle { get; }

	// Token: 0x170025B4 RID: 9652
	// (get) Token: 0x0601B34D RID: 111437 RVA: 0x0076A54D File Offset: 0x0076874D
	public bool IsPickUp { get; }

	// Token: 0x170025B5 RID: 9653
	// (get) Token: 0x0601B34E RID: 111438 RVA: 0x0076A555 File Offset: 0x00768755
	public int PickUpHandle { get; }

	// Token: 0x170025B6 RID: 9654
	// (get) Token: 0x0601B34F RID: 111439 RVA: 0x0076A55D File Offset: 0x0076875D
	// (set) Token: 0x0601B350 RID: 111440 RVA: 0x0076A565 File Offset: 0x00768765
	public int ItemId { get; set; }

	// Token: 0x170025B7 RID: 9655
	// (get) Token: 0x0601B351 RID: 111441 RVA: 0x0076A56E File Offset: 0x0076876E
	// (set) Token: 0x0601B352 RID: 111442 RVA: 0x0076A576 File Offset: 0x00768776
	public bool KeepMouthClosed { get; set; }

	// Token: 0x0601B353 RID: 111443 RVA: 0x0076A57F File Offset: 0x0076877F
	public FoxPickUpOperation(int handle, bool isPickUp, int pickUpHandle, int itemId, bool keepMouthClosed)
	{
		this.Handle = handle;
		this.IsPickUp = isPickUp;
		this.PickUpHandle = pickUpHandle;
		this.ItemId = itemId;
		this.KeepMouthClosed = keepMouthClosed;
	}
}
