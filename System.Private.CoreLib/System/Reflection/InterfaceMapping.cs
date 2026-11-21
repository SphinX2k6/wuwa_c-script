using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000747 RID: 1863
	[NullableContext(1)]
	[Nullable(0)]
	public struct InterfaceMapping
	{
		// Token: 0x04001679 RID: 5753
		public Type TargetType;

		// Token: 0x0400167A RID: 5754
		public Type InterfaceType;

		// Token: 0x0400167B RID: 5755
		public MethodInfo[] TargetMethods;

		// Token: 0x0400167C RID: 5756
		public MethodInfo[] InterfaceMethods;
	}
}
