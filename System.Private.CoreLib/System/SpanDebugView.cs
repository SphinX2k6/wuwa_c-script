using System;
using System.Diagnostics;

namespace System
{
	// Token: 0x020001A6 RID: 422
	internal sealed class SpanDebugView<T>
	{
		// Token: 0x06001C57 RID: 7255 RVA: 0x0005A2D1 File Offset: 0x000584D1
		public SpanDebugView(Span<T> span)
		{
			this._array = span.ToArray();
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0005A2E6 File Offset: 0x000584E6
		public SpanDebugView(ReadOnlySpan<T> span)
		{
			this._array = span.ToArray();
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0005A2FB File Offset: 0x000584FB
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				return this._array;
			}
		}

		// Token: 0x04000575 RID: 1397
		private readonly T[] _array;
	}
}
