using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005BB RID: 1467
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	public sealed class ComVisibleAttribute : Attribute
	{
		// Token: 0x06006FE9 RID: 28649 RVA: 0x0010D809 File Offset: 0x0010BA09
		public ComVisibleAttribute(bool visibility)
		{
			this.Value = visibility;
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06006FEA RID: 28650 RVA: 0x0010D818 File Offset: 0x0010BA18
		public bool Value { get; }
	}
}
