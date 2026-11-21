using System;

// Token: 0x020026B1 RID: 9905
internal class IInputBehaviorPressState
{
	// Token: 0x17002774 RID: 10100
	// (get) Token: 0x06018D40 RID: 101696 RVA: 0x00789F46 File Offset: 0x00788146
	// (set) Token: 0x06018D41 RID: 101697 RVA: 0x00789F4E File Offset: 0x0078814E
	public double StartTime { get; set; }

	// Token: 0x17002775 RID: 10101
	// (get) Token: 0x06018D42 RID: 101698 RVA: 0x00789F57 File Offset: 0x00788157
	// (set) Token: 0x06018D43 RID: 101699 RVA: 0x00789F5F File Offset: 0x0078815F
	public bool PressedInNotify { get; set; }

	// Token: 0x17002776 RID: 10102
	// (get) Token: 0x06018D44 RID: 101700 RVA: 0x00789F68 File Offset: 0x00788168
	// (set) Token: 0x06018D45 RID: 101701 RVA: 0x00789F70 File Offset: 0x00788170
	public int PressId { get; set; }
}
