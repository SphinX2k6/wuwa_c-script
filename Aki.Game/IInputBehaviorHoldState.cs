using System;
using CSharpScript.Game.Input;

// Token: 0x020026B5 RID: 9909
public class IInputBehaviorHoldState
{
	// Token: 0x1700277C RID: 10108
	// (get) Token: 0x06018D5D RID: 101725 RVA: 0x0078A5E8 File Offset: 0x007887E8
	// (set) Token: 0x06018D5E RID: 101726 RVA: 0x0078A5F0 File Offset: 0x007887F0
	public EInputAction Action { get; set; }

	// Token: 0x1700277D RID: 10109
	// (get) Token: 0x06018D5F RID: 101727 RVA: 0x0078A5F9 File Offset: 0x007887F9
	// (set) Token: 0x06018D60 RID: 101728 RVA: 0x0078A601 File Offset: 0x00788801
	public double HoldDuration { get; set; }

	// Token: 0x1700277E RID: 10110
	// (get) Token: 0x06018D61 RID: 101729 RVA: 0x0078A60A File Offset: 0x0078880A
	// (set) Token: 0x06018D62 RID: 101730 RVA: 0x0078A612 File Offset: 0x00788812
	public bool PressedInNotify { get; set; }

	// Token: 0x1700277F RID: 10111
	// (get) Token: 0x06018D63 RID: 101731 RVA: 0x0078A61B File Offset: 0x0078881B
	// (set) Token: 0x06018D64 RID: 101732 RVA: 0x0078A623 File Offset: 0x00788823
	public int PressId { get; set; }
}
