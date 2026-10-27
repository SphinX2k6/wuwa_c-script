using System;

// Token: 0x02002033 RID: 8243
public interface IKingShipAttributeItemData
{
	// Token: 0x170013B9 RID: 5049
	// (get) Token: 0x060102D6 RID: 66262
	// (set) Token: 0x060102D7 RID: 66263
	int AttributeId { get; set; }

	// Token: 0x170013BA RID: 5050
	// (get) Token: 0x060102D8 RID: 66264
	// (set) Token: 0x060102D9 RID: 66265
	int MaxCount { get; set; }

	// Token: 0x170013BB RID: 5051
	// (get) Token: 0x060102DA RID: 66266
	// (set) Token: 0x060102DB RID: 66267
	int MinCount { get; set; }

	// Token: 0x170013BC RID: 5052
	// (get) Token: 0x060102DC RID: 66268
	// (set) Token: 0x060102DD RID: 66269
	int Current { get; set; }

	// Token: 0x170013BD RID: 5053
	// (get) Token: 0x060102DE RID: 66270
	// (set) Token: 0x060102DF RID: 66271
	bool IsDefaultEnable { get; set; }
}
