using System;
using System.Runtime.CompilerServices;

// Token: 0x020022BB RID: 8891
[NullableContext(1)]
public interface IWeeklyRogueRoleGroupTitleInfo
{
	// Token: 0x17002149 RID: 8521
	// (get) Token: 0x06015F7A RID: 89978
	// (set) Token: 0x06015F7B RID: 89979
	string TitleId { get; set; }

	// Token: 0x1700214A RID: 8522
	// (get) Token: 0x06015F7C RID: 89980
	// (set) Token: 0x06015F7D RID: 89981
	bool IsUp { get; set; }

	// Token: 0x1700214B RID: 8523
	// (get) Token: 0x06015F7E RID: 89982
	// (set) Token: 0x06015F7F RID: 89983
	int? ScoreRate { get; set; }

	// Token: 0x1700214C RID: 8524
	// (get) Token: 0x06015F80 RID: 89984
	// (set) Token: 0x06015F81 RID: 89985
	bool IsEmpty { get; set; }
}
