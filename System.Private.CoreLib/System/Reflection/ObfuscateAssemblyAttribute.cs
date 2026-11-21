using System;

namespace System.Reflection
{
	// Token: 0x02000768 RID: 1896
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class ObfuscateAssemblyAttribute : Attribute
	{
		// Token: 0x060079CE RID: 31182 RVA: 0x001213BB File Offset: 0x0011F5BB
		public ObfuscateAssemblyAttribute(bool assemblyIsPrivate)
		{
			this.AssemblyIsPrivate = assemblyIsPrivate;
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x060079CF RID: 31183 RVA: 0x001213D1 File Offset: 0x0011F5D1
		public bool AssemblyIsPrivate { get; }

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x060079D0 RID: 31184 RVA: 0x001213D9 File Offset: 0x0011F5D9
		// (set) Token: 0x060079D1 RID: 31185 RVA: 0x001213E1 File Offset: 0x0011F5E1
		public bool StripAfterObfuscation { get; set; } = true;
	}
}
