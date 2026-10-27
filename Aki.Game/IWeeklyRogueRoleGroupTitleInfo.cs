using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D61 RID: 11617
[NullableContext(1)]
public interface IWeeklyRogueRoleGroupTitleInfo
{
	// Token: 0x170020EE RID: 8430
	// (get) Token: 0x060186D8 RID: 100056
	// (set) Token: 0x060186D9 RID: 100057
	string TitleId { get; set; }

	// Token: 0x170020EF RID: 8431
	// (get) Token: 0x060186DA RID: 100058
	// (set) Token: 0x060186DB RID: 100059
	bool IsUp { get; set; }

	// Token: 0x170020F0 RID: 8432
	// (get) Token: 0x060186DC RID: 100060
	// (set) Token: 0x060186DD RID: 100061
	int? ScoreRate { get; set; }

	// Token: 0x170020F1 RID: 8433
	// (get) Token: 0x060186DE RID: 100062
	// (set) Token: 0x060186DF RID: 100063
	bool IsEmpty { get; set; }
}
