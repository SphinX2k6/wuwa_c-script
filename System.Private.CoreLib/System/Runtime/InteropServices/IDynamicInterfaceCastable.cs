using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005D7 RID: 1495
	public interface IDynamicInterfaceCastable
	{
		// Token: 0x06007036 RID: 28726
		bool IsInterfaceImplemented(RuntimeTypeHandle interfaceType, bool throwIfNotImplemented);

		// Token: 0x06007037 RID: 28727
		RuntimeTypeHandle GetInterfaceImplementation(RuntimeTypeHandle interfaceType);
	}
}
