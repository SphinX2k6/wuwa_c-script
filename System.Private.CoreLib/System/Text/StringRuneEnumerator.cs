using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x0200023B RID: 571
	public struct StringRuneEnumerator : IEnumerable<Rune>, IEnumerable, IEnumerator<Rune>, IDisposable, IEnumerator
	{
		// Token: 0x06002BEA RID: 11242 RVA: 0x0008A56E File Offset: 0x0008876E
		internal StringRuneEnumerator(string value)
		{
			this._string = value;
			this._current = default(Rune);
			this._nextIndex = 0;
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x0008A58A File Offset: 0x0008878A
		public Rune Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x0008A592 File Offset: 0x00088792
		public StringRuneEnumerator GetEnumerator()
		{
			return this;
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x0008A59C File Offset: 0x0008879C
		public bool MoveNext()
		{
			if ((ulong)this._nextIndex >= (ulong)((long)this._string.Length))
			{
				this._current = default(Rune);
				return false;
			}
			if (!Rune.TryGetRuneAt(this._string, this._nextIndex, out this._current))
			{
				this._current = Rune.ReplacementChar;
			}
			this._nextIndex += this._current.Utf16SequenceLength;
			return true;
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x0008A609 File Offset: 0x00088809
		[Nullable(2)]
		object IEnumerator.Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0008A616 File Offset: 0x00088816
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0008A616 File Offset: 0x00088816
		IEnumerator<Rune> IEnumerable<Rune>.GetEnumerator()
		{
			return this;
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0008A623 File Offset: 0x00088823
		void IEnumerator.Reset()
		{
			this._current = default(Rune);
			this._nextIndex = 0;
		}

		// Token: 0x040007A4 RID: 1956
		private readonly string _string;

		// Token: 0x040007A5 RID: 1957
		private Rune _current;

		// Token: 0x040007A6 RID: 1958
		private int _nextIndex;
	}
}
