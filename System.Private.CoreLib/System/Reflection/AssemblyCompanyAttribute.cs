using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200071E RID: 1822
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCompanyAttribute : Attribute
	{
		// Token: 0x0600785C RID: 30812 RVA: 0x0011E692 File Offset: 0x0011C892
		public AssemblyCompanyAttribute(string company)
		{
			this.Company = company;
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x0600785D RID: 30813 RVA: 0x0011E6A1 File Offset: 0x0011C8A1
		public string Company { get; }
	}
}
