using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005DA RID: 1498
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	public sealed class InterfaceTypeAttribute : Attribute
	{
		// Token: 0x0600703A RID: 28730 RVA: 0x0010DBFA File Offset: 0x0010BDFA
		public InterfaceTypeAttribute(ComInterfaceType interfaceType)
		{
			this.Value = interfaceType;
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x0010DBFA File Offset: 0x0010BDFA
		public InterfaceTypeAttribute(short interfaceType)
		{
			this.Value = interfaceType;
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600703C RID: 28732 RVA: 0x0010DC09 File Offset: 0x0010BE09
		public ComInterfaceType Value { get; }
	}
}
