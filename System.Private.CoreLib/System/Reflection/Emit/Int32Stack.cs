using System;
using System.Collections.Generic;

namespace System.Reflection.Emit
{
	// Token: 0x020007AF RID: 1967
	internal sealed class Int32Stack : List<int>
	{
		// Token: 0x06007DB4 RID: 32180 RVA: 0x00128DEF File Offset: 0x00126FEF
		public Int32Stack(int initialCapacity) : base(initialCapacity)
		{
		}

		// Token: 0x06007DB5 RID: 32181 RVA: 0x00128DF8 File Offset: 0x00126FF8
		public int Peek()
		{
			if (base.Count == 0)
			{
				throw new InvalidOperationException();
			}
			return base[base.Count - 1];
		}

		// Token: 0x06007DB6 RID: 32182 RVA: 0x00128E16 File Offset: 0x00127016
		public int Pop()
		{
			if (base.Count == 0)
			{
				throw new InvalidOperationException();
			}
			int result = base[base.Count - 1];
			base.RemoveAt(base.Count - 1);
			return result;
		}

		// Token: 0x06007DB7 RID: 32183 RVA: 0x00128E42 File Offset: 0x00127042
		public void Push(int value)
		{
			base.Add(value);
		}
	}
}
