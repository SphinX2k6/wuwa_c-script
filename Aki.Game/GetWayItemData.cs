using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D8D RID: 3469
[NullableContext(1)]
[Nullable(0)]
public class GetWayItemData : IGetWayItemData
{
	// Token: 0x17000F94 RID: 3988
	// (get) Token: 0x06008E5D RID: 36445 RVA: 0x002AE15F File Offset: 0x002AC35F
	// (set) Token: 0x06008E5E RID: 36446 RVA: 0x002AE167 File Offset: 0x002AC367
	public int Id { get; set; }

	// Token: 0x17000F95 RID: 3989
	// (get) Token: 0x06008E5F RID: 36447 RVA: 0x002AE170 File Offset: 0x002AC370
	// (set) Token: 0x06008E60 RID: 36448 RVA: 0x002AE178 File Offset: 0x002AC378
	public EGetWayItemType Type { get; set; }

	// Token: 0x17000F96 RID: 3990
	// (get) Token: 0x06008E61 RID: 36449 RVA: 0x002AE181 File Offset: 0x002AC381
	// (set) Token: 0x06008E62 RID: 36450 RVA: 0x002AE189 File Offset: 0x002AC389
	public string Text { get; set; }

	// Token: 0x17000F97 RID: 3991
	// (get) Token: 0x06008E63 RID: 36451 RVA: 0x002AE192 File Offset: 0x002AC392
	// (set) Token: 0x06008E64 RID: 36452 RVA: 0x002AE19A File Offset: 0x002AC39A
	public int SortIndex { get; set; }

	// Token: 0x17000F98 RID: 3992
	// (get) Token: 0x06008E65 RID: 36453 RVA: 0x002AE1A3 File Offset: 0x002AC3A3
	// (set) Token: 0x06008E66 RID: 36454 RVA: 0x002AE1AB File Offset: 0x002AC3AB
	public Action Function { get; set; }

	// Token: 0x06008E67 RID: 36455 RVA: 0x002AE1B4 File Offset: 0x002AC3B4
	public GetWayItemData(int id, EGetWayItemType type, string text, int sortIndex, Action function)
	{
		this.Id = id;
		this.Type = type;
		this.Text = text;
		this.SortIndex = sortIndex;
		this.Function = function;
	}
}
