using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x02000046 RID: 70
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct BitHelper
	{
		// Token: 0x06000342 RID: 834 RVA: 0x0000C70A File Offset: 0x0000A90A
		internal BitHelper(Span<int> span, bool clear)
		{
			if (clear)
			{
				span.Clear();
			}
			this._span = span;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000C720 File Offset: 0x0000A920
		internal unsafe void MarkBit(int bitPosition)
		{
			uint num = (uint)(bitPosition / 32);
			Span<int> span = this._span;
			if (num < (uint)span.Length)
			{
				*span[(int)num] |= 1 << bitPosition % 32;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000C758 File Offset: 0x0000A958
		internal unsafe bool IsMarked(int bitPosition)
		{
			uint num = (uint)(bitPosition / 32);
			ReadOnlySpan<int> readOnlySpan = this._span;
			return num < (uint)readOnlySpan.Length && (*readOnlySpan[(int)num] & 1 << bitPosition % 32) != 0;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000C798 File Offset: 0x0000A998
		internal static int ToIntArrayLength(int n)
		{
			if (n <= 0)
			{
				return 0;
			}
			return (n - 1) / 32 + 1;
		}

		// Token: 0x040000A8 RID: 168
		private readonly Span<int> _span;
	}
}
