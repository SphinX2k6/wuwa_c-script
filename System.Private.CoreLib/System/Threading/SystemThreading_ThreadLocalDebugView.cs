using System;
using System.Collections.Generic;

namespace System.Threading
{
	// Token: 0x02000424 RID: 1060
	internal sealed class SystemThreading_ThreadLocalDebugView<T>
	{
		// Token: 0x060041D4 RID: 16852 RVA: 0x000DBAB0 File Offset: 0x000D9CB0
		public SystemThreading_ThreadLocalDebugView(ThreadLocal<T> tlocal)
		{
			this._tlocal = tlocal;
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x000DBABF File Offset: 0x000D9CBF
		public bool IsValueCreated
		{
			get
			{
				return this._tlocal.IsValueCreated;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x000DBACC File Offset: 0x000D9CCC
		public T Value
		{
			get
			{
				return this._tlocal.ValueForDebugDisplay;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x000DBAD9 File Offset: 0x000D9CD9
		public List<T> Values
		{
			get
			{
				return this._tlocal.ValuesForDebugDisplay;
			}
		}

		// Token: 0x04000E14 RID: 3604
		private readonly ThreadLocal<T> _tlocal;
	}
}
