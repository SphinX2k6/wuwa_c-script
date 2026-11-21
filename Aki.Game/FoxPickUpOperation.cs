using System;

// Token: 0x020026D4 RID: 9940
internal sealed class FoxPickUpOperation
{
	// Token: 0x170027A4 RID: 10148
	// (get) Token: 0x06018E51 RID: 101969 RVA: 0x00791EA9 File Offset: 0x007900A9
	public int Handle { get; }

	// Token: 0x170027A5 RID: 10149
	// (get) Token: 0x06018E52 RID: 101970 RVA: 0x00791EB1 File Offset: 0x007900B1
	public bool IsPickUp { get; }

	// Token: 0x170027A6 RID: 10150
	// (get) Token: 0x06018E53 RID: 101971 RVA: 0x00791EB9 File Offset: 0x007900B9
	public int PickUpHandle { get; }

	// Token: 0x170027A7 RID: 10151
	// (get) Token: 0x06018E54 RID: 101972 RVA: 0x00791EC1 File Offset: 0x007900C1
	// (set) Token: 0x06018E55 RID: 101973 RVA: 0x00791EC9 File Offset: 0x007900C9
	public int ItemId { get; set; }

	// Token: 0x170027A8 RID: 10152
	// (get) Token: 0x06018E56 RID: 101974 RVA: 0x00791ED2 File Offset: 0x007900D2
	// (set) Token: 0x06018E57 RID: 101975 RVA: 0x00791EDA File Offset: 0x007900DA
	public bool KeepMouthClosed { get; set; }

	// Token: 0x06018E58 RID: 101976 RVA: 0x00791EE3 File Offset: 0x007900E3
	public FoxPickUpOperation(int handle, bool isPickUp, int pickUpHandle, int itemId, bool keepMouthClosed)
	{
		this.Handle = handle;
		this.IsPickUp = isPickUp;
		this.PickUpHandle = pickUpHandle;
		this.ItemId = itemId;
		this.KeepMouthClosed = keepMouthClosed;
	}
}
