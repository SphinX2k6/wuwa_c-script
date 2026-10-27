using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001732 RID: 5938
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineResultViewParam : IVisionRefineResultViewParam
{
	// Token: 0x17000E4A RID: 3658
	// (get) Token: 0x0600AB9F RID: 43935 RVA: 0x00267DD9 File Offset: 0x00265FD9
	// (set) Token: 0x0600ABA0 RID: 43936 RVA: 0x00267DE1 File Offset: 0x00265FE1
	public PhantomPolishResponse Response { get; set; }

	// Token: 0x17000E4B RID: 3659
	// (get) Token: 0x0600ABA1 RID: 43937 RVA: 0x00267DEA File Offset: 0x00265FEA
	// (set) Token: 0x0600ABA2 RID: 43938 RVA: 0x00267DF2 File Offset: 0x00265FF2
	public PhantomBatchPolishResponse ResponseBatch { get; set; }

	// Token: 0x17000E4C RID: 3660
	// (get) Token: 0x0600ABA3 RID: 43939 RVA: 0x00267DFB File Offset: 0x00265FFB
	// (set) Token: 0x0600ABA4 RID: 43940 RVA: 0x00267E03 File Offset: 0x00266003
	public bool ShowTips { get; set; }

	// Token: 0x17000E4D RID: 3661
	// (get) Token: 0x0600ABA5 RID: 43941 RVA: 0x00267E0C File Offset: 0x0026600C
	// (set) Token: 0x0600ABA6 RID: 43942 RVA: 0x00267E14 File Offset: 0x00266014
	public int? PropIndexId { get; set; }
}
