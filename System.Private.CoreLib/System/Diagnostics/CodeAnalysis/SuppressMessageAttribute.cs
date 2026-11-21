using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008BB RID: 2235
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	[Conditional("CODE_ANALYSIS")]
	public sealed class SuppressMessageAttribute : Attribute
	{
		// Token: 0x06008A16 RID: 35350 RVA: 0x0014EB1E File Offset: 0x0014CD1E
		[NullableContext(1)]
		public SuppressMessageAttribute(string category, string checkId)
		{
			this.Category = category;
			this.CheckId = checkId;
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06008A17 RID: 35351 RVA: 0x0014EB34 File Offset: 0x0014CD34
		[Nullable(1)]
		public string Category { [NullableContext(1)] get; }

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06008A18 RID: 35352 RVA: 0x0014EB3C File Offset: 0x0014CD3C
		[Nullable(1)]
		public string CheckId { [NullableContext(1)] get; }

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06008A19 RID: 35353 RVA: 0x0014EB44 File Offset: 0x0014CD44
		// (set) Token: 0x06008A1A RID: 35354 RVA: 0x0014EB4C File Offset: 0x0014CD4C
		public string Scope { get; set; }

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06008A1B RID: 35355 RVA: 0x0014EB55 File Offset: 0x0014CD55
		// (set) Token: 0x06008A1C RID: 35356 RVA: 0x0014EB5D File Offset: 0x0014CD5D
		public string Target { get; set; }

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06008A1D RID: 35357 RVA: 0x0014EB66 File Offset: 0x0014CD66
		// (set) Token: 0x06008A1E RID: 35358 RVA: 0x0014EB6E File Offset: 0x0014CD6E
		public string MessageId { get; set; }

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x0014EB77 File Offset: 0x0014CD77
		// (set) Token: 0x06008A20 RID: 35360 RVA: 0x0014EB7F File Offset: 0x0014CD7F
		public string Justification { get; set; }
	}
}
