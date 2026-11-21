using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006DB RID: 1755
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	public sealed class TypeForwardedFromAttribute : Attribute
	{
		// Token: 0x060074BE RID: 29886 RVA: 0x00115F02 File Offset: 0x00114102
		public TypeForwardedFromAttribute(string assemblyFullName)
		{
			ArgumentException.ThrowIfNullOrEmpty(assemblyFullName, "assemblyFullName");
			this.AssemblyFullName = assemblyFullName;
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060074BF RID: 29887 RVA: 0x00115F1C File Offset: 0x0011411C
		public string AssemblyFullName { get; }
	}
}
