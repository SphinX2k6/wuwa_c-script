using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020003C9 RID: 969
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct AsyncLocalValueChangedArgs<T>
	{
		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x000D404A File Offset: 0x000D224A
		public T PreviousValue { get; }

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x000D4052 File Offset: 0x000D2252
		public T CurrentValue { get; }

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06003F76 RID: 16246 RVA: 0x000D405A File Offset: 0x000D225A
		public bool ThreadContextChanged { get; }

		// Token: 0x06003F77 RID: 16247 RVA: 0x000D4062 File Offset: 0x000D2262
		internal AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
		{
			this.PreviousValue = previousValue;
			this.CurrentValue = currentValue;
			this.ThreadContextChanged = contextChanged;
		}
	}
}
