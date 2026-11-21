using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200069E RID: 1694
	[NullableContext(2)]
	public interface ICastable
	{
		// Token: 0x06007405 RID: 29701
		bool IsInstanceOfInterface(RuntimeTypeHandle interfaceType, [NotNullWhen(true)] out Exception castError);

		// Token: 0x06007406 RID: 29702
		RuntimeTypeHandle GetImplType(RuntimeTypeHandle interfaceType);
	}
}
