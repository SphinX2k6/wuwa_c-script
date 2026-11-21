using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009E9 RID: 2537
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct BitHelper
	{
		// Token: 0x06009410 RID: 37904 RVA: 0x00171774 File Offset: 0x0016F974
		internal BitHelper(Span<int> span, bool clear)
		{
			if (clear)
			{
				span.Clear();
			}
			this._span = span;
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x00171788 File Offset: 0x0016F988
		internal unsafe void MarkBit(int bitPosition)
		{
			uint num = (uint)(bitPosition / 32);
			Span<int> span = this._span;
			if (num < (uint)span.Length)
			{
				*span[(int)num] |= 1 << bitPosition % 32;
			}
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x001717C0 File Offset: 0x0016F9C0
		internal unsafe bool IsMarked(int bitPosition)
		{
			uint num = (uint)(bitPosition / 32);
			ReadOnlySpan<int> readOnlySpan = this._span;
			return num < (uint)readOnlySpan.Length && (*readOnlySpan[(int)num] & 1 << bitPosition % 32) != 0;
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x00171800 File Offset: 0x0016FA00
		internal static int ToIntArrayLength(int n)
		{
			if (n <= 0)
			{
				return 0;
			}
			return (n - 1) / 32 + 1;
		}

		// Token: 0x040022BA RID: 8890
		private readonly Span<int> _span;
	}
}
