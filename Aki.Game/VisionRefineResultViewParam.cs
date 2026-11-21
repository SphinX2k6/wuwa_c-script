using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000BEB RID: 3051
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineResultViewParam : IVisionRefineResultViewParam
{
	// Token: 0x17000E6D RID: 3693
	// (get) Token: 0x06007F86 RID: 32646 RVA: 0x002721DB File Offset: 0x002703DB
	// (set) Token: 0x06007F87 RID: 32647 RVA: 0x002721E3 File Offset: 0x002703E3
	public PhantomPolishResponse Response { get; set; }

	// Token: 0x17000E6E RID: 3694
	// (get) Token: 0x06007F88 RID: 32648 RVA: 0x002721EC File Offset: 0x002703EC
	// (set) Token: 0x06007F89 RID: 32649 RVA: 0x002721F4 File Offset: 0x002703F4
	public PhantomBatchPolishResponse ResponseBatch { get; set; }

	// Token: 0x17000E6F RID: 3695
	// (get) Token: 0x06007F8A RID: 32650 RVA: 0x002721FD File Offset: 0x002703FD
	// (set) Token: 0x06007F8B RID: 32651 RVA: 0x00272205 File Offset: 0x00270405
	public bool ShowTips { get; set; }

	// Token: 0x17000E70 RID: 3696
	// (get) Token: 0x06007F8C RID: 32652 RVA: 0x0027220E File Offset: 0x0027040E
	// (set) Token: 0x06007F8D RID: 32653 RVA: 0x00272216 File Offset: 0x00270416
	public int? PropIndexId { get; set; }
}
