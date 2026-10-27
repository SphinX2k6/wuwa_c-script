using System;

// Token: 0x02003111 RID: 12561
public interface IPerformActionBase
{
	// Token: 0x17002550 RID: 9552
	// (get) Token: 0x0601AFFE RID: 110590
	// (set) Token: 0x0601AFFF RID: 110591
	int Id { get; set; }

	// Token: 0x17002551 RID: 9553
	// (get) Token: 0x0601B000 RID: 110592
	// (set) Token: 0x0601B001 RID: 110593
	EPerformMode Mode { get; set; }

	// Token: 0x17002552 RID: 9554
	// (get) Token: 0x0601B002 RID: 110594
	// (set) Token: 0x0601B003 RID: 110595
	EPerformGroup Group { get; set; }

	// Token: 0x17002553 RID: 9555
	// (get) Token: 0x0601B004 RID: 110596
	// (set) Token: 0x0601B005 RID: 110597
	bool IsValid { get; set; }

	// Token: 0x17002554 RID: 9556
	// (get) Token: 0x0601B006 RID: 110598
	bool IsAtomic { get; }

	// Token: 0x17002555 RID: 9557
	// (get) Token: 0x0601B007 RID: 110599
	// (set) Token: 0x0601B008 RID: 110600
	bool IsPersistent { get; set; }

	// Token: 0x0601B009 RID: 110601
	void Execute();

	// Token: 0x0601B00A RID: 110602
	void Interrupt();
}
