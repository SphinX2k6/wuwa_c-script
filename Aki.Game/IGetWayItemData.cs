using System;
using System.Runtime.CompilerServices;

// Token: 0x020018D3 RID: 6355
[NullableContext(1)]
public interface IGetWayItemData
{
	// Token: 0x17000F6C RID: 3948
	// (get) Token: 0x0600BA6A RID: 47722
	// (set) Token: 0x0600BA6B RID: 47723
	int Id { get; set; }

	// Token: 0x17000F6D RID: 3949
	// (get) Token: 0x0600BA6C RID: 47724
	// (set) Token: 0x0600BA6D RID: 47725
	EGetWayItemType Type { get; set; }

	// Token: 0x17000F6E RID: 3950
	// (get) Token: 0x0600BA6E RID: 47726
	// (set) Token: 0x0600BA6F RID: 47727
	string Text { get; set; }

	// Token: 0x17000F6F RID: 3951
	// (get) Token: 0x0600BA70 RID: 47728
	// (set) Token: 0x0600BA71 RID: 47729
	int SortIndex { get; set; }

	// Token: 0x17000F70 RID: 3952
	// (get) Token: 0x0600BA72 RID: 47730
	// (set) Token: 0x0600BA73 RID: 47731
	Action Function { get; set; }
}
