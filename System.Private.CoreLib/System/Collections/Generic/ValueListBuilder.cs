using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009E7 RID: 2535
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x06009400 RID: 37888 RVA: 0x001712C8 File Offset: 0x0016F4C8
		public ValueListBuilder(Span<T> initialSpan)
		{
			this._span = initialSpan;
			this._arrayFromPool = null;
			this._pos = 0;
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06009401 RID: 37889 RVA: 0x001712DF File Offset: 0x0016F4DF
		// (set) Token: 0x06009402 RID: 37890 RVA: 0x001712E7 File Offset: 0x0016F4E7
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

		// Token: 0x1700142D RID: 5165
		public T this[int index]
		{
			get
			{
				return this._span[index];
			}
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x00171300 File Offset: 0x0016F500
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append(T item)
		{
			int pos = this._pos;
			Span<T> span = this._span;
			if (pos < span.Length)
			{
				*span[pos] = item;
				this._pos = pos + 1;
				return;
			}
			this.AddWithResize(item);
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x00171344 File Offset: 0x0016F544
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append([ScopedRef] ReadOnlySpan<T> source)
		{
			int pos = this._pos;
			Span<T> span = this._span;
			if (source.Length == 1 && pos < span.Length)
			{
				*span[pos] = *source[0];
				this._pos = pos + 1;
				return;
			}
			this.AppendMultiChar(source);
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x001713A0 File Offset: 0x0016F5A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AppendMultiChar([ScopedRef] ReadOnlySpan<T> source)
		{
			if (this._pos + source.Length > this._span.Length)
			{
				this.Grow(this._span.Length - this._pos + source.Length);
			}
			source.CopyTo(this._span.Slice(this._pos));
			this._pos += source.Length;
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x00171414 File Offset: 0x0016F614
		public void Insert(int index, [ScopedRef] ReadOnlySpan<T> source)
		{
			if (this._pos + source.Length > this._span.Length)
			{
				this.Grow(source.Length);
			}
			this._span.Slice(0, this._pos).CopyTo(this._span.Slice(source.Length));
			source.CopyTo(this._span);
			this._pos += source.Length;
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x00171498 File Offset: 0x0016F698
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<T> AppendSpan(int length)
		{
			int pos = this._pos;
			Span<T> span = this._span;
			if ((ulong)pos + (ulong)length <= (ulong)span.Length)
			{
				this._pos = pos + length;
				return span.Slice(pos, length);
			}
			return this.AppendSpanWithGrow(length);
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x001714DC File Offset: 0x0016F6DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Span<T> AppendSpanWithGrow(int length)
		{
			int pos = this._pos;
			this.Grow(this._span.Length - pos + length);
			this._pos += length;
			return this._span.Slice(pos, length);
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x00171520 File Offset: 0x0016F720
		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void AddWithResize(T item)
		{
			int pos = this._pos;
			this.Grow(1);
			*this._span[pos] = item;
			this._pos = pos + 1;
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x00171556 File Offset: 0x0016F756
		public ReadOnlySpan<T> AsSpan()
		{
			return this._span.Slice(0, this._pos);
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x00171570 File Offset: 0x0016F770
		public bool TryCopyTo(Span<T> destination, out int itemsWritten)
		{
			if (this._span.Slice(0, this._pos).TryCopyTo(destination))
			{
				itemsWritten = this._pos;
				return true;
			}
			itemsWritten = 0;
			return false;
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x001715A8 File Offset: 0x0016F7A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Dispose()
		{
			T[] arrayFromPool = this._arrayFromPool;
			if (arrayFromPool != null)
			{
				this._arrayFromPool = null;
				ArrayPool<T>.Shared.Return(arrayFromPool, false);
			}
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x001715D4 File Offset: 0x0016F7D4
		private void Grow(int additionalCapacityRequired = 1)
		{
			int num = Math.Max((this._span.Length != 0) ? (this._span.Length * 2) : 4, this._span.Length + additionalCapacityRequired);
			if (num > 2147483591)
			{
				num = Math.Max(Math.Max(this._span.Length + 1, 2147483591), this._span.Length);
			}
			T[] array = ArrayPool<T>.Shared.Rent(num);
			this._span.CopyTo(array);
			T[] arrayFromPool = this._arrayFromPool;
			this._span = (this._arrayFromPool = array);
			if (arrayFromPool != null)
			{
				ArrayPool<T>.Shared.Return(arrayFromPool, false);
			}
		}

		// Token: 0x040022B7 RID: 8887
		private Span<T> _span;

		// Token: 0x040022B8 RID: 8888
		private T[] _arrayFromPool;

		// Token: 0x040022B9 RID: 8889
		private int _pos;
	}
}
