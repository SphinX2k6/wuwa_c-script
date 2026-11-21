using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005CA RID: 1482
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = false)]
	public sealed class DispIdAttribute : Attribute
	{
		// Token: 0x06007016 RID: 28694 RVA: 0x0010D9FA File Offset: 0x0010BBFA
		public DispIdAttribute(int dispId)
		{
			this.Value = dispId;
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06007017 RID: 28695 RVA: 0x0010DA09 File Offset: 0x0010BC09
		public int Value { get; }
	}
}
