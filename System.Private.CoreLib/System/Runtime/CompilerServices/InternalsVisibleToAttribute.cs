using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006A2 RID: 1698
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class InternalsVisibleToAttribute : Attribute
	{
		// Token: 0x0600740A RID: 29706 RVA: 0x001148F1 File Offset: 0x00112AF1
		public InternalsVisibleToAttribute(string assemblyName)
		{
			this.AssemblyName = assemblyName;
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x0600740B RID: 29707 RVA: 0x00114907 File Offset: 0x00112B07
		public string AssemblyName { get; }

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x0600740C RID: 29708 RVA: 0x0011490F File Offset: 0x00112B0F
		// (set) Token: 0x0600740D RID: 29709 RVA: 0x00114917 File Offset: 0x00112B17
		public bool AllInternalsVisible { get; set; } = true;
	}
}
