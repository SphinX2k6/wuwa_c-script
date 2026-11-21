using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000382 RID: 898
	internal readonly struct RabinKarp
	{
		// Token: 0x06003C13 RID: 15379 RVA: 0x000C8548 File Offset: 0x000C6748
		public unsafe RabinKarp(ReadOnlySpan<string> values)
		{
			int num = int.MaxValue;
			ReadOnlySpan<string> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text = *readOnlySpan[i];
				num = Math.Min(num, text.Length);
			}
			this._hashLength = num;
			this._hashUpdateMultiplier = (UIntPtr)((IntPtr)1 << ((num - 1) * 2 & 8 * 8 - 1));
			if (num > 17)
			{
				this._buckets = null;
				return;
			}
			string[][] array = this._buckets = new string[64L][];
			readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text2 = *readOnlySpan[i];
				if (text2.Length <= 17)
				{
					UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
					for (int j = 0; j < num; j++)
					{
						uintPtr = (uintPtr << (2 & 8 * 8 - 1)) + (UIntPtr)text2[j];
					}
					UIntPtr uintPtr2 = uintPtr % (UIntPtr)((IntPtr)64);
					string[] array2 = array[(int)(checked((IntPtr)(unchecked((ulong)uintPtr2))))];
					string[] array3;
					if (array2 != null)
					{
						array3 = new string[array2.Length + 1];
						array2.AsSpan<string>().CopyTo(array3);
					}
					else
					{
						array3 = new string[1];
					}
					string[] array4 = array3;
					array4[array4.Length - 1] = text2;
					array[(int)(checked((IntPtr)(unchecked((ulong)uintPtr2))))] = array3;
				}
			}
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x000C867F File Offset: 0x000C687F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int IndexOfAny<TCaseSensitivity>(ReadOnlySpan<char> span) where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
		{
			if (!(typeof(TCaseSensitivity) == typeof(StringSearchValuesHelper.CaseInsensitiveUnicode)))
			{
				return this.IndexOfAnyCore<TCaseSensitivity>(span);
			}
			return this.IndexOfAnyCaseInsensitiveUnicode(span);
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x000C86AC File Offset: 0x000C68AC
		private unsafe int IndexOfAnyCore<TCaseSensitivity>(ReadOnlySpan<char> span) where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
		{
			ref char ptr = ref MemoryMarshal.GetReference<char>(span);
			int hashLength = this._hashLength;
			if (span.Length >= hashLength)
			{
				ref char right = ref Unsafe.Add<char>(MemoryMarshal.GetReference<char>(span), (UIntPtr)(span.Length - hashLength));
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				uint num = 0U;
				while ((ulong)num < (ulong)((long)hashLength))
				{
					uintPtr = (uintPtr << (2 & 8 * 8 - 1)) + (UIntPtr)StringSearchValuesHelper.ICaseSensitivity.TransformInput(*Unsafe.Add<char>(ref ptr, (UIntPtr)num));
					num += 1U;
				}
				ref string[] arrayDataReference = ref MemoryMarshal.GetArrayDataReference<string[]>(this._buckets);
				int num2;
				for (;;)
				{
					string[] array = *Unsafe.Add<string[]>(ref arrayDataReference, uintPtr % (UIntPtr)((IntPtr)64));
					if (array != null)
					{
						num2 = (int)(Unsafe.ByteOffset<char>(MemoryMarshal.GetReference<char>(span), ref ptr) / (IntPtr)2);
						if (StringSearchValuesHelper.StartsWith<TCaseSensitivity>(ref ptr, span.Length - num2, array))
						{
							break;
						}
					}
					if (!Unsafe.IsAddressLessThan<char>(ref ptr, ref right))
					{
						return -1;
					}
					char c = StringSearchValuesHelper.ICaseSensitivity.TransformInput(ptr);
					char c2 = StringSearchValuesHelper.ICaseSensitivity.TransformInput(*Unsafe.Add<char>(ref ptr, (UIntPtr)hashLength));
					uintPtr = (uintPtr - (UIntPtr)c * this._hashUpdateMultiplier << (2 & 8 * 8 - 1)) + (UIntPtr)c2;
					ptr = Unsafe.Add<char>(ref ptr, 1);
				}
				return num2;
			}
			return -1;
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x000C87C8 File Offset: 0x000C69C8
		private unsafe int IndexOfAnyCaseInsensitiveUnicode(ReadOnlySpan<char> span)
		{
			if (this._hashLength > span.Length)
			{
				return -1;
			}
			Span<char> span2 = new Span<char>(stackalloc byte[(UIntPtr)34], 17).Slice(0, span.Length);
			Ordinal.ToUpperOrdinal(span, span2);
			return this.IndexOfAnyCore<StringSearchValuesHelper.CaseSensitive>(span2);
		}

		// Token: 0x04000CAD RID: 3245
		private readonly string[][] _buckets;

		// Token: 0x04000CAE RID: 3246
		private readonly int _hashLength;

		// Token: 0x04000CAF RID: 3247
		private readonly UIntPtr _hashUpdateMultiplier;
	}
}
