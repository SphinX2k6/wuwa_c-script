using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x0200024D RID: 589
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct ValueStringBuilder
	{
		// Token: 0x06002CD0 RID: 11472 RVA: 0x0008F150 File Offset: 0x0008D350
		internal unsafe void AppendFormatHelper(IFormatProvider provider, string format, ReadOnlySpan<object> args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			ICustomFormatter customFormatter = (ICustomFormatter)((provider != null) ? provider.GetFormat(typeof(ICustomFormatter)) : null);
			int i = 0;
			while (i < format.Length)
			{
				ReadOnlySpan<char> readOnlySpan = format.AsSpan(i);
				int num = readOnlySpan.IndexOfAny('{', '}');
				if (num < 0)
				{
					this.Append(readOnlySpan);
					return;
				}
				this.Append(readOnlySpan.Slice(0, num));
				i += num;
				char c = format[i];
				char c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
				if (c == c2)
				{
					this.Append(c2);
					i++;
				}
				else
				{
					if (c != '{')
					{
						ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_UnexpectedClosingBrace);
					}
					int num2 = 0;
					bool flag = false;
					ReadOnlySpan<char> readOnlySpan2 = default(ReadOnlySpan<char>);
					int num3 = (int)(c2 - '0');
					if (num3 >= 10)
					{
						ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_ExpectedAsciiDigit);
					}
					c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
					if (c2 != '}')
					{
						while (char.IsAsciiDigit(c2))
						{
							if (num3 >= 1000000)
							{
								break;
							}
							num3 = num3 * 10 + (int)c2 - 48;
							c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
						}
						while (c2 == ' ')
						{
							c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
						}
						if (c2 == ',')
						{
							do
							{
								c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
							}
							while (c2 == ' ');
							if (c2 == '-')
							{
								flag = true;
								c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
							}
							num2 = (int)(c2 - '0');
							if (num2 >= 10)
							{
								ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_ExpectedAsciiDigit);
							}
							c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
							while (char.IsAsciiDigit(c2))
							{
								if (num2 >= 1000000)
								{
									break;
								}
								num2 = num2 * 10 + (int)c2 - 48;
								c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
							}
							while (c2 == ' ')
							{
								c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
							}
						}
						if (c2 != '}')
						{
							if (c2 != ':')
							{
								ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_UnclosedFormatItem);
							}
							int num4 = i;
							for (;;)
							{
								c2 = ValueStringBuilder.<AppendFormatHelper>g__MoveNext|0_0(format, ref i);
								if (c2 == '}')
								{
									break;
								}
								if (c2 == '{')
								{
									ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_UnclosedFormatItem);
								}
							}
							num4++;
							readOnlySpan2 = format.AsSpan(num4, i - num4);
						}
					}
					i++;
					string text = null;
					string text2 = null;
					if (num3 >= args.Length)
					{
						ThrowHelper.ThrowFormatIndexOutOfRange();
					}
					object obj = *args[num3];
					if (customFormatter != null)
					{
						if (!readOnlySpan2.IsEmpty)
						{
							text2 = new string(readOnlySpan2);
						}
						text = customFormatter.Format(text2, obj, provider);
					}
					if (text == null)
					{
						if (flag || num2 == 0)
						{
							ISpanFormattable spanFormattable = obj as ISpanFormattable;
							int num5;
							if (spanFormattable != null && spanFormattable.TryFormat(this._chars.Slice(this._pos), out num5, readOnlySpan2, provider))
							{
								this._pos += num5;
								if (flag && num2 > num5)
								{
									this.Append(' ', num2 - num5);
									continue;
								}
								continue;
							}
						}
						IFormattable formattable = obj as IFormattable;
						if (formattable != null)
						{
							if (readOnlySpan2.Length != 0 && text2 == null)
							{
								text2 = new string(readOnlySpan2);
							}
							text = formattable.ToString(text2, provider);
						}
						else
						{
							text = ((obj != null) ? obj.ToString() : null);
						}
						if (text == null)
						{
							text = string.Empty;
						}
					}
					if (num2 <= text.Length)
					{
						this.Append(text);
					}
					else if (flag)
					{
						this.Append(text);
						this.Append(' ', num2 - text.Length);
					}
					else
					{
						this.Append(' ', num2 - text.Length);
						this.Append(text);
					}
				}
			}
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x0008F472 File Offset: 0x0008D672
		public ValueStringBuilder(Span<char> initialBuffer)
		{
			this._arrayToReturnToPool = null;
			this._chars = initialBuffer;
			this._pos = 0;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0008F489 File Offset: 0x0008D689
		public ValueStringBuilder(int initialCapacity)
		{
			this._arrayToReturnToPool = ArrayPool<char>.Shared.Rent(initialCapacity);
			this._chars = this._arrayToReturnToPool;
			this._pos = 0;
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x0008F4B4 File Offset: 0x0008D6B4
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x0008F4BC File Offset: 0x0008D6BC
		public int Length
		{
			get
			{
				return this._pos;
			}
			set
			{
				this._pos = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x0008F4C5 File Offset: 0x0008D6C5
		public int Capacity
		{
			get
			{
				return this._chars.Length;
			}
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0008F4D2 File Offset: 0x0008D6D2
		public void EnsureCapacity(int capacity)
		{
			if (capacity > this._chars.Length)
			{
				this.Grow(capacity - this._pos);
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0008F4F0 File Offset: 0x0008D6F0
		public ref char GetPinnableReference()
		{
			return MemoryMarshal.GetReference<char>(this._chars);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x0008F4FD File Offset: 0x0008D6FD
		public unsafe ref char GetPinnableReference(bool terminate)
		{
			if (terminate)
			{
				this.EnsureCapacity(this.Length + 1);
				*this._chars[this.Length] = '\0';
			}
			return MemoryMarshal.GetReference<char>(this._chars);
		}

		// Token: 0x170008B0 RID: 2224
		public char this[int index]
		{
			get
			{
				return this._chars[index];
			}
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x0008F53C File Offset: 0x0008D73C
		public override string ToString()
		{
			string result = this._chars.Slice(0, this._pos).ToString();
			this.Dispose();
			return result;
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x0008F56F File Offset: 0x0008D76F
		public Span<char> RawChars
		{
			get
			{
				return this._chars;
			}
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x0008F577 File Offset: 0x0008D777
		public unsafe ReadOnlySpan<char> AsSpan(bool terminate)
		{
			if (terminate)
			{
				this.EnsureCapacity(this.Length + 1);
				*this._chars[this.Length] = '\0';
			}
			return this._chars.Slice(0, this._pos);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x0008F5B4 File Offset: 0x0008D7B4
		public ReadOnlySpan<char> AsSpan()
		{
			return this._chars.Slice(0, this._pos);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x0008F5CD File Offset: 0x0008D7CD
		public ReadOnlySpan<char> AsSpan(int start)
		{
			return this._chars.Slice(start, this._pos - start);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0008F5E8 File Offset: 0x0008D7E8
		public ReadOnlySpan<char> AsSpan(int start, int length)
		{
			return this._chars.Slice(start, length);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x0008F5FC File Offset: 0x0008D7FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append(char c)
		{
			int pos = this._pos;
			Span<char> chars = this._chars;
			if (pos < chars.Length)
			{
				*chars[pos] = c;
				this._pos = pos + 1;
				return;
			}
			this.GrowAndAppend(c);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x0008F63C File Offset: 0x0008D83C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append(string s)
		{
			if (s == null)
			{
				return;
			}
			int pos = this._pos;
			if (s.Length == 1 && pos < this._chars.Length)
			{
				*this._chars[pos] = s[0];
				this._pos = pos + 1;
				return;
			}
			this.AppendSlow(s);
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x0008F690 File Offset: 0x0008D890
		private void AppendSlow(string s)
		{
			int pos = this._pos;
			if (pos > this._chars.Length - s.Length)
			{
				this.Grow(s.Length);
			}
			s.CopyTo(this._chars.Slice(pos));
			this._pos += s.Length;
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x0008F6EC File Offset: 0x0008D8EC
		public unsafe void Append(char c, int count)
		{
			if (this._pos > this._chars.Length - count)
			{
				this.Grow(count);
			}
			Span<char> span = this._chars.Slice(this._pos, count);
			for (int i = 0; i < span.Length; i++)
			{
				*span[i] = c;
			}
			this._pos += count;
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x0008F754 File Offset: 0x0008D954
		public void Append([ScopedRef] ReadOnlySpan<char> value)
		{
			if (this._pos > this._chars.Length - value.Length)
			{
				this.Grow(value.Length);
			}
			value.CopyTo(this._chars.Slice(this._pos));
			this._pos += value.Length;
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x0008F7B8 File Offset: 0x0008D9B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<char> AppendSpan(int length)
		{
			int pos = this._pos;
			if (pos > this._chars.Length - length)
			{
				this.Grow(length);
			}
			this._pos = pos + length;
			return this._chars.Slice(pos, length);
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x0008F7F9 File Offset: 0x0008D9F9
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GrowAndAppend(char c)
		{
			this.Grow(1);
			this.Append(c);
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x0008F80C File Offset: 0x0008DA0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Grow(int additionalCapacityBeyondPos)
		{
			int minimumLength = (int)Math.Max((uint)(this._pos + additionalCapacityBeyondPos), Math.Min((uint)(this._chars.Length * 2), 2147483591U));
			char[] array = ArrayPool<char>.Shared.Rent(minimumLength);
			this._chars.Slice(0, this._pos).CopyTo(array);
			char[] arrayToReturnToPool = this._arrayToReturnToPool;
			this._chars = (this._arrayToReturnToPool = array);
			if (arrayToReturnToPool != null)
			{
				ArrayPool<char>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x0008F898 File Offset: 0x0008DA98
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Dispose()
		{
			char[] arrayToReturnToPool = this._arrayToReturnToPool;
			this = default(ValueStringBuilder);
			if (arrayToReturnToPool != null)
			{
				ArrayPool<char>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x0008F8C4 File Offset: 0x0008DAC4
		internal void AppendSpanFormattable<T>(T value, string format = null, IFormatProvider provider = null) where T : ISpanFormattable
		{
			ref T ptr = ref value;
			if (default(T) == null)
			{
				T t = value;
				ptr = ref t;
			}
			int num;
			if (ptr.TryFormat(this._chars.Slice(this._pos), out num, format, provider))
			{
				this._pos += num;
				return;
			}
			this.Append(value.ToString(format, provider));
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00089F7F File Offset: 0x0008817F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char <AppendFormatHelper>g__MoveNext|0_0(string format, ref int pos)
		{
			pos++;
			if (pos >= format.Length)
			{
				ThrowHelper.ThrowFormatInvalidString(pos, ExceptionResource.Format_UnclosedFormatItem);
			}
			return format[pos];
		}

		// Token: 0x040007EF RID: 2031
		private char[] _arrayToReturnToPool;

		// Token: 0x040007F0 RID: 2032
		private Span<char> _chars;

		// Token: 0x040007F1 RID: 2033
		private int _pos;
	}
}
