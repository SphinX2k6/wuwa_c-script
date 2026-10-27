using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D3C RID: 11580
[NullableContext(2)]
public interface IWeeklyRogueRolePosInfo
{
	// Token: 0x170020D3 RID: 8403
	// (get) Token: 0x06018579 RID: 99705
	// (set) Token: 0x0601857A RID: 99706
	RoleDataBase Data { get; set; }

	// Token: 0x170020D4 RID: 8404
	// (get) Token: 0x0601857B RID: 99707
	// (set) Token: 0x0601857C RID: 99708
	bool? IsRecommend { get; set; }
}
