using System;

// Token: 0x020024FE RID: 9470
public interface IVisionEquipmentViewOpenParam
{
	// Token: 0x170018C7 RID: 6343
	// (get) Token: 0x06013096 RID: 77974
	// (set) Token: 0x06013097 RID: 77975
	int RoleId { get; set; }

	// Token: 0x170018C8 RID: 6344
	// (get) Token: 0x06013098 RID: 77976
	// (set) Token: 0x06013099 RID: 77977
	int SelectIndex { get; set; }

	// Token: 0x170018C9 RID: 6345
	// (get) Token: 0x0601309A RID: 77978
	// (set) Token: 0x0601309B RID: 77979
	ERoleViewSource? Source { get; set; }
}
