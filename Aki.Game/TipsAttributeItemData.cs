using System;
using System.Runtime.CompilerServices;

// Token: 0x020018D6 RID: 6358
[NullableContext(1)]
[Nullable(0)]
public class TipsAttributeItemData : ITipsAttributeItemData
{
	// Token: 0x17000F7C RID: 3964
	// (get) Token: 0x0600BA8B RID: 47755 RVA: 0x002A3A89 File Offset: 0x002A1C89
	// (set) Token: 0x0600BA8C RID: 47756 RVA: 0x002A3A91 File Offset: 0x002A1C91
	public int Id { get; set; }

	// Token: 0x17000F7D RID: 3965
	// (get) Token: 0x0600BA8D RID: 47757 RVA: 0x002A3A9A File Offset: 0x002A1C9A
	// (set) Token: 0x0600BA8E RID: 47758 RVA: 0x002A3AA2 File Offset: 0x002A1CA2
	public bool IsMainAttribute { get; set; }

	// Token: 0x17000F7E RID: 3966
	// (get) Token: 0x0600BA8F RID: 47759 RVA: 0x002A3AAB File Offset: 0x002A1CAB
	// (set) Token: 0x0600BA90 RID: 47760 RVA: 0x002A3AB3 File Offset: 0x002A1CB3
	public string Name { get; set; }

	// Token: 0x17000F7F RID: 3967
	// (get) Token: 0x0600BA91 RID: 47761 RVA: 0x002A3ABC File Offset: 0x002A1CBC
	// (set) Token: 0x0600BA92 RID: 47762 RVA: 0x002A3AC4 File Offset: 0x002A1CC4
	public string IconPath { get; set; }

	// Token: 0x17000F80 RID: 3968
	// (get) Token: 0x0600BA93 RID: 47763 RVA: 0x002A3ACD File Offset: 0x002A1CCD
	// (set) Token: 0x0600BA94 RID: 47764 RVA: 0x002A3AD5 File Offset: 0x002A1CD5
	public double Value { get; set; }

	// Token: 0x17000F81 RID: 3969
	// (get) Token: 0x0600BA95 RID: 47765 RVA: 0x002A3ADE File Offset: 0x002A1CDE
	// (set) Token: 0x0600BA96 RID: 47766 RVA: 0x002A3AE6 File Offset: 0x002A1CE6
	public bool IsRatio { get; set; }
}
