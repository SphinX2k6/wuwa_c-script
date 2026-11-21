using System;

// Token: 0x020019E5 RID: 6629
public interface IVisionEquipmentViewOpenParam
{
	// Token: 0x17001901 RID: 6401
	// (get) Token: 0x06010555 RID: 66901
	// (set) Token: 0x06010556 RID: 66902
	int RoleId { get; set; }

	// Token: 0x17001902 RID: 6402
	// (get) Token: 0x06010557 RID: 66903
	// (set) Token: 0x06010558 RID: 66904
	int SelectIndex { get; set; }

	// Token: 0x17001903 RID: 6403
	// (get) Token: 0x06010559 RID: 66905
	// (set) Token: 0x0601055A RID: 66906
	ERoleViewSource? Source { get; set; }
}
