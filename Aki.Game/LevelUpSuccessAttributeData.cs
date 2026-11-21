using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E08 RID: 7688
[NullableContext(2)]
[Nullable(0)]
public class LevelUpSuccessAttributeData : ILevelUpSuccessAttributeData
{
	// Token: 0x17001D0C RID: 7436
	// (get) Token: 0x06012FEA RID: 77802 RVA: 0x0058E2C0 File Offset: 0x0058C4C0
	// (set) Token: 0x06012FEB RID: 77803 RVA: 0x0058E2C8 File Offset: 0x0058C4C8
	public string Title { get; set; }

	// Token: 0x17001D0D RID: 7437
	// (get) Token: 0x06012FEC RID: 77804 RVA: 0x0058E2D1 File Offset: 0x0058C4D1
	// (set) Token: 0x06012FED RID: 77805 RVA: 0x0058E2D9 File Offset: 0x0058C4D9
	public string AudioId { get; set; }

	// Token: 0x17001D0E RID: 7438
	// (get) Token: 0x06012FEE RID: 77806 RVA: 0x0058E2E2 File Offset: 0x0058C4E2
	// (set) Token: 0x06012FEF RID: 77807 RVA: 0x0058E2EA File Offset: 0x0058C4EA
	public ILevelInfo LevelInfo { get; set; }

	// Token: 0x17001D0F RID: 7439
	// (get) Token: 0x06012FF0 RID: 77808 RVA: 0x0058E2F3 File Offset: 0x0058C4F3
	// (set) Token: 0x06012FF1 RID: 77809 RVA: 0x0058E2FB File Offset: 0x0058C4FB
	[Nullable(1)]
	public List<IAttributeInfo> AttributeInfo { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001D10 RID: 7440
	// (get) Token: 0x06012FF2 RID: 77810 RVA: 0x0058E304 File Offset: 0x0058C504
	// (set) Token: 0x06012FF3 RID: 77811 RVA: 0x0058E30C File Offset: 0x0058C50C
	public bool? IsShowArrow { get; set; }

	// Token: 0x17001D11 RID: 7441
	// (get) Token: 0x06012FF4 RID: 77812 RVA: 0x0058E315 File Offset: 0x0058C515
	// (set) Token: 0x06012FF5 RID: 77813 RVA: 0x0058E31D File Offset: 0x0058C51D
	public string ClickText { get; set; }

	// Token: 0x17001D12 RID: 7442
	// (get) Token: 0x06012FF6 RID: 77814 RVA: 0x0058E326 File Offset: 0x0058C526
	// (set) Token: 0x06012FF7 RID: 77815 RVA: 0x0058E32E File Offset: 0x0058C52E
	public Action ClickFunction { get; set; }

	// Token: 0x17001D13 RID: 7443
	// (get) Token: 0x06012FF8 RID: 77816 RVA: 0x0058E337 File Offset: 0x0058C537
	// (set) Token: 0x06012FF9 RID: 77817 RVA: 0x0058E33F File Offset: 0x0058C53F
	public bool? WiderScrollView { get; set; }

	// Token: 0x17001D14 RID: 7444
	// (get) Token: 0x06012FFA RID: 77818 RVA: 0x0058E348 File Offset: 0x0058C548
	// (set) Token: 0x06012FFB RID: 77819 RVA: 0x0058E350 File Offset: 0x0058C550
	public IStrengthUpgradeData StrengthUpgradeData { get; set; }
}
