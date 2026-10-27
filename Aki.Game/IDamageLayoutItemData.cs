using System;

// Token: 0x020013FD RID: 5117
public interface IDamageLayoutItemData
{
	// Token: 0x17000C37 RID: 3127
	// (get) Token: 0x06009094 RID: 37012
	// (set) Token: 0x06009095 RID: 37013
	int RoleId { get; set; }

	// Token: 0x17000C38 RID: 3128
	// (get) Token: 0x06009096 RID: 37014
	// (set) Token: 0x06009097 RID: 37015
	float Damage { get; set; }

	// Token: 0x17000C39 RID: 3129
	// (get) Token: 0x06009098 RID: 37016
	// (set) Token: 0x06009099 RID: 37017
	bool IsWin { get; set; }
}
