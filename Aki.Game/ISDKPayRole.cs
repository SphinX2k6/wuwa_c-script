using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E1E RID: 3614
[NullableContext(1)]
public interface ISDKPayRole
{
	// Token: 0x1700062C RID: 1580
	// (get) Token: 0x060056CD RID: 22221
	// (set) Token: 0x060056CE RID: 22222
	string serverId { get; set; }

	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x060056CF RID: 22223
	// (set) Token: 0x060056D0 RID: 22224
	string serverName { get; set; }

	// Token: 0x1700062E RID: 1582
	// (get) Token: 0x060056D1 RID: 22225
	// (set) Token: 0x060056D2 RID: 22226
	string roleId { get; set; }

	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x060056D3 RID: 22227
	// (set) Token: 0x060056D4 RID: 22228
	string roleName { get; set; }

	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x060056D5 RID: 22229
	// (set) Token: 0x060056D6 RID: 22230
	string roleLevel { get; set; }

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x060056D7 RID: 22231
	// (set) Token: 0x060056D8 RID: 22232
	string vipLevel { get; set; }

	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x060056D9 RID: 22233
	// (set) Token: 0x060056DA RID: 22234
	int setBalanceLevelOne { get; set; }

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x060056DB RID: 22235
	// (set) Token: 0x060056DC RID: 22236
	int setBalanceLevelTwo { get; set; }

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x060056DD RID: 22237
	// (set) Token: 0x060056DE RID: 22238
	string partyName { get; set; }
}
