using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006C5 RID: 1733
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	public sealed class RuntimeCompatibilityAttribute : Attribute
	{
		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x0600747B RID: 29819 RVA: 0x001157AD File Offset: 0x001139AD
		// (set) Token: 0x0600747C RID: 29820 RVA: 0x001157B5 File Offset: 0x001139B5
		public bool WrapNonExceptionThrows { get; set; }
	}
}
