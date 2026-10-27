using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002000 RID: 8192
[NullableContext(2)]
[Nullable(0)]
public class ItemHintPanelData<[Nullable(0)] T, TData> : IItemHintPanelData<T, TData> where T : ItemHintItemBase<TData>
{
	// Token: 0x1700137D RID: 4989
	// (get) Token: 0x060100FD RID: 65789 RVA: 0x003E9FFD File Offset: 0x003E81FD
	// (set) Token: 0x060100FE RID: 65790 RVA: 0x003EA005 File Offset: 0x003E8205
	[Nullable(1)]
	public Func<TData> ShiftItem { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700137E RID: 4990
	// (get) Token: 0x060100FF RID: 65791 RVA: 0x003EA00E File Offset: 0x003E820E
	// (set) Token: 0x06010100 RID: 65792 RVA: 0x003EA016 File Offset: 0x003E8216
	[Nullable(1)]
	public Func<bool> CheckNext { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700137F RID: 4991
	// (get) Token: 0x06010101 RID: 65793 RVA: 0x003EA01F File Offset: 0x003E821F
	// (set) Token: 0x06010102 RID: 65794 RVA: 0x003EA027 File Offset: 0x003E8227
	[Nullable(1)]
	public Func<T> CreateProxyFunction { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001380 RID: 4992
	// (get) Token: 0x06010103 RID: 65795 RVA: 0x003EA030 File Offset: 0x003E8230
	// (set) Token: 0x06010104 RID: 65796 RVA: 0x003EA038 File Offset: 0x003E8238
	public UUIItem ChildTemplate { get; set; }

	// Token: 0x17001381 RID: 4993
	// (get) Token: 0x06010105 RID: 65797 RVA: 0x003EA041 File Offset: 0x003E8241
	// (set) Token: 0x06010106 RID: 65798 RVA: 0x003EA049 File Offset: 0x003E8249
	public string ChildResourceId { get; set; }

	// Token: 0x17001382 RID: 4994
	// (get) Token: 0x06010107 RID: 65799 RVA: 0x003EA052 File Offset: 0x003E8252
	// (set) Token: 0x06010108 RID: 65800 RVA: 0x003EA05A File Offset: 0x003E825A
	public string TitleTextId { get; set; }

	// Token: 0x17001383 RID: 4995
	// (get) Token: 0x06010109 RID: 65801 RVA: 0x003EA063 File Offset: 0x003E8263
	// (set) Token: 0x0601010A RID: 65802 RVA: 0x003EA06B File Offset: 0x003E826B
	public int? MaxShowCount { get; set; }

	// Token: 0x17001384 RID: 4996
	// (get) Token: 0x0601010B RID: 65803 RVA: 0x003EA074 File Offset: 0x003E8274
	// (set) Token: 0x0601010C RID: 65804 RVA: 0x003EA07C File Offset: 0x003E827C
	public int? AddItemTime { get; set; }

	// Token: 0x17001385 RID: 4997
	// (get) Token: 0x0601010D RID: 65805 RVA: 0x003EA085 File Offset: 0x003E8285
	// (set) Token: 0x0601010E RID: 65806 RVA: 0x003EA08D File Offset: 0x003E828D
	public int? ItemSliderTime { get; set; }

	// Token: 0x17001386 RID: 4998
	// (get) Token: 0x0601010F RID: 65807 RVA: 0x003EA096 File Offset: 0x003E8296
	// (set) Token: 0x06010110 RID: 65808 RVA: 0x003EA09E File Offset: 0x003E829E
	public int? ItemShowTime { get; set; }

	// Token: 0x17001387 RID: 4999
	// (get) Token: 0x06010111 RID: 65809 RVA: 0x003EA0A7 File Offset: 0x003E82A7
	// (set) Token: 0x06010112 RID: 65810 RVA: 0x003EA0AF File Offset: 0x003E82AF
	public ESliderMode? SliderMode { get; set; }

	// Token: 0x17001388 RID: 5000
	// (get) Token: 0x06010113 RID: 65811 RVA: 0x003EA0B8 File Offset: 0x003E82B8
	// (set) Token: 0x06010114 RID: 65812 RVA: 0x003EA0C0 File Offset: 0x003E82C0
	public ETickItemMode? TickMode { get; set; }

	// Token: 0x17001389 RID: 5001
	// (get) Token: 0x06010115 RID: 65813 RVA: 0x003EA0C9 File Offset: 0x003E82C9
	// (set) Token: 0x06010116 RID: 65814 RVA: 0x003EA0D1 File Offset: 0x003E82D1
	public Action FinishCallback { get; set; }
}
