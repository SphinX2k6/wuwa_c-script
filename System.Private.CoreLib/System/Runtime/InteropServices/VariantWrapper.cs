using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005FC RID: 1532
	[NullableContext(2)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class VariantWrapper
	{
		// Token: 0x060071A1 RID: 29089 RVA: 0x0011075F File Offset: 0x0010E95F
		public VariantWrapper(object obj)
		{
			this.WrappedObject = obj;
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x0011076E File Offset: 0x0010E96E
		public object WrappedObject { get; }
	}
}
