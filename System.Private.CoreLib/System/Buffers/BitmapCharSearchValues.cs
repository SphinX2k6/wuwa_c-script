using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000372 RID: 882
	internal sealed class BitmapCharSearchValues : SearchValues<char>
	{
		// Token: 0x06003BBC RID: 15292 RVA: 0x000C6B8C File Offset: 0x000C4D8C
		public unsafe BitmapCharSearchValues(ReadOnlySpan<char> values, int maxInclusive)
		{
			this._bitmap = new uint[maxInclusive / 32 + 1];
			ReadOnlySpan<char> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				char c = (char)(*readOnlySpan[i]);
				this._bitmap[(int)(c >> 5)] |= 1U << (int)c;
			}
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x000C6BE8 File Offset: 0x000C4DE8
		internal override char[] GetValues()
		{
			List<char> list = new List<char>();
			uint[] bitmap = this._bitmap;
			for (int i = 0; i < this._bitmap.Length * 32; i++)
			{
				if (BitmapCharSearchValues.Contains(bitmap, i))
				{
					list.Add((char)i);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x000C6C2F File Offset: 0x000C4E2F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return BitmapCharSearchValues.Contains(this._bitmap, (int)value);
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x000C6C40 File Offset: 0x000C4E40
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool Contains(uint[] bitmap, int value)
		{
			uint num = (uint)(value >> 5);
			return num < (uint)bitmap.Length && (bitmap[(int)num] & 1U << value) > 0U;
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x000C6C66 File Offset: 0x000C4E66
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<char> span)
		{
			return this.IndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(MemoryMarshal.GetReference<char>(span), span.Length);
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x000C6C7B File Offset: 0x000C4E7B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return this.IndexOfAny<IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<char>(span), span.Length);
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x000C6C90 File Offset: 0x000C4E90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return this.LastIndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(MemoryMarshal.GetReference<char>(span), span.Length);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x000C6CA5 File Offset: 0x000C4EA5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return this.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<char>(span), span.Length);
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x000C6CBC File Offset: 0x000C4EBC
		private int IndexOfAny<TNegator>(ref char searchSpace, int searchSpaceLength) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			ref char right = ref Unsafe.Add<char>(ref searchSpace, searchSpaceLength);
			ref char ptr = ref searchSpace;
			uint[] bitmap = this._bitmap;
			while (!Unsafe.AreSame<char>(ref ptr, ref right))
			{
				char value = ptr;
				if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(BitmapCharSearchValues.Contains(bitmap, (int)value)))
				{
					return (int)(Unsafe.ByteOffset<char>(ref searchSpace, ref ptr) / (IntPtr)2);
				}
				ptr = Unsafe.Add<char>(ref ptr, 1);
			}
			return -1;
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x000C6D14 File Offset: 0x000C4F14
		private unsafe int LastIndexOfAny<TNegator>(ref char searchSpace, int searchSpaceLength) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			uint[] bitmap = this._bitmap;
			while (--searchSpaceLength >= 0)
			{
				char value = *Unsafe.Add<char>(ref searchSpace, searchSpaceLength);
				if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(BitmapCharSearchValues.Contains(bitmap, (int)value)))
				{
					break;
				}
			}
			return searchSpaceLength;
		}

		// Token: 0x04000C97 RID: 3223
		private readonly uint[] _bitmap;
	}
}
