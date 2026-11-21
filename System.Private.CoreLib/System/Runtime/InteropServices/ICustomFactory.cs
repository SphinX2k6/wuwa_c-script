using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005D4 RID: 1492
	[NullableContext(1)]
	public interface ICustomFactory
	{
		// Token: 0x0600702F RID: 28719
		MarshalByRefObject CreateInstance(Type serverType);
	}
}
