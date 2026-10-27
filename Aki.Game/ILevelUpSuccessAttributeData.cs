using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200288C RID: 10380
[NullableContext(2)]
public interface ILevelUpSuccessAttributeData
{
	// Token: 0x17001CAB RID: 7339
	// (get) Token: 0x060155DA RID: 87514
	// (set) Token: 0x060155DB RID: 87515
	string Title { get; set; }

	// Token: 0x17001CAC RID: 7340
	// (get) Token: 0x060155DC RID: 87516
	// (set) Token: 0x060155DD RID: 87517
	string AudioId { get; set; }

	// Token: 0x17001CAD RID: 7341
	// (get) Token: 0x060155DE RID: 87518
	// (set) Token: 0x060155DF RID: 87519
	ILevelInfo LevelInfo { get; set; }

	// Token: 0x17001CAE RID: 7342
	// (get) Token: 0x060155E0 RID: 87520
	// (set) Token: 0x060155E1 RID: 87521
	[Nullable(1)]
	List<IAttributeInfo> AttributeInfo { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001CAF RID: 7343
	// (get) Token: 0x060155E2 RID: 87522
	// (set) Token: 0x060155E3 RID: 87523
	bool? IsShowArrow { get; set; }

	// Token: 0x17001CB0 RID: 7344
	// (get) Token: 0x060155E4 RID: 87524
	// (set) Token: 0x060155E5 RID: 87525
	string ClickText { get; set; }

	// Token: 0x17001CB1 RID: 7345
	// (get) Token: 0x060155E6 RID: 87526
	// (set) Token: 0x060155E7 RID: 87527
	Action ClickFunction { get; set; }

	// Token: 0x17001CB2 RID: 7346
	// (get) Token: 0x060155E8 RID: 87528
	// (set) Token: 0x060155E9 RID: 87529
	bool? WiderScrollView { get; set; }

	// Token: 0x17001CB3 RID: 7347
	// (get) Token: 0x060155EA RID: 87530
	// (set) Token: 0x060155EB RID: 87531
	IStrengthUpgradeData StrengthUpgradeData { get; set; }
}
