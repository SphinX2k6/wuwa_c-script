using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020021ED RID: 8685
[NullableContext(1)]
[Nullable(0)]
public class MarkPoolHandle : IMarkPoolHandle
{
	// Token: 0x17001571 RID: 5489
	// (get) Token: 0x06010E69 RID: 69225 RVA: 0x0041CD70 File Offset: 0x0041AF70
	// (set) Token: 0x06010E6A RID: 69226 RVA: 0x0041CD78 File Offset: 0x0041AF78
	public double RecycleTimeStamp { get; set; }

	// Token: 0x17001572 RID: 5490
	// (get) Token: 0x06010E6B RID: 69227 RVA: 0x0041CD81 File Offset: 0x0041AF81
	// (set) Token: 0x06010E6C RID: 69228 RVA: 0x0041CD89 File Offset: 0x0041AF89
	public MarkPanelBase Obj { get; set; }

	// Token: 0x17001573 RID: 5491
	// (get) Token: 0x06010E6D RID: 69229 RVA: 0x0041CD92 File Offset: 0x0041AF92
	// (set) Token: 0x06010E6E RID: 69230 RVA: 0x0041CD9A File Offset: 0x0041AF9A
	public int? RefCount { get; set; }
}
