using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Text;

namespace System.Buffers
{
	// Token: 0x02000383 RID: 899
	internal static class StringSearchValuesHelper
	{
		// Token: 0x06003C17 RID: 15383 RVA: 0x000C8818 File Offset: 0x000C6A18
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool StartsWith<TCaseSensitivity>(ref char matchStart, int lengthRemaining, string[] candidates) where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
		{
			foreach (string candidate in candidates)
			{
				if (StringSearchValuesHelper.StartsWith<TCaseSensitivity>(ref matchStart, lengthRemaining, candidate))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x000C8846 File Offset: 0x000C6A46
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool StartsWith<TCaseSensitivity>(ref char matchStart, int lengthRemaining, string candidate) where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
		{
			return lengthRemaining >= candidate.Length && StringSearchValuesHelper.ICaseSensitivity.Equals<StringSearchValuesHelper.ValueLength8OrLongerOrUnknown>(ref matchStart, candidate);
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x000C8860 File Offset: 0x000C6A60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool ScalarEquals<TCaseSensitivity>(ref char matchStart, string candidate) where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
		{
			for (int i = 0; i < candidate.Length; i++)
			{
				if (StringSearchValuesHelper.ICaseSensitivity.TransformInput(*Unsafe.Add<char>(ref matchStart, i)) != candidate[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x02000384 RID: 900
		public interface IValueLength
		{
			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x06003C1A RID: 15386
			bool AtLeast4Chars { get; }

			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x06003C1B RID: 15387
			bool AtLeast8CharsOrUnknown { get; }
		}

		// Token: 0x02000385 RID: 901
		public readonly struct ValueLengthLessThan4 : StringSearchValuesHelper.IValueLength
		{
			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x06003C1C RID: 15388 RVA: 0x00007B65 File Offset: 0x00005D65
			public static bool AtLeast4Chars
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x06003C1D RID: 15389 RVA: 0x00007B65 File Offset: 0x00005D65
			public static bool AtLeast8CharsOrUnknown
			{
				get
				{
					return false;
				}
			}
		}

		// Token: 0x02000386 RID: 902
		public readonly struct ValueLength4To7 : StringSearchValuesHelper.IValueLength
		{
			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06003C1E RID: 15390 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool AtLeast4Chars
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06003C1F RID: 15391 RVA: 0x00007B65 File Offset: 0x00005D65
			public static bool AtLeast8CharsOrUnknown
			{
				get
				{
					return false;
				}
			}
		}

		// Token: 0x02000387 RID: 903
		public readonly struct ValueLength8OrLongerOrUnknown : StringSearchValuesHelper.IValueLength
		{
			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06003C20 RID: 15392 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool AtLeast4Chars
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06003C21 RID: 15393 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool AtLeast8CharsOrUnknown
			{
				get
				{
					return true;
				}
			}
		}

		// Token: 0x02000388 RID: 904
		public interface ICaseSensitivity
		{
			// Token: 0x06003C22 RID: 15394
			public abstract static char TransformInput(char input);

			// Token: 0x06003C23 RID: 15395
			public abstract static Vector128<byte> TransformInput(Vector128<byte> input);

			// Token: 0x06003C24 RID: 15396
			public abstract static Vector256<byte> TransformInput(Vector256<byte> input);

			// Token: 0x06003C25 RID: 15397
			public abstract static Vector512<byte> TransformInput(Vector512<byte> input);

			// Token: 0x06003C26 RID: 15398
			public abstract static bool Equals<TValueLength>(ref char matchStart, string candidate);
		}

		// Token: 0x02000389 RID: 905
		public readonly struct CaseSensitive : StringSearchValuesHelper.ICaseSensitivity
		{
			// Token: 0x06003C27 RID: 15399 RVA: 0x00007B62 File Offset: 0x00005D62
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static char TransformInput(char input)
			{
				return input;
			}

			// Token: 0x06003C28 RID: 15400 RVA: 0x00007B62 File Offset: 0x00005D62
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<byte> TransformInput(Vector128<byte> input)
			{
				return input;
			}

			// Token: 0x06003C29 RID: 15401 RVA: 0x00007B62 File Offset: 0x00005D62
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<byte> TransformInput(Vector256<byte> input)
			{
				return input;
			}

			// Token: 0x06003C2A RID: 15402 RVA: 0x00007B62 File Offset: 0x00005D62
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector512<byte> TransformInput(Vector512<byte> input)
			{
				return input;
			}

			// Token: 0x06003C2B RID: 15403 RVA: 0x000C88A0 File Offset: 0x000C6AA0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool Equals<TValueLength>(ref char matchStart, string candidate) where TValueLength : struct, StringSearchValuesHelper.IValueLength
			{
				ref byte ptr = ref Unsafe.As<char, byte>(ref matchStart);
				ref byte ptr2 = ref Unsafe.As<char, byte>(candidate.GetRawStringData());
				UIntPtr uintPtr = (UIntPtr)candidate.Length * (UIntPtr)((IntPtr)2);
				if (StringSearchValuesHelper.IValueLength.AtLeast8CharsOrUnknown)
				{
					return SpanHelpers.SequenceEqual(ref ptr, ref ptr2, uintPtr);
				}
				if (StringSearchValuesHelper.IValueLength.AtLeast4Chars)
				{
					UIntPtr elementOffset = uintPtr - (UIntPtr)((IntPtr)8);
					return (Unsafe.ReadUnaligned<ulong>(ref ptr) - Unsafe.ReadUnaligned<ulong>(ref ptr2) | Unsafe.ReadUnaligned<ulong>(Unsafe.Add<byte>(ref ptr, elementOffset)) - Unsafe.ReadUnaligned<ulong>(Unsafe.Add<byte>(ref ptr2, elementOffset))) == 0UL;
				}
				UIntPtr elementOffset2 = uintPtr - (UIntPtr)((IntPtr)4);
				return Unsafe.ReadUnaligned<uint>(Unsafe.Add<byte>(ref ptr, elementOffset2)) == Unsafe.ReadUnaligned<uint>(Unsafe.Add<byte>(ref ptr2, elementOffset2));
			}
		}

		// Token: 0x0200038A RID: 906
		public readonly struct CaseInsensitiveAsciiLetters : StringSearchValuesHelper.ICaseSensitivity
		{
			// Token: 0x06003C2C RID: 15404 RVA: 0x000C8941 File Offset: 0x000C6B41
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static char TransformInput(char input)
			{
				return (char)((int)input & -33);
			}

			// Token: 0x06003C2D RID: 15405 RVA: 0x000C8948 File Offset: 0x000C6B48
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<byte> TransformInput(Vector128<byte> input)
			{
				return input & Vector128.Create(223);
			}

			// Token: 0x06003C2E RID: 15406 RVA: 0x000C895A File Offset: 0x000C6B5A
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<byte> TransformInput(Vector256<byte> input)
			{
				return input & Vector256.Create(223);
			}

			// Token: 0x06003C2F RID: 15407 RVA: 0x000C896C File Offset: 0x000C6B6C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector512<byte> TransformInput(Vector512<byte> input)
			{
				return input & Vector512.Create(223);
			}

			// Token: 0x06003C30 RID: 15408 RVA: 0x000C8980 File Offset: 0x000C6B80
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool Equals<TValueLength>(ref char matchStart, string candidate) where TValueLength : struct, StringSearchValuesHelper.IValueLength
			{
				if (StringSearchValuesHelper.IValueLength.AtLeast8CharsOrUnknown)
				{
					return Ascii.EqualsIgnoreCase(ref matchStart, candidate.GetRawStringData(), (UIntPtr)candidate.Length);
				}
				ref byte source = ref Unsafe.As<char, byte>(ref matchStart);
				ref byte source2 = ref Unsafe.As<char, byte>(candidate.GetRawStringData());
				UIntPtr uintPtr = (UIntPtr)candidate.Length * (UIntPtr)((IntPtr)2);
				if (StringSearchValuesHelper.IValueLength.AtLeast4Chars)
				{
					UIntPtr elementOffset = uintPtr - (UIntPtr)((IntPtr)8);
					return ((Unsafe.ReadUnaligned<ulong>(ref source) & 18437736737013759967UL) - Unsafe.ReadUnaligned<ulong>(ref source2) | (Unsafe.ReadUnaligned<ulong>(Unsafe.Add<byte>(ref source, elementOffset)) & 18437736737013759967UL) - Unsafe.ReadUnaligned<ulong>(Unsafe.Add<byte>(ref source2, elementOffset))) == 0UL;
				}
				UIntPtr elementOffset2 = uintPtr - (UIntPtr)((IntPtr)4);
				return ((Unsafe.ReadUnaligned<uint>(ref source) & 4292870111U) - Unsafe.ReadUnaligned<uint>(ref source2) | (Unsafe.ReadUnaligned<uint>(Unsafe.Add<byte>(ref source, elementOffset2)) & 4292870111U) - Unsafe.ReadUnaligned<uint>(Unsafe.Add<byte>(ref source2, elementOffset2))) == 0U;
			}
		}

		// Token: 0x0200038B RID: 907
		public readonly struct CaseInsensitiveAscii : StringSearchValuesHelper.ICaseSensitivity
		{
			// Token: 0x06003C31 RID: 15409 RVA: 0x000C8A5C File Offset: 0x000C6C5C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static char TransformInput(char input)
			{
				return TextInfo.ToUpperAsciiInvariant(input);
			}

			// Token: 0x06003C32 RID: 15410 RVA: 0x000C8A64 File Offset: 0x000C6C64
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<byte> TransformInput(Vector128<byte> input)
			{
				Vector128<byte> right = Vector128.Create(225);
				Vector128<byte> vector = Vector128.Create(154);
				Vector128<byte> right2 = Vector128.Create(32);
				Vector128<byte> left = Vector128.LessThan<sbyte>((input - right).AsSByte<byte>(), vector.AsSByte<byte>()).AsByte<sbyte>();
				return input ^ (left & right2);
			}

			// Token: 0x06003C33 RID: 15411 RVA: 0x000C8ABC File Offset: 0x000C6CBC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<byte> TransformInput(Vector256<byte> input)
			{
				Vector256<byte> right = Vector256.Create(225);
				Vector256<byte> vector = Vector256.Create(154);
				Vector256<byte> right2 = Vector256.Create(32);
				Vector256<byte> left = Vector256.LessThan<sbyte>((input - right).AsSByte<byte>(), vector.AsSByte<byte>()).AsByte<sbyte>();
				return input ^ (left & right2);
			}

			// Token: 0x06003C34 RID: 15412 RVA: 0x000C8B14 File Offset: 0x000C6D14
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector512<byte> TransformInput(Vector512<byte> input)
			{
				Vector512<byte> right = Vector512.Create(225);
				Vector512<byte> vector = Vector512.Create(154);
				Vector512<byte> right2 = Vector512.Create(32);
				Vector512<byte> left = Vector512.LessThan<sbyte>((input - right).AsSByte<byte>(), vector.AsSByte<byte>()).AsByte<sbyte>();
				return input ^ (left & right2);
			}

			// Token: 0x06003C35 RID: 15413 RVA: 0x000C8B69 File Offset: 0x000C6D69
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool Equals<TValueLength>(ref char matchStart, string candidate) where TValueLength : struct, StringSearchValuesHelper.IValueLength
			{
				if (StringSearchValuesHelper.IValueLength.AtLeast8CharsOrUnknown)
				{
					return Ascii.EqualsIgnoreCase(ref matchStart, candidate.GetRawStringData(), (UIntPtr)candidate.Length);
				}
				return StringSearchValuesHelper.ScalarEquals<StringSearchValuesHelper.CaseInsensitiveAscii>(ref matchStart, candidate);
			}
		}

		// Token: 0x0200038C RID: 908
		public readonly struct CaseInsensitiveUnicode : StringSearchValuesHelper.ICaseSensitivity
		{
			// Token: 0x06003C36 RID: 15414 RVA: 0x000C7206 File Offset: 0x000C5406
			public static char TransformInput(char input)
			{
				throw new UnreachableException();
			}

			// Token: 0x06003C37 RID: 15415 RVA: 0x000C8B94 File Offset: 0x000C6D94
			public static Vector128<byte> TransformInput(Vector128<byte> input)
			{
				throw new UnreachableException();
			}

			// Token: 0x06003C38 RID: 15416 RVA: 0x000C8BA8 File Offset: 0x000C6DA8
			public static Vector256<byte> TransformInput(Vector256<byte> input)
			{
				throw new UnreachableException();
			}

			// Token: 0x06003C39 RID: 15417 RVA: 0x000C8BBC File Offset: 0x000C6DBC
			public static Vector512<byte> TransformInput(Vector512<byte> input)
			{
				throw new UnreachableException();
			}

			// Token: 0x06003C3A RID: 15418 RVA: 0x000C8BCE File Offset: 0x000C6DCE
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool Equals<TValueLength>(ref char matchStart, string candidate) where TValueLength : struct, StringSearchValuesHelper.IValueLength
			{
				if (StringSearchValuesHelper.IValueLength.AtLeast8CharsOrUnknown)
				{
					return Ordinal.EqualsIgnoreCase(ref matchStart, candidate.GetRawStringData(), candidate.Length);
				}
				return Ordinal.EqualsIgnoreCase_Scalar(ref matchStart, candidate.GetRawStringData(), candidate.Length);
			}
		}
	}
}
