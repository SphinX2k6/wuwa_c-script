using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008B7 RID: 2231
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	public sealed class RequiresDynamicCodeAttribute : Attribute
	{
		// Token: 0x06008A09 RID: 35337 RVA: 0x0014EA8E File Offset: 0x0014CC8E
		public RequiresDynamicCodeAttribute(string message)
		{
			this.Message = message;
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06008A0A RID: 35338 RVA: 0x0014EA9D File Offset: 0x0014CC9D
		public string Message { get; }

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06008A0B RID: 35339 RVA: 0x0014EAA5 File Offset: 0x0014CCA5
		// (set) Token: 0x06008A0C RID: 35340 RVA: 0x0014EAAD File Offset: 0x0014CCAD
		[Nullable(2)]
		public string Url { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
