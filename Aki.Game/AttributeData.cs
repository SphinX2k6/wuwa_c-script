using System;

// Token: 0x02000F05 RID: 3845
public class AttributeData : IAttributeData
{
	// Token: 0x17000781 RID: 1921
	// (get) Token: 0x060060A0 RID: 24736 RVA: 0x0012DB26 File Offset: 0x0012BD26
	// (set) Token: 0x060060A1 RID: 24737 RVA: 0x0012DB2E File Offset: 0x0012BD2E
	public float Max { get; set; }

	// Token: 0x17000782 RID: 1922
	// (get) Token: 0x060060A2 RID: 24738 RVA: 0x0012DB37 File Offset: 0x0012BD37
	// (set) Token: 0x060060A3 RID: 24739 RVA: 0x0012DB3F File Offset: 0x0012BD3F
	public float BaseMax { get; set; }

	// Token: 0x17000783 RID: 1923
	// (get) Token: 0x060060A4 RID: 24740 RVA: 0x0012DB48 File Offset: 0x0012BD48
	// (set) Token: 0x060060A5 RID: 24741 RVA: 0x0012DB50 File Offset: 0x0012BD50
	public float Value { get; set; }

	// Token: 0x17000784 RID: 1924
	// (get) Token: 0x060060A6 RID: 24742 RVA: 0x0012DB59 File Offset: 0x0012BD59
	// (set) Token: 0x060060A7 RID: 24743 RVA: 0x0012DB61 File Offset: 0x0012BD61
	public float Speed { get; set; }

	// Token: 0x17000785 RID: 1925
	// (get) Token: 0x060060A8 RID: 24744 RVA: 0x0012DB6A File Offset: 0x0012BD6A
	// (set) Token: 0x060060A9 RID: 24745 RVA: 0x0012DB72 File Offset: 0x0012BD72
	public float BaseSpeed { get; set; }

	// Token: 0x17000786 RID: 1926
	// (get) Token: 0x060060AA RID: 24746 RVA: 0x0012DB7B File Offset: 0x0012BD7B
	// (set) Token: 0x060060AB RID: 24747 RVA: 0x0012DB83 File Offset: 0x0012BD83
	public double Timestamp { get; set; }
}
