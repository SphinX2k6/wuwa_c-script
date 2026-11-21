using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200071F RID: 1823
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyConfigurationAttribute : Attribute
	{
		// Token: 0x0600785E RID: 30814 RVA: 0x0011E6A9 File Offset: 0x0011C8A9
		public AssemblyConfigurationAttribute(string configuration)
		{
			this.Configuration = configuration;
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x0600785F RID: 30815 RVA: 0x0011E6B8 File Offset: 0x0011C8B8
		public string Configuration { get; }
	}
}
