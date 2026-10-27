using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001401 RID: 5121
[NullableContext(1)]
public interface IPinballSettleResultViewParam
{
	// Token: 0x17000C3A RID: 3130
	// (get) Token: 0x0600909A RID: 37018
	// (set) Token: 0x0600909B RID: 37019
	int LevelId { get; set; }

	// Token: 0x17000C3B RID: 3131
	// (get) Token: 0x0600909C RID: 37020
	// (set) Token: 0x0600909D RID: 37021
	EPinballLevelShowType LevelType { get; set; }

	// Token: 0x17000C3C RID: 3132
	// (get) Token: 0x0600909E RID: 37022
	// (set) Token: 0x0600909F RID: 37023
	bool IsWin { get; set; }

	// Token: 0x17000C3D RID: 3133
	// (get) Token: 0x060090A0 RID: 37024
	// (set) Token: 0x060090A1 RID: 37025
	int MostValuablePlayerRoleId { get; set; }

	// Token: 0x17000C3E RID: 3134
	// (get) Token: 0x060090A2 RID: 37026
	// (set) Token: 0x060090A3 RID: 37027
	Dictionary<int, float> Roles { get; set; }

	// Token: 0x17000C3F RID: 3135
	// (get) Token: 0x060090A4 RID: 37028
	// (set) Token: 0x060090A5 RID: 37029
	bool[] StarInfo { get; set; }

	// Token: 0x17000C40 RID: 3136
	// (get) Token: 0x060090A6 RID: 37030
	// (set) Token: 0x060090A7 RID: 37031
	int Score { get; set; }

	// Token: 0x17000C41 RID: 3137
	// (get) Token: 0x060090A8 RID: 37032
	// (set) Token: 0x060090A9 RID: 37033
	bool IsFirstPass { get; set; }
}
