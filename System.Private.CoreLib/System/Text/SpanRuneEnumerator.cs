using System;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000236 RID: 566
	[CompilerFeatureRequired("RefStructs")]
	public ref struct SpanRuneEnumerator
	{
		// Token: 0x06002B50 RID: 11088 RVA: 0x00087BC4 File Offset: 0x00085DC4
		internal SpanRuneEnumerator(ReadOnlySpan<char> buffer)
		{
			this._remaining = buffer;
			this._current = default(Rune);
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x00087BD9 File Offset: 0x00085DD9
		public Rune Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00087BE1 File Offset: 0x00085DE1
		public SpanRuneEnumerator GetEnumerator()
		{
			return this;
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00087BEC File Offset: 0x00085DEC
		public bool MoveNext()
		{
			if (this._remaining.IsEmpty)
			{
				this._current = default(Rune);
				return false;
			}
			int num = Rune.ReadFirstRuneFromUtf16Buffer(this._remaining);
			if (num < 0)
			{
				num = Rune.ReplacementChar.Value;
			}
			this._current = Rune.UnsafeCreate((uint)num);
			this._remaining = this._remaining.Slice(this._current.Utf16SequenceLength);
			return true;
		}

		// Token: 0x04000795 RID: 1941
		private ReadOnlySpan<char> _remaining;

		// Token: 0x04000796 RID: 1942
		private Rune _current;
	}
}
