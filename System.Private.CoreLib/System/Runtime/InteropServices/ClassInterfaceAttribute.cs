using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005AF RID: 1455
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, Inherited = false)]
	public sealed class ClassInterfaceAttribute : Attribute
	{
		// Token: 0x06006FC5 RID: 28613 RVA: 0x0010D41B File Offset: 0x0010B61B
		public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
		{
			this.Value = classInterfaceType;
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x0010D41B File Offset: 0x0010B61B
		public ClassInterfaceAttribute(short classInterfaceType)
		{
			this.Value = classInterfaceType;
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06006FC7 RID: 28615 RVA: 0x0010D42A File Offset: 0x0010B62A
		public ClassInterfaceType Value { get; }
	}
}
