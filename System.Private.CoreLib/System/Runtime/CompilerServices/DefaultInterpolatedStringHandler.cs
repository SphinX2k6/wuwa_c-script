using System;
using System.Buffers;
using System.Globalization;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006AC RID: 1708
	[NullableContext(2)]
	[Nullable(0)]
	[CompilerFeatureRequired("RefStructs")]
	[InterpolatedStringHandler]
	public ref struct DefaultInterpolatedStringHandler
	{
		// Token: 0x06007417 RID: 29719 RVA: 0x00114968 File Offset: 0x00112B68
		public DefaultInterpolatedStringHandler(int literalLength, int formattedCount)
		{
			this._provider = null;
			this._chars = (this._arrayToReturnToPool = ArrayPool<char>.Shared.Rent(DefaultInterpolatedStringHandler.GetDefaultLength(literalLength, formattedCount)));
			this._pos = 0;
			this._hasCustomFormatter = false;
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x001149B0 File Offset: 0x00112BB0
		public DefaultInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider provider)
		{
			this._provider = provider;
			this._chars = (this._arrayToReturnToPool = ArrayPool<char>.Shared.Rent(DefaultInterpolatedStringHandler.GetDefaultLength(literalLength, formattedCount)));
			this._pos = 0;
			this._hasCustomFormatter = (provider != null && DefaultInterpolatedStringHandler.HasCustomFormatter(provider));
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x00114A02 File Offset: 0x00112C02
		[NullableContext(0)]
		public DefaultInterpolatedStringHandler(int literalLength, int formattedCount, [Nullable(2)] IFormatProvider provider, Span<char> initialBuffer)
		{
			this._provider = provider;
			this._chars = initialBuffer;
			this._arrayToReturnToPool = null;
			this._pos = 0;
			this._hasCustomFormatter = (provider != null && DefaultInterpolatedStringHandler.HasCustomFormatter(provider));
		}

		// Token: 0x0600741A RID: 29722 RVA: 0x00114A33 File Offset: 0x00112C33
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetDefaultLength(int literalLength, int formattedCount)
		{
			return Math.Max(256, literalLength + formattedCount * 11);
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x00114A45 File Offset: 0x00112C45
		[NullableContext(1)]
		public override string ToString()
		{
			return new string(this.Text);
		}

		// Token: 0x0600741C RID: 29724 RVA: 0x00114A52 File Offset: 0x00112C52
		[NullableContext(1)]
		public string ToStringAndClear()
		{
			string result = new string(this.Text);
			this.Clear();
			return result;
		}

		// Token: 0x0600741D RID: 29725 RVA: 0x00114A68 File Offset: 0x00112C68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Clear()
		{
			char[] arrayToReturnToPool = this._arrayToReturnToPool;
			this = default(DefaultInterpolatedStringHandler);
			if (arrayToReturnToPool != null)
			{
				ArrayPool<char>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x00114A92 File Offset: 0x00112C92
		[Nullable(0)]
		internal ReadOnlySpan<char> Text
		{
			get
			{
				return this._chars.Slice(0, this._pos);
			}
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x00114AAB File Offset: 0x00112CAB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AppendLiteral(string value)
		{
			if (value.TryCopyTo(this._chars.Slice(this._pos)))
			{
				this._pos += value.Length;
				return;
			}
			this.GrowThenCopyString(value);
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x00114AE4 File Offset: 0x00112CE4
		[NullableContext(1)]
		public void AppendFormatted<[Nullable(2)] T>(T value)
		{
			if (this._hasCustomFormatter)
			{
				this.AppendCustomFormatter<T>(value, null);
				return;
			}
			string text;
			if (value is IFormattable)
			{
				if (typeof(T).IsEnum)
				{
					int num;
					while (!Enum.TryFormatUnconstrained<T>(value, this._chars.Slice(this._pos), out num, default(ReadOnlySpan<char>)))
					{
						this.Grow();
					}
					this._pos += num;
					return;
				}
				if (value is ISpanFormattable)
				{
					int num2;
					while (!((ISpanFormattable)((object)value)).TryFormat(this._chars.Slice(this._pos), out num2, default(ReadOnlySpan<char>), this._provider))
					{
						this.Grow();
					}
					this._pos += num2;
					return;
				}
				text = ((IFormattable)((object)value)).ToString(null, this._provider);
			}
			else
			{
				ref T ptr = ref value;
				T t = default(T);
				string text2;
				if (t == null)
				{
					t = value;
					ptr = ref t;
					if (t == null)
					{
						text2 = null;
						goto IL_113;
					}
				}
				text2 = ptr.ToString();
				IL_113:
				text = text2;
			}
			if (text != null)
			{
				this.AppendLiteral(text);
			}
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x00114C10 File Offset: 0x00112E10
		public void AppendFormatted<T>([Nullable(1)] T value, string format)
		{
			if (this._hasCustomFormatter)
			{
				this.AppendCustomFormatter<T>(value, format);
				return;
			}
			string text;
			if (value is IFormattable)
			{
				if (typeof(T).IsEnum)
				{
					int num;
					while (!Enum.TryFormatUnconstrained<T>(value, this._chars.Slice(this._pos), out num, format))
					{
						this.Grow();
					}
					this._pos += num;
					return;
				}
				if (value is ISpanFormattable)
				{
					int num2;
					while (!((ISpanFormattable)((object)value)).TryFormat(this._chars.Slice(this._pos), out num2, format, this._provider))
					{
						this.Grow();
					}
					this._pos += num2;
					return;
				}
				text = ((IFormattable)((object)value)).ToString(format, this._provider);
			}
			else
			{
				ref T ptr = ref value;
				T t = default(T);
				string text2;
				if (t == null)
				{
					t = value;
					ptr = ref t;
					if (t == null)
					{
						text2 = null;
						goto IL_10A;
					}
				}
				text2 = ptr.ToString();
				IL_10A:
				text = text2;
			}
			if (text != null)
			{
				this.AppendLiteral(text);
			}
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x00114D34 File Offset: 0x00112F34
		[NullableContext(1)]
		public void AppendFormatted<[Nullable(2)] T>(T value, int alignment)
		{
			int pos = this._pos;
			this.AppendFormatted<T>(value);
			if (alignment != 0)
			{
				this.AppendOrInsertAlignmentIfNeeded(pos, alignment);
			}
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x00114D5C File Offset: 0x00112F5C
		public void AppendFormatted<T>([Nullable(1)] T value, int alignment, string format)
		{
			int pos = this._pos;
			this.AppendFormatted<T>(value, format);
			if (alignment != 0)
			{
				this.AppendOrInsertAlignmentIfNeeded(pos, alignment);
			}
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x00114D83 File Offset: 0x00112F83
		[NullableContext(0)]
		public void AppendFormatted([ScopedRef] ReadOnlySpan<char> value)
		{
			if (value.TryCopyTo(this._chars.Slice(this._pos)))
			{
				this._pos += value.Length;
				return;
			}
			this.GrowThenCopySpan(value);
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x00114DBC File Offset: 0x00112FBC
		[NullableContext(0)]
		public void AppendFormatted([ScopedRef] ReadOnlySpan<char> value, int alignment = 0, [Nullable(2)] string format = null)
		{
			bool flag = false;
			if (alignment < 0)
			{
				flag = true;
				alignment = -alignment;
			}
			int num = alignment - value.Length;
			if (num <= 0)
			{
				this.AppendFormatted(value);
				return;
			}
			this.EnsureCapacityForAdditionalChars(value.Length + num);
			if (flag)
			{
				value.CopyTo(this._chars.Slice(this._pos));
				this._pos += value.Length;
				this._chars.Slice(this._pos, num).Fill(' ');
				this._pos += num;
				return;
			}
			this._chars.Slice(this._pos, num).Fill(' ');
			this._pos += num;
			value.CopyTo(this._chars.Slice(this._pos));
			this._pos += value.Length;
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x00114EAC File Offset: 0x001130AC
		public void AppendFormatted(string value)
		{
			if (!this._hasCustomFormatter && value != null && value.TryCopyTo(this._chars.Slice(this._pos)))
			{
				this._pos += value.Length;
				return;
			}
			this.AppendFormattedSlow(value);
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x00114EF8 File Offset: 0x001130F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AppendFormattedSlow(string value)
		{
			if (this._hasCustomFormatter)
			{
				this.AppendCustomFormatter<string>(value, null);
				return;
			}
			if (value != null)
			{
				this.EnsureCapacityForAdditionalChars(value.Length);
				value.CopyTo(this._chars.Slice(this._pos));
				this._pos += value.Length;
			}
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00114F4F File Offset: 0x0011314F
		public void AppendFormatted(string value, int alignment = 0, string format = null)
		{
			this.AppendFormatted<string>(value, alignment, format);
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x00114F5A File Offset: 0x0011315A
		public void AppendFormatted(object value, int alignment = 0, string format = null)
		{
			this.AppendFormatted<object>(value, alignment, format);
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x00114F65 File Offset: 0x00113165
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool HasCustomFormatter(IFormatProvider provider)
		{
			return provider.GetType() != typeof(CultureInfo) && provider.GetFormat(typeof(ICustomFormatter)) != null;
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x00114F94 File Offset: 0x00113194
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AppendCustomFormatter<T>(T value, string format)
		{
			ICustomFormatter customFormatter = (ICustomFormatter)this._provider.GetFormat(typeof(ICustomFormatter));
			if (customFormatter != null)
			{
				string text = customFormatter.Format(format, value, this._provider);
				if (text != null)
				{
					this.AppendLiteral(text);
				}
			}
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x00114FE0 File Offset: 0x001131E0
		private void AppendOrInsertAlignmentIfNeeded(int startingPos, int alignment)
		{
			int num = this._pos - startingPos;
			bool flag = false;
			if (alignment < 0)
			{
				flag = true;
				alignment = -alignment;
			}
			int num2 = alignment - num;
			if (num2 > 0)
			{
				this.EnsureCapacityForAdditionalChars(num2);
				if (flag)
				{
					this._chars.Slice(this._pos, num2).Fill(' ');
				}
				else
				{
					this._chars.Slice(startingPos, num).CopyTo(this._chars.Slice(startingPos + num2));
					this._chars.Slice(startingPos, num2).Fill(' ');
				}
				this._pos += num2;
			}
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x0011507A File Offset: 0x0011327A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void EnsureCapacityForAdditionalChars(int additionalChars)
		{
			if (this._chars.Length - this._pos < additionalChars)
			{
				this.Grow(additionalChars);
			}
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x00115098 File Offset: 0x00113298
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GrowThenCopyString(string value)
		{
			this.Grow(value.Length);
			value.CopyTo(this._chars.Slice(this._pos));
			this._pos += value.Length;
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x001150D0 File Offset: 0x001132D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GrowThenCopySpan([ScopedRef] ReadOnlySpan<char> value)
		{
			this.Grow(value.Length);
			value.CopyTo(this._chars.Slice(this._pos));
			this._pos += value.Length;
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x0011510B File Offset: 0x0011330B
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Grow(int additionalChars)
		{
			this.GrowCore((uint)(this._pos + additionalChars));
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x0011511B File Offset: 0x0011331B
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Grow()
		{
			this.GrowCore((uint)(this._chars.Length + 1));
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x00115130 File Offset: 0x00113330
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void GrowCore(uint requiredMinCapacity)
		{
			int minimumLength = (int)Math.Clamp(Math.Max(requiredMinCapacity, Math.Min((uint)(this._chars.Length * 2), 1073741791U)), 256U, 2147483647U);
			char[] array = ArrayPool<char>.Shared.Rent(minimumLength);
			this._chars.Slice(0, this._pos).CopyTo(array);
			char[] arrayToReturnToPool = this._arrayToReturnToPool;
			this._chars = (this._arrayToReturnToPool = array);
			if (arrayToReturnToPool != null)
			{
				ArrayPool<char>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x040014B8 RID: 5304
		private readonly IFormatProvider _provider;

		// Token: 0x040014B9 RID: 5305
		private char[] _arrayToReturnToPool;

		// Token: 0x040014BA RID: 5306
		private Span<char> _chars;

		// Token: 0x040014BB RID: 5307
		private int _pos;

		// Token: 0x040014BC RID: 5308
		private readonly bool _hasCustomFormatter;
	}
}
