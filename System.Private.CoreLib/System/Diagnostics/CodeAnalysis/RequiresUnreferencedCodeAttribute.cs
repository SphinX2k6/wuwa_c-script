using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008B8 RID: 2232
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	public sealed class RequiresUnreferencedCodeAttribute : Attribute
	{
		// Token: 0x06008A0D RID: 35341 RVA: 0x0014EAB6 File Offset: 0x0014CCB6
		public RequiresUnreferencedCodeAttribute(string message)
		{
			this.Message = message;
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06008A0E RID: 35342 RVA: 0x0014EAC5 File Offset: 0x0014CCC5
		public string Message { get; }

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06008A0F RID: 35343 RVA: 0x0014EACD File Offset: 0x0014CCCD
		// (set) Token: 0x06008A10 RID: 35344 RVA: 0x0014EAD5 File Offset: 0x0014CCD5
		[Nullable(2)]
		public string Url { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
