using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008BC RID: 2236
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	public sealed class UnconditionalSuppressMessageAttribute : Attribute
	{
		// Token: 0x06008A21 RID: 35361 RVA: 0x0014EB88 File Offset: 0x0014CD88
		[NullableContext(1)]
		public UnconditionalSuppressMessageAttribute(string category, string checkId)
		{
			this.Category = category;
			this.CheckId = checkId;
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06008A22 RID: 35362 RVA: 0x0014EB9E File Offset: 0x0014CD9E
		[Nullable(1)]
		public string Category { [NullableContext(1)] get; }

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06008A23 RID: 35363 RVA: 0x0014EBA6 File Offset: 0x0014CDA6
		[Nullable(1)]
		public string CheckId { [NullableContext(1)] get; }

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06008A24 RID: 35364 RVA: 0x0014EBAE File Offset: 0x0014CDAE
		// (set) Token: 0x06008A25 RID: 35365 RVA: 0x0014EBB6 File Offset: 0x0014CDB6
		public string Scope { get; set; }

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06008A26 RID: 35366 RVA: 0x0014EBBF File Offset: 0x0014CDBF
		// (set) Token: 0x06008A27 RID: 35367 RVA: 0x0014EBC7 File Offset: 0x0014CDC7
		public string Target { get; set; }

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06008A28 RID: 35368 RVA: 0x0014EBD0 File Offset: 0x0014CDD0
		// (set) Token: 0x06008A29 RID: 35369 RVA: 0x0014EBD8 File Offset: 0x0014CDD8
		public string MessageId { get; set; }

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06008A2A RID: 35370 RVA: 0x0014EBE1 File Offset: 0x0014CDE1
		// (set) Token: 0x06008A2B RID: 35371 RVA: 0x0014EBE9 File Offset: 0x0014CDE9
		public string Justification { get; set; }
	}
}
