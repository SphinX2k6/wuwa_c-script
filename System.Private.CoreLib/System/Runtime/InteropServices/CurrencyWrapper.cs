using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005C3 RID: 1475
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("CurrencyWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
	public sealed class CurrencyWrapper
	{
		// Token: 0x0600700B RID: 28683 RVA: 0x0010D93B File Offset: 0x0010BB3B
		public CurrencyWrapper(decimal obj)
		{
			this.WrappedObject = obj;
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x0010D94C File Offset: 0x0010BB4C
		[NullableContext(1)]
		public CurrencyWrapper(object obj)
		{
			if (obj is decimal)
			{
				decimal num = (decimal)obj;
				this.WrappedObject = num;
				return;
			}
			throw new ArgumentException(SR.Arg_MustBeDecimal, "obj");
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x0600700D RID: 28685 RVA: 0x0010D987 File Offset: 0x0010BB87
		public decimal WrappedObject { get; }
	}
}
