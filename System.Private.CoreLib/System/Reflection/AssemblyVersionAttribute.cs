using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000733 RID: 1843
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyVersionAttribute : Attribute
	{
		// Token: 0x0600788A RID: 30858 RVA: 0x0011E999 File Offset: 0x0011CB99
		public AssemblyVersionAttribute(string version)
		{
			this.Version = version;
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x0600788B RID: 30859 RVA: 0x0011E9A8 File Offset: 0x0011CBA8
		public string Version { get; }
	}
}
