using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008B3 RID: 2227
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public sealed class MemberNotNullAttribute : Attribute
	{
		// Token: 0x060089FC RID: 35324 RVA: 0x0014E9F2 File Offset: 0x0014CBF2
		public MemberNotNullAttribute(string member)
		{
			this.Members = new string[]
			{
				member
			};
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x0014EA0A File Offset: 0x0014CC0A
		public MemberNotNullAttribute(params string[] members)
		{
			this.Members = members;
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x060089FE RID: 35326 RVA: 0x0014EA19 File Offset: 0x0014CC19
		public string[] Members { get; }
	}
}
