using System;
using System.Runtime.CompilerServices;

// Token: 0x020018D4 RID: 6356
[NullableContext(1)]
[Nullable(0)]
public class GetWayItemData : IGetWayItemData
{
	// Token: 0x17000F71 RID: 3953
	// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x002A3A07 File Offset: 0x002A1C07
	// (set) Token: 0x0600BA75 RID: 47733 RVA: 0x002A3A0F File Offset: 0x002A1C0F
	public int Id { get; set; }

	// Token: 0x17000F72 RID: 3954
	// (get) Token: 0x0600BA76 RID: 47734 RVA: 0x002A3A18 File Offset: 0x002A1C18
	// (set) Token: 0x0600BA77 RID: 47735 RVA: 0x002A3A20 File Offset: 0x002A1C20
	public EGetWayItemType Type { get; set; }

	// Token: 0x17000F73 RID: 3955
	// (get) Token: 0x0600BA78 RID: 47736 RVA: 0x002A3A29 File Offset: 0x002A1C29
	// (set) Token: 0x0600BA79 RID: 47737 RVA: 0x002A3A31 File Offset: 0x002A1C31
	public string Text { get; set; }

	// Token: 0x17000F74 RID: 3956
	// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x002A3A3A File Offset: 0x002A1C3A
	// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x002A3A42 File Offset: 0x002A1C42
	public int SortIndex { get; set; }

	// Token: 0x17000F75 RID: 3957
	// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x002A3A4B File Offset: 0x002A1C4B
	// (set) Token: 0x0600BA7D RID: 47741 RVA: 0x002A3A53 File Offset: 0x002A1C53
	public Action Function { get; set; }

	// Token: 0x0600BA7E RID: 47742 RVA: 0x002A3A5C File Offset: 0x002A1C5C
	public GetWayItemData(int id, EGetWayItemType type, string text, int sortIndex, Action function)
	{
		this.Id = id;
		this.Type = type;
		this.Text = text;
		this.SortIndex = sortIndex;
		this.Function = function;
	}
}
