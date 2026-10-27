using System;
using System.Runtime.CompilerServices;

// Token: 0x02002887 RID: 10375
[NullableContext(2)]
[Nullable(0)]
public class AttributeInfo : IAttributeInfo
{
	// Token: 0x17001C91 RID: 7313
	// (get) Token: 0x060155A3 RID: 87459 RVA: 0x0056342B File Offset: 0x0056162B
	// (set) Token: 0x060155A4 RID: 87460 RVA: 0x00563433 File Offset: 0x00561633
	public string Name { get; set; }

	// Token: 0x17001C92 RID: 7314
	// (get) Token: 0x060155A5 RID: 87461 RVA: 0x0056343C File Offset: 0x0056163C
	// (set) Token: 0x060155A6 RID: 87462 RVA: 0x00563444 File Offset: 0x00561644
	public string IconPath { get; set; }

	// Token: 0x17001C93 RID: 7315
	// (get) Token: 0x060155A7 RID: 87463 RVA: 0x0056344D File Offset: 0x0056164D
	// (set) Token: 0x060155A8 RID: 87464 RVA: 0x00563455 File Offset: 0x00561655
	public bool? ShowArrow { get; set; }

	// Token: 0x17001C94 RID: 7316
	// (get) Token: 0x060155A9 RID: 87465 RVA: 0x0056345E File Offset: 0x0056165E
	// (set) Token: 0x060155AA RID: 87466 RVA: 0x00563466 File Offset: 0x00561666
	public string PreText { get; set; }

	// Token: 0x17001C95 RID: 7317
	// (get) Token: 0x060155AB RID: 87467 RVA: 0x0056346F File Offset: 0x0056166F
	// (set) Token: 0x060155AC RID: 87468 RVA: 0x00563477 File Offset: 0x00561677
	public string CurText { get; set; }

	// Token: 0x17001C96 RID: 7318
	// (get) Token: 0x060155AD RID: 87469 RVA: 0x00563480 File Offset: 0x00561680
	// (set) Token: 0x060155AE RID: 87470 RVA: 0x00563488 File Offset: 0x00561688
	public bool? IsNormalBg { get; set; }

	// Token: 0x17001C97 RID: 7319
	// (get) Token: 0x060155AF RID: 87471 RVA: 0x00563491 File Offset: 0x00561691
	// (set) Token: 0x060155B0 RID: 87472 RVA: 0x00563499 File Offset: 0x00561699
	public bool? InnerShowBg { get; set; }

	// Token: 0x17001C98 RID: 7320
	// (get) Token: 0x060155B1 RID: 87473 RVA: 0x005634A2 File Offset: 0x005616A2
	// (set) Token: 0x060155B2 RID: 87474 RVA: 0x005634AA File Offset: 0x005616AA
	public bool? IsLine { get; set; }
}
