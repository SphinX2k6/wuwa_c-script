using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000728 RID: 1832
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyInformationalVersionAttribute : Attribute
	{
		// Token: 0x06007871 RID: 30833 RVA: 0x0011E76C File Offset: 0x0011C96C
		public AssemblyInformationalVersionAttribute(string informationalVersion)
		{
			this.InformationalVersion = informationalVersion;
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06007872 RID: 30834 RVA: 0x0011E77B File Offset: 0x0011C97B
		public string InformationalVersion { get; }
	}
}
