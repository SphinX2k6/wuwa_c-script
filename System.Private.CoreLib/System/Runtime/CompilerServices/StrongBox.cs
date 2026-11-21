using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006CD RID: 1741
	public class StrongBox<[Nullable(2)] T> : IStrongBox
	{
		// Token: 0x0600748B RID: 29835 RVA: 0x00005ACC File Offset: 0x00003CCC
		public StrongBox()
		{
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x001159B0 File Offset: 0x00113BB0
		[NullableContext(1)]
		public StrongBox(T value)
		{
			this.Value = value;
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x0600748D RID: 29837 RVA: 0x001159BF File Offset: 0x00113BBF
		// (set) Token: 0x0600748E RID: 29838 RVA: 0x001159CC File Offset: 0x00113BCC
		[Nullable(2)]
		object IStrongBox.Value
		{
			get
			{
				return this.Value;
			}
			set
			{
				this.Value = (T)((object)value);
			}
		}

		// Token: 0x040014F1 RID: 5361
		[Nullable(1)]
		[MaybeNull]
		public T Value;
	}
}
