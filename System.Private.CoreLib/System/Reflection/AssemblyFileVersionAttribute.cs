using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000726 RID: 1830
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyFileVersionAttribute : Attribute
	{
		// Token: 0x0600786A RID: 30826 RVA: 0x0011E733 File Offset: 0x0011C933
		public AssemblyFileVersionAttribute(string version)
		{
			ArgumentNullException.ThrowIfNull(version, "version");
			this.Version = version;
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x0600786B RID: 30827 RVA: 0x0011E74D File Offset: 0x0011C94D
		public string Version { get; }
	}
}
