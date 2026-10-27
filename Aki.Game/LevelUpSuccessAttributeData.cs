using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200288D RID: 10381
[NullableContext(2)]
[Nullable(0)]
public class LevelUpSuccessAttributeData : ILevelUpSuccessAttributeData
{
	// Token: 0x17001CB4 RID: 7348
	// (get) Token: 0x060155EC RID: 87532 RVA: 0x00563564 File Offset: 0x00561764
	// (set) Token: 0x060155ED RID: 87533 RVA: 0x0056356C File Offset: 0x0056176C
	public string Title { get; set; }

	// Token: 0x17001CB5 RID: 7349
	// (get) Token: 0x060155EE RID: 87534 RVA: 0x00563575 File Offset: 0x00561775
	// (set) Token: 0x060155EF RID: 87535 RVA: 0x0056357D File Offset: 0x0056177D
	public string AudioId { get; set; }

	// Token: 0x17001CB6 RID: 7350
	// (get) Token: 0x060155F0 RID: 87536 RVA: 0x00563586 File Offset: 0x00561786
	// (set) Token: 0x060155F1 RID: 87537 RVA: 0x0056358E File Offset: 0x0056178E
	public ILevelInfo LevelInfo { get; set; }

	// Token: 0x17001CB7 RID: 7351
	// (get) Token: 0x060155F2 RID: 87538 RVA: 0x00563597 File Offset: 0x00561797
	// (set) Token: 0x060155F3 RID: 87539 RVA: 0x0056359F File Offset: 0x0056179F
	[Nullable(1)]
	public List<IAttributeInfo> AttributeInfo { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001CB8 RID: 7352
	// (get) Token: 0x060155F4 RID: 87540 RVA: 0x005635A8 File Offset: 0x005617A8
	// (set) Token: 0x060155F5 RID: 87541 RVA: 0x005635B0 File Offset: 0x005617B0
	public bool? IsShowArrow { get; set; }

	// Token: 0x17001CB9 RID: 7353
	// (get) Token: 0x060155F6 RID: 87542 RVA: 0x005635B9 File Offset: 0x005617B9
	// (set) Token: 0x060155F7 RID: 87543 RVA: 0x005635C1 File Offset: 0x005617C1
	public string ClickText { get; set; }

	// Token: 0x17001CBA RID: 7354
	// (get) Token: 0x060155F8 RID: 87544 RVA: 0x005635CA File Offset: 0x005617CA
	// (set) Token: 0x060155F9 RID: 87545 RVA: 0x005635D2 File Offset: 0x005617D2
	public Action ClickFunction { get; set; }

	// Token: 0x17001CBB RID: 7355
	// (get) Token: 0x060155FA RID: 87546 RVA: 0x005635DB File Offset: 0x005617DB
	// (set) Token: 0x060155FB RID: 87547 RVA: 0x005635E3 File Offset: 0x005617E3
	public bool? WiderScrollView { get; set; }

	// Token: 0x17001CBC RID: 7356
	// (get) Token: 0x060155FC RID: 87548 RVA: 0x005635EC File Offset: 0x005617EC
	// (set) Token: 0x060155FD RID: 87549 RVA: 0x005635F4 File Offset: 0x005617F4
	public IStrengthUpgradeData StrengthUpgradeData { get; set; }
}
