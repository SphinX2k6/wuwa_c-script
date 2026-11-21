using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace System
{
	// Token: 0x0200015E RID: 350
	internal sealed class LazyDebugView<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>
	{
		// Token: 0x0600172D RID: 5933 RVA: 0x00046475 File Offset: 0x00044675
		public LazyDebugView(Lazy<T> lazy)
		{
			this._lazy = lazy;
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00046484 File Offset: 0x00044684
		public bool IsValueCreated
		{
			get
			{
				return this._lazy.IsValueCreated;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00046491 File Offset: 0x00044691
		public T Value
		{
			get
			{
				return this._lazy.ValueForDebugDisplay;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x0004649E File Offset: 0x0004469E
		public LazyThreadSafetyMode? Mode
		{
			get
			{
				return this._lazy.Mode;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x000464AB File Offset: 0x000446AB
		public bool IsValueFaulted
		{
			get
			{
				return this._lazy.IsValueFaulted;
			}
		}

		// Token: 0x040004DE RID: 1246
		private readonly Lazy<T> _lazy;
	}
}
