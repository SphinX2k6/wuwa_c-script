using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008B6 RID: 2230
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
	public sealed class RequiresAssemblyFilesAttribute : Attribute
	{
		// Token: 0x06008A04 RID: 35332 RVA: 0x00022817 File Offset: 0x00020A17
		public RequiresAssemblyFilesAttribute()
		{
		}

		// Token: 0x06008A05 RID: 35333 RVA: 0x0014EA66 File Offset: 0x0014CC66
		[NullableContext(1)]
		public RequiresAssemblyFilesAttribute(string message)
		{
			this.Message = message;
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06008A06 RID: 35334 RVA: 0x0014EA75 File Offset: 0x0014CC75
		public string Message { get; }

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06008A07 RID: 35335 RVA: 0x0014EA7D File Offset: 0x0014CC7D
		// (set) Token: 0x06008A08 RID: 35336 RVA: 0x0014EA85 File Offset: 0x0014CC85
		public string Url { get; set; }
	}
}
