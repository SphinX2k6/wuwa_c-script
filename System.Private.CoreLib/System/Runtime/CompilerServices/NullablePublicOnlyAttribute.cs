using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006B8 RID: 1720
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.Module, Inherited = false)]
	public sealed class NullablePublicOnlyAttribute : Attribute
	{
		// Token: 0x06007441 RID: 29761 RVA: 0x00115227 File Offset: 0x00113427
		public NullablePublicOnlyAttribute(bool value)
		{
			this.IncludesInternals = value;
		}

		// Token: 0x040014D5 RID: 5333
		public readonly bool IncludesInternals;
	}
}
