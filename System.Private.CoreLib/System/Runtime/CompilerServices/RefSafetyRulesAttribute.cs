using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006C2 RID: 1730
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.Module, Inherited = false)]
	public sealed class RefSafetyRulesAttribute : Attribute
	{
		// Token: 0x06007476 RID: 29814 RVA: 0x00115796 File Offset: 0x00113996
		public RefSafetyRulesAttribute(int version)
		{
			this.Version = version;
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06007477 RID: 29815 RVA: 0x001157A5 File Offset: 0x001139A5
		public int Version { get; }
	}
}
