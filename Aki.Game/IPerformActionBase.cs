using System;

// Token: 0x0200266C RID: 9836
public interface IPerformActionBase
{
	// Token: 0x170026FB RID: 9979
	// (get) Token: 0x06018A59 RID: 100953
	// (set) Token: 0x06018A5A RID: 100954
	int Id { get; set; }

	// Token: 0x170026FC RID: 9980
	// (get) Token: 0x06018A5B RID: 100955
	// (set) Token: 0x06018A5C RID: 100956
	EPerformMode Mode { get; set; }

	// Token: 0x170026FD RID: 9981
	// (get) Token: 0x06018A5D RID: 100957
	// (set) Token: 0x06018A5E RID: 100958
	EPerformGroup Group { get; set; }

	// Token: 0x170026FE RID: 9982
	// (get) Token: 0x06018A5F RID: 100959
	// (set) Token: 0x06018A60 RID: 100960
	bool IsValid { get; set; }

	// Token: 0x170026FF RID: 9983
	// (get) Token: 0x06018A61 RID: 100961
	bool IsAtomic { get; }

	// Token: 0x17002700 RID: 9984
	// (get) Token: 0x06018A62 RID: 100962
	// (set) Token: 0x06018A63 RID: 100963
	bool IsPersistent { get; set; }

	// Token: 0x06018A64 RID: 100964
	void Execute();

	// Token: 0x06018A65 RID: 100965
	void Interrupt();
}
