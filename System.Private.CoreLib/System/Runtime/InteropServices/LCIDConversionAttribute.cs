using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005DE RID: 1502
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class LCIDConversionAttribute : Attribute
	{
		// Token: 0x06007045 RID: 28741 RVA: 0x0010DCB7 File Offset: 0x0010BEB7
		public LCIDConversionAttribute(int lcid)
		{
			this.Value = lcid;
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06007046 RID: 28742 RVA: 0x0010DCC6 File Offset: 0x0010BEC6
		public int Value { get; }
	}
}
