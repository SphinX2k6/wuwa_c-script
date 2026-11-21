using System;

// Token: 0x02001506 RID: 5382
public interface IKingShipAttributeItemData
{
	// Token: 0x170013E6 RID: 5094
	// (get) Token: 0x0600D73E RID: 55102
	// (set) Token: 0x0600D73F RID: 55103
	int AttributeId { get; set; }

	// Token: 0x170013E7 RID: 5095
	// (get) Token: 0x0600D740 RID: 55104
	// (set) Token: 0x0600D741 RID: 55105
	int MaxCount { get; set; }

	// Token: 0x170013E8 RID: 5096
	// (get) Token: 0x0600D742 RID: 55106
	// (set) Token: 0x0600D743 RID: 55107
	int MinCount { get; set; }

	// Token: 0x170013E9 RID: 5097
	// (get) Token: 0x0600D744 RID: 55108
	// (set) Token: 0x0600D745 RID: 55109
	int Current { get; set; }

	// Token: 0x170013EA RID: 5098
	// (get) Token: 0x0600D746 RID: 55110
	// (set) Token: 0x0600D747 RID: 55111
	bool IsDefaultEnable { get; set; }
}
