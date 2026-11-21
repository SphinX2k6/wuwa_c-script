using System;

namespace System.Runtime.Versioning
{
	// Token: 0x02000507 RID: 1287
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class ComponentGuaranteesAttribute : Attribute
	{
		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x000F0AE8 File Offset: 0x000EECE8
		public ComponentGuaranteesOptions Guarantees { get; }

		// Token: 0x06004847 RID: 18503 RVA: 0x000F0AF0 File Offset: 0x000EECF0
		public ComponentGuaranteesAttribute(ComponentGuaranteesOptions guarantees)
		{
			this.Guarantees = guarantees;
		}
	}
}
