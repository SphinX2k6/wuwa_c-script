using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006DC RID: 1756
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class TypeForwardedToAttribute : Attribute
	{
		// Token: 0x060074C0 RID: 29888 RVA: 0x00115F24 File Offset: 0x00114124
		public TypeForwardedToAttribute(Type destination)
		{
			this.Destination = destination;
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060074C1 RID: 29889 RVA: 0x00115F33 File Offset: 0x00114133
		public Type Destination { get; }
	}
}
