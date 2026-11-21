using System;
using System.Diagnostics;

namespace System
{
	// Token: 0x02000168 RID: 360
	internal sealed class MemoryDebugView<T>
	{
		// Token: 0x06001773 RID: 6003 RVA: 0x00046FED File Offset: 0x000451ED
		public MemoryDebugView(Memory<T> memory)
		{
			this._memory = memory;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00047001 File Offset: 0x00045201
		public MemoryDebugView(ReadOnlyMemory<T> memory)
		{
			this._memory = memory;
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x00047010 File Offset: 0x00045210
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				return this._memory.ToArray();
			}
		}

		// Token: 0x040004F6 RID: 1270
		private readonly ReadOnlyMemory<T> _memory;
	}
}
