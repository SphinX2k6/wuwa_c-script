using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200068E RID: 1678
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	public abstract class CustomConstantAttribute : Attribute
	{
		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x060073E3 RID: 29667
		public abstract object Value { get; }
	}
}
