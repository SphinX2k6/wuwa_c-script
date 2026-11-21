using System;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000235 RID: 565
	[CompilerFeatureRequired("RefStructs")]
	public ref struct SpanLineEnumerator
	{
		// Token: 0x06002B4C RID: 11084 RVA: 0x00087AFB File Offset: 0x00085CFB
		internal SpanLineEnumerator(ReadOnlySpan<char> buffer)
		{
			this._remaining = buffer;
			this._current = default(ReadOnlySpan<char>);
			this._isEnumeratorActive = true;
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x00087B17 File Offset: 0x00085D17
		public ReadOnlySpan<char> Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x00087B1F File Offset: 0x00085D1F
		public SpanLineEnumerator GetEnumerator()
		{
			return this;
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x00087B28 File Offset: 0x00085D28
		public unsafe bool MoveNext()
		{
			if (!this._isEnumeratorActive)
			{
				return false;
			}
			ReadOnlySpan<char> remaining = this._remaining;
			int num = remaining.IndexOfAny(string.SearchValuesStorage.NewLineChars);
			if (num < remaining.Length)
			{
				int num2 = 1;
				if (*remaining[num] == 13 && num + 1 < remaining.Length && *remaining[num + 1] == 10)
				{
					num2 = 2;
				}
				this._current = remaining.Slice(0, num);
				this._remaining = remaining.Slice(num + num2);
			}
			else
			{
				this._current = remaining;
				this._remaining = default(ReadOnlySpan<char>);
				this._isEnumeratorActive = false;
			}
			return true;
		}

		// Token: 0x04000792 RID: 1938
		private ReadOnlySpan<char> _remaining;

		// Token: 0x04000793 RID: 1939
		private ReadOnlySpan<char> _current;

		// Token: 0x04000794 RID: 1940
		private bool _isEnumeratorActive;
	}
}
