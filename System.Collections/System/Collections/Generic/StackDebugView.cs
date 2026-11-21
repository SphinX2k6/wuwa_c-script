using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x02000045 RID: 69
	internal sealed class StackDebugView<T>
	{
		// Token: 0x06000340 RID: 832 RVA: 0x0000C6E3 File Offset: 0x0000A8E3
		public StackDebugView(Stack<T> stack)
		{
			ArgumentNullException.ThrowIfNull(stack, "stack");
			this._stack = stack;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000C6FD File Offset: 0x0000A8FD
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				return this._stack.ToArray();
			}
		}

		// Token: 0x040000A7 RID: 167
		private readonly Stack<T> _stack;
	}
}
