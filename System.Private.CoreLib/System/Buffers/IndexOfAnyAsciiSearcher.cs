using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Wasm;
using System.Runtime.Intrinsics.X86;

namespace System.Buffers
{
	// Token: 0x02000362 RID: 866
	internal static class IndexOfAnyAsciiSearcher
	{
		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06003B59 RID: 15193 RVA: 0x000C5900 File Offset: 0x000C3B00
		internal static bool IsVectorizationSupported
		{
			get
			{
				return Ssse3.IsSupported;
			}
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x000C5910 File Offset: 0x000C3B10
		internal unsafe static void ComputeAnyByteState(ReadOnlySpan<byte> values, out IndexOfAnyAsciiSearcher.AnyByteState state)
		{
			Vector128<byte> bitmap = default(Vector128<byte>);
			Vector128<byte> bitmap2 = default(Vector128<byte>);
			byte* ptr = (byte*)(&bitmap);
			byte* ptr2 = (byte*)(&bitmap2);
			BitVector256 lookup = default(BitVector256);
			ReadOnlySpan<byte> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				byte b = *readOnlySpan[i];
				lookup.Set((int)b);
				int num = b >> 4;
				int num2 = (int)(b & 15);
				if (num < 8)
				{
					byte* ptr3 = ptr + num2;
					*ptr3 |= (byte)(1 << num);
				}
				else
				{
					byte* ptr4 = ptr2 + num2;
					*ptr4 |= (byte)(1 << num - 8);
				}
			}
			state = new IndexOfAnyAsciiSearcher.AnyByteState(bitmap, bitmap2, lookup);
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x000C59B4 File Offset: 0x000C3BB4
		internal unsafe static void ComputeAsciiState<T>(ReadOnlySpan<T> values, out IndexOfAnyAsciiSearcher.AsciiState state) where T : struct, IUnsignedNumber<T>
		{
			Vector128<byte> bitmap = default(Vector128<byte>);
			byte* ptr = (byte*)(&bitmap);
			BitVector256 lookup = default(BitVector256);
			ReadOnlySpan<T> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				int num = int.CreateChecked<T>(*readOnlySpan[i]);
				if (num <= 127)
				{
					lookup.Set(num);
					int num2 = num >> 4;
					int num3 = num & 15;
					byte* ptr2 = ptr + num3;
					*ptr2 |= (byte)(1 << num2);
				}
			}
			state = new IndexOfAnyAsciiSearcher.AsciiState(bitmap, lookup);
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x000C5A40 File Offset: 0x000C3C40
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryComputeBitmap(ReadOnlySpan<char> values, byte* bitmap, out bool needleContainsZero)
		{
			ReadOnlySpan<char> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				char c = (char)(*readOnlySpan[i]);
				if (c > '\u007f')
				{
					needleContainsZero = false;
					return false;
				}
				int num = (int)(c >> 4);
				int num2 = (int)(c & '\u000f');
				byte* ptr = bitmap + num2;
				*ptr |= (byte)(1 << num);
			}
			needleContainsZero = ((*bitmap & 1) > 0);
			return true;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x000C5A9E File Offset: 0x000C3C9E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryIndexOfAny(ref char searchSpace, int searchSpaceLength, ReadOnlySpan<char> asciiValues, out int index)
		{
			return IndexOfAnyAsciiSearcher.TryIndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(Unsafe.As<char, short>(ref searchSpace), searchSpaceLength, asciiValues, out index);
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x000C5AAE File Offset: 0x000C3CAE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryIndexOfAnyExcept(ref char searchSpace, int searchSpaceLength, ReadOnlySpan<char> asciiValues, out int index)
		{
			return IndexOfAnyAsciiSearcher.TryIndexOfAny<IndexOfAnyAsciiSearcher.Negate>(Unsafe.As<char, short>(ref searchSpace), searchSpaceLength, asciiValues, out index);
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x000C5ABE File Offset: 0x000C3CBE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryLastIndexOfAny(ref char searchSpace, int searchSpaceLength, ReadOnlySpan<char> asciiValues, out int index)
		{
			return IndexOfAnyAsciiSearcher.TryLastIndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(Unsafe.As<char, short>(ref searchSpace), searchSpaceLength, asciiValues, out index);
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x000C5ACE File Offset: 0x000C3CCE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryLastIndexOfAnyExcept(ref char searchSpace, int searchSpaceLength, ReadOnlySpan<char> asciiValues, out int index)
		{
			return IndexOfAnyAsciiSearcher.TryLastIndexOfAny<IndexOfAnyAsciiSearcher.Negate>(Unsafe.As<char, short>(ref searchSpace), searchSpaceLength, asciiValues, out index);
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x000C5AE0 File Offset: 0x000C3CE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryIndexOfAny<TNegator>(ref short searchSpace, int searchSpaceLength, ReadOnlySpan<char> asciiValues, out int index) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported)
			{
				IndexOfAnyAsciiSearcher.AsciiState asciiState = default(IndexOfAnyAsciiSearcher.AsciiState);
				bool flag;
				if (IndexOfAnyAsciiSearcher.TryComputeBitmap(asciiValues, (byte*)(&asciiState.Bitmap._lower), out flag))
				{
					asciiState.Bitmap = Vector256.Create<byte>(asciiState.Bitmap.GetLower<byte>());
					index = ((Ssse3.IsSupported && flag) ? IndexOfAnyAsciiSearcher.IndexOfAny<TNegator, IndexOfAnyAsciiSearcher.Ssse3AndWasmHandleZeroInNeedle>(ref searchSpace, searchSpaceLength, ref asciiState) : IndexOfAnyAsciiSearcher.IndexOfAny<TNegator, IndexOfAnyAsciiSearcher.Default>(ref searchSpace, searchSpaceLength, ref asciiState));
					return true;
				}
			}
			index = 0;
			return false;
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x000C5B58 File Offset: 0x000C3D58
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryLastIndexOfAny<TNegator>(ref short searchSpace, int searchSpaceLength, ReadOnlySpan<char> asciiValues, out int index) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported)
			{
				IndexOfAnyAsciiSearcher.AsciiState asciiState = default(IndexOfAnyAsciiSearcher.AsciiState);
				bool flag;
				if (IndexOfAnyAsciiSearcher.TryComputeBitmap(asciiValues, (byte*)(&asciiState.Bitmap._lower), out flag))
				{
					asciiState.Bitmap = Vector256.Create<byte>(asciiState.Bitmap.GetLower<byte>());
					index = ((Ssse3.IsSupported && flag) ? IndexOfAnyAsciiSearcher.LastIndexOfAny<TNegator, IndexOfAnyAsciiSearcher.Ssse3AndWasmHandleZeroInNeedle>(ref searchSpace, searchSpaceLength, ref asciiState) : IndexOfAnyAsciiSearcher.LastIndexOfAny<TNegator, IndexOfAnyAsciiSearcher.Default>(ref searchSpace, searchSpaceLength, ref asciiState));
					return true;
				}
			}
			index = 0;
			return false;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x000C5BCD File Offset: 0x000C3DCD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<TNegator, TOptimizations>(ref short searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AsciiState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator where TOptimizations : struct, IndexOfAnyAsciiSearcher.IOptimizations
		{
			return IndexOfAnyAsciiSearcher.IndexOfAnyCore<bool, TNegator, TOptimizations, IndexOfAnyAsciiSearcher.ContainsAnyResultMapper<short>>(ref searchSpace, searchSpaceLength, ref state);
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x000C5BD7 File Offset: 0x000C3DD7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<TNegator, TOptimizations>(ref short searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AsciiState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator where TOptimizations : struct, IndexOfAnyAsciiSearcher.IOptimizations
		{
			return IndexOfAnyAsciiSearcher.IndexOfAnyCore<int, TNegator, TOptimizations, IndexOfAnyAsciiSearcher.IndexOfAnyResultMapper<short>>(ref searchSpace, searchSpaceLength, ref state);
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x000C5BE4 File Offset: 0x000C3DE4
		private static TResult IndexOfAnyCore<TResult, TNegator, TOptimizations, TResultMapper>(ref short searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AsciiState state) where TResult : struct where TNegator : struct, IndexOfAnyAsciiSearcher.INegator where TOptimizations : struct, IndexOfAnyAsciiSearcher.IOptimizations where TResultMapper : struct, IndexOfAnyAsciiSearcher.IResultMapper<short, TResult>
		{
			ref short ptr = ref searchSpace;
			if (searchSpaceLength < Vector128<ushort>.Count)
			{
				ref short right = ref Unsafe.Add<short>(ref searchSpace, searchSpaceLength);
				while (!Unsafe.AreSame<short>(ref ptr, ref right))
				{
					char c = (char)ptr;
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(state.Lookup.Contains128(c)))
					{
						return IndexOfAnyAsciiSearcher.IResultMapper<short, TResult>.ScalarResult(ref searchSpace, ref ptr);
					}
					ptr = Unsafe.Add<short>(ref ptr, 1);
				}
				return IndexOfAnyAsciiSearcher.IResultMapper<short, TResult>.NotFound;
			}
			if (false)
			{
			}
			Vector128<byte> lower = state.Bitmap._lower;
			if (searchSpaceLength > 2 * Vector128<short>.Count)
			{
				ref short right2 = ref Unsafe.Add<short>(ref searchSpace, searchSpaceLength - 2 * Vector128<short>.Count);
				Vector128<byte> vector;
				for (;;)
				{
					Vector128<short> source = Vector128.LoadUnsafe<short>(ref ptr);
					Vector128<short> source2 = Vector128.LoadUnsafe<short>(ref ptr, (UIntPtr)((IntPtr)Vector128<short>.Count));
					vector = IndexOfAnyAsciiSearcher.IndexOfAnyLookup<TNegator, TOptimizations>(source, source2, lower);
					if (vector != Vector128<byte>.Zero)
					{
						break;
					}
					ptr = Unsafe.Add<short>(ref ptr, 2 * Vector128<short>.Count);
					if (!Unsafe.IsAddressLessThan<short>(ref ptr, ref right2))
					{
						goto IL_DF;
					}
				}
				return IndexOfAnyAsciiSearcher.IResultMapper<short, TResult>.FirstIndex<TNegator>(ref searchSpace, ref ptr, vector);
			}
			IL_DF:
			ref short ptr2 = ref Unsafe.Add<short>(ref searchSpace, searchSpaceLength - Vector128<short>.Count);
			ref short ptr3 = ref Unsafe.IsAddressGreaterThan<short>(ref ptr, ref ptr2) ? ref ptr2 : ref ptr;
			Vector128<short> source3 = Vector128.LoadUnsafe<short>(ref ptr3);
			Vector128<short> source4 = Vector128.LoadUnsafe<short>(ref ptr2);
			Vector128<byte> vector2 = IndexOfAnyAsciiSearcher.IndexOfAnyLookup<TNegator, TOptimizations>(source3, source4, lower);
			if (vector2 != Vector128<byte>.Zero)
			{
				return IndexOfAnyAsciiSearcher.IResultMapper<short, TResult>.FirstIndexOverlapped<TNegator>(ref searchSpace, ref ptr3, ref ptr2, vector2);
			}
			return IndexOfAnyAsciiSearcher.IResultMapper<short, TResult>.NotFound;
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x000C5D38 File Offset: 0x000C3F38
		public unsafe static int LastIndexOfAny<TNegator, TOptimizations>(ref short searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AsciiState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator where TOptimizations : struct, IndexOfAnyAsciiSearcher.IOptimizations
		{
			if (searchSpaceLength < Vector128<ushort>.Count)
			{
				for (int i = searchSpaceLength - 1; i >= 0; i--)
				{
					char c = (char)(*Unsafe.Add<short>(ref searchSpace, i));
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(state.Lookup.Contains128(c)))
					{
						return i;
					}
				}
				return -1;
			}
			ref short ptr = ref Unsafe.Add<short>(ref searchSpace, searchSpaceLength);
			if (false)
			{
			}
			Vector128<byte> lower = state.Bitmap._lower;
			if (searchSpaceLength > 2 * Vector128<short>.Count)
			{
				ref short right = ref Unsafe.Add<short>(ref searchSpace, 2 * Vector128<short>.Count);
				Vector128<byte> vector;
				for (;;)
				{
					ptr = Unsafe.Subtract<short>(ref ptr, 2 * Vector128<short>.Count);
					Vector128<short> source = Vector128.LoadUnsafe<short>(ref ptr);
					Vector128<short> source2 = Vector128.LoadUnsafe<short>(ref ptr, (UIntPtr)((IntPtr)Vector128<short>.Count));
					vector = IndexOfAnyAsciiSearcher.IndexOfAnyLookup<TNegator, TOptimizations>(source, source2, lower);
					if (vector != Vector128<byte>.Zero)
					{
						break;
					}
					if (!Unsafe.IsAddressGreaterThan<short>(ref ptr, ref right))
					{
						goto IL_C0;
					}
				}
				return IndexOfAnyAsciiSearcher.ComputeLastIndex<short, TNegator>(ref searchSpace, ref ptr, vector);
			}
			IL_C0:
			ref short right2 = ref Unsafe.Add<short>(ref searchSpace, Vector128<short>.Count);
			ref short ptr2 = Unsafe.IsAddressGreaterThan<short>(ref ptr, ref right2) ? Unsafe.Subtract<short>(ref ptr, Vector128<short>.Count) : ref searchSpace;
			Vector128<short> source3 = Vector128.LoadUnsafe<short>(ref searchSpace);
			Vector128<short> source4 = Vector128.LoadUnsafe<short>(ref ptr2);
			Vector128<byte> vector2 = IndexOfAnyAsciiSearcher.IndexOfAnyLookup<TNegator, TOptimizations>(source3, source4, lower);
			if (vector2 != Vector128<byte>.Zero)
			{
				return IndexOfAnyAsciiSearcher.ComputeLastIndexOverlapped<short, TNegator>(ref searchSpace, ref ptr2, vector2);
			}
			return -1;
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x000C5E5F File Offset: 0x000C405F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<TNegator>(ref byte searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AsciiState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			return IndexOfAnyAsciiSearcher.IndexOfAnyCore<bool, TNegator, IndexOfAnyAsciiSearcher.ContainsAnyResultMapper<byte>>(ref searchSpace, searchSpaceLength, ref state);
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x000C5E69 File Offset: 0x000C4069
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<TNegator>(ref byte searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AsciiState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			return IndexOfAnyAsciiSearcher.IndexOfAnyCore<int, TNegator, IndexOfAnyAsciiSearcher.IndexOfAnyResultMapper<byte>>(ref searchSpace, searchSpaceLength, ref state);
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x000C5E74 File Offset: 0x000C4074
		private static TResult IndexOfAnyCore<TResult, TNegator, TResultMapper>(ref byte searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AsciiState state) where TResult : struct where TNegator : struct, IndexOfAnyAsciiSearcher.INegator where TResultMapper : struct, IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>
		{
			ref byte ptr = ref searchSpace;
			if (searchSpaceLength < 8)
			{
				ref byte right = ref Unsafe.Add<byte>(ref searchSpace, searchSpaceLength);
				while (!Unsafe.AreSame<byte>(ref ptr, ref right))
				{
					byte b = ptr;
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(state.Lookup.Contains(b)))
					{
						return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.ScalarResult(ref searchSpace, ref ptr);
					}
					ptr = Unsafe.Add<byte>(ref ptr, 1);
				}
				return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.NotFound;
			}
			if (false)
			{
			}
			Vector128<byte> lower = state.Bitmap._lower;
			if (searchSpaceLength > Vector128<byte>.Count)
			{
				ref byte right2 = ref Unsafe.Add<byte>(ref searchSpace, searchSpaceLength - Vector128<byte>.Count);
				Vector128<byte> vector;
				for (;;)
				{
					vector = IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(IndexOfAnyAsciiSearcher.IndexOfAnyLookupCore(Vector128.LoadUnsafe<byte>(ref ptr), lower));
					if (vector != Vector128<byte>.Zero)
					{
						break;
					}
					ptr = Unsafe.Add<byte>(ref ptr, Vector128<byte>.Count);
					if (!Unsafe.IsAddressLessThan<byte>(ref ptr, ref right2))
					{
						goto IL_CF;
					}
				}
				return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.FirstIndex<TNegator>(ref searchSpace, ref ptr, vector);
			}
			IL_CF:
			ref byte ptr2 = ref Unsafe.Add<byte>(ref searchSpace, searchSpaceLength - 8);
			ref byte ptr3 = ref Unsafe.IsAddressGreaterThan<byte>(ref ptr, ref ptr2) ? ref ptr2 : ref ptr;
			ulong e = Unsafe.ReadUnaligned<ulong>(ref ptr3);
			ulong e2 = Unsafe.ReadUnaligned<ulong>(ref ptr2);
			Vector128<byte> vector2 = IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(IndexOfAnyAsciiSearcher.IndexOfAnyLookupCore(Vector128.Create(e, e2).AsByte<ulong>(), lower));
			if (vector2 != Vector128<byte>.Zero)
			{
				return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.FirstIndexOverlapped<TNegator>(ref searchSpace, ref ptr3, ref ptr2, vector2);
			}
			return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.NotFound;
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x000C5FC8 File Offset: 0x000C41C8
		public unsafe static int LastIndexOfAny<TNegator>(ref byte searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AsciiState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			if (searchSpaceLength < 8)
			{
				for (int i = searchSpaceLength - 1; i >= 0; i--)
				{
					byte b = *Unsafe.Add<byte>(ref searchSpace, i);
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(state.Lookup.Contains(b)))
					{
						return i;
					}
				}
				return -1;
			}
			ref byte ptr = ref Unsafe.Add<byte>(ref searchSpace, searchSpaceLength);
			if (false)
			{
			}
			Vector128<byte> lower = state.Bitmap._lower;
			if (searchSpaceLength > Vector128<byte>.Count)
			{
				ref byte right = ref Unsafe.Add<byte>(ref searchSpace, Vector128<byte>.Count);
				Vector128<byte> vector;
				for (;;)
				{
					ptr = Unsafe.Subtract<byte>(ref ptr, Vector128<byte>.Count);
					vector = IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(IndexOfAnyAsciiSearcher.IndexOfAnyLookupCore(Vector128.LoadUnsafe<byte>(ref ptr), lower));
					if (vector != Vector128<byte>.Zero)
					{
						break;
					}
					if (!Unsafe.IsAddressGreaterThan<byte>(ref ptr, ref right))
					{
						goto IL_B0;
					}
				}
				return IndexOfAnyAsciiSearcher.ComputeLastIndex<byte, TNegator>(ref searchSpace, ref ptr, vector);
			}
			IL_B0:
			ref byte right2 = ref Unsafe.Add<byte>(ref searchSpace, 8);
			ref byte ptr2 = Unsafe.IsAddressGreaterThan<byte>(ref ptr, ref right2) ? Unsafe.Subtract<byte>(ref ptr, 8) : ref searchSpace;
			ulong e = Unsafe.ReadUnaligned<ulong>(ref searchSpace);
			ulong e2 = Unsafe.ReadUnaligned<ulong>(ref ptr2);
			Vector128<byte> vector2 = IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(IndexOfAnyAsciiSearcher.IndexOfAnyLookupCore(Vector128.Create(e, e2).AsByte<ulong>(), lower));
			if (vector2 != Vector128<byte>.Zero)
			{
				return IndexOfAnyAsciiSearcher.ComputeLastIndexOverlapped<byte, TNegator>(ref searchSpace, ref ptr2, vector2);
			}
			return -1;
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x000C60EC File Offset: 0x000C42EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<TNegator>(ref byte searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AnyByteState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			return IndexOfAnyAsciiSearcher.IndexOfAnyCore<bool, TNegator, IndexOfAnyAsciiSearcher.ContainsAnyResultMapper<byte>>(ref searchSpace, searchSpaceLength, ref state);
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x000C60F6 File Offset: 0x000C42F6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<TNegator>(ref byte searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AnyByteState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			return IndexOfAnyAsciiSearcher.IndexOfAnyCore<int, TNegator, IndexOfAnyAsciiSearcher.IndexOfAnyResultMapper<byte>>(ref searchSpace, searchSpaceLength, ref state);
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x000C6100 File Offset: 0x000C4300
		private static TResult IndexOfAnyCore<TResult, TNegator, TResultMapper>(ref byte searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AnyByteState state) where TResult : struct where TNegator : struct, IndexOfAnyAsciiSearcher.INegator where TResultMapper : struct, IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>
		{
			ref byte ptr = ref searchSpace;
			if (!IndexOfAnyAsciiSearcher.IsVectorizationSupported || searchSpaceLength < 8)
			{
				ref byte right = ref Unsafe.Add<byte>(ref searchSpace, searchSpaceLength);
				while (!Unsafe.AreSame<byte>(ref ptr, ref right))
				{
					byte b = ptr;
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(state.Lookup.Contains(b)))
					{
						return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.ScalarResult(ref searchSpace, ref ptr);
					}
					ptr = Unsafe.Add<byte>(ref ptr, 1);
				}
				return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.NotFound;
			}
			if (false)
			{
			}
			Vector128<byte> lower = state.Bitmap0._lower;
			Vector128<byte> lower2 = state.Bitmap1._lower;
			if (searchSpaceLength > Vector128<byte>.Count)
			{
				ref byte right2 = ref Unsafe.Add<byte>(ref searchSpace, searchSpaceLength - Vector128<byte>.Count);
				Vector128<byte> vector;
				for (;;)
				{
					vector = IndexOfAnyAsciiSearcher.IndexOfAnyLookup<TNegator>(Vector128.LoadUnsafe<byte>(ref ptr), lower, lower2);
					if (vector != Vector128<byte>.Zero)
					{
						break;
					}
					ptr = Unsafe.Add<byte>(ref ptr, Vector128<byte>.Count);
					if (!Unsafe.IsAddressLessThan<byte>(ref ptr, ref right2))
					{
						goto IL_DA;
					}
				}
				return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.FirstIndex<TNegator>(ref searchSpace, ref ptr, vector);
			}
			IL_DA:
			ref byte ptr2 = ref Unsafe.Add<byte>(ref searchSpace, searchSpaceLength - 8);
			ref byte ptr3 = ref Unsafe.IsAddressGreaterThan<byte>(ref ptr, ref ptr2) ? ref ptr2 : ref ptr;
			ulong e = Unsafe.ReadUnaligned<ulong>(ref ptr3);
			ulong e2 = Unsafe.ReadUnaligned<ulong>(ref ptr2);
			Vector128<byte> vector2 = IndexOfAnyAsciiSearcher.IndexOfAnyLookup<TNegator>(Vector128.Create(e, e2).AsByte<ulong>(), lower, lower2);
			if (vector2 != Vector128<byte>.Zero)
			{
				return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.FirstIndexOverlapped<TNegator>(ref searchSpace, ref ptr3, ref ptr2, vector2);
			}
			return IndexOfAnyAsciiSearcher.IResultMapper<byte, TResult>.NotFound;
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x000C6254 File Offset: 0x000C4454
		public unsafe static int LastIndexOfAny<TNegator>(ref byte searchSpace, int searchSpaceLength, ref IndexOfAnyAsciiSearcher.AnyByteState state) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			if (!IndexOfAnyAsciiSearcher.IsVectorizationSupported || searchSpaceLength < 8)
			{
				for (int i = searchSpaceLength - 1; i >= 0; i--)
				{
					byte b = *Unsafe.Add<byte>(ref searchSpace, i);
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(state.Lookup.Contains(b)))
					{
						return i;
					}
				}
				return -1;
			}
			ref byte ptr = ref Unsafe.Add<byte>(ref searchSpace, searchSpaceLength);
			if (false)
			{
			}
			Vector128<byte> lower = state.Bitmap0._lower;
			Vector128<byte> lower2 = state.Bitmap1._lower;
			if (searchSpaceLength > Vector128<byte>.Count)
			{
				ref byte right = ref Unsafe.Add<byte>(ref searchSpace, Vector128<byte>.Count);
				Vector128<byte> vector;
				for (;;)
				{
					ptr = Unsafe.Subtract<byte>(ref ptr, Vector128<byte>.Count);
					vector = IndexOfAnyAsciiSearcher.IndexOfAnyLookup<TNegator>(Vector128.LoadUnsafe<byte>(ref ptr), lower, lower2);
					if (vector != Vector128<byte>.Zero)
					{
						break;
					}
					if (!Unsafe.IsAddressGreaterThan<byte>(ref ptr, ref right))
					{
						goto IL_BB;
					}
				}
				return IndexOfAnyAsciiSearcher.ComputeLastIndex<byte, TNegator>(ref searchSpace, ref ptr, vector);
			}
			IL_BB:
			ref byte right2 = ref Unsafe.Add<byte>(ref searchSpace, 8);
			ref byte ptr2 = Unsafe.IsAddressGreaterThan<byte>(ref ptr, ref right2) ? Unsafe.Subtract<byte>(ref ptr, 8) : ref searchSpace;
			ulong e = Unsafe.ReadUnaligned<ulong>(ref searchSpace);
			ulong e2 = Unsafe.ReadUnaligned<ulong>(ref ptr2);
			Vector128<byte> vector2 = IndexOfAnyAsciiSearcher.IndexOfAnyLookup<TNegator>(Vector128.Create(e, e2).AsByte<ulong>(), lower, lower2);
			if (vector2 != Vector128<byte>.Zero)
			{
				return IndexOfAnyAsciiSearcher.ComputeLastIndexOverlapped<byte, TNegator>(ref searchSpace, ref ptr2, vector2);
			}
			return -1;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x000C6379 File Offset: 0x000C4579
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> IndexOfAnyLookup<TNegator, TOptimizations>(Vector128<short> source0, Vector128<short> source1, Vector128<byte> bitmapLookup) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator where TOptimizations : struct, IndexOfAnyAsciiSearcher.IOptimizations
		{
			return IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(IndexOfAnyAsciiSearcher.IndexOfAnyLookupCore(IndexOfAnyAsciiSearcher.IOptimizations.PackSources(source0.AsUInt16<short>(), source1.AsUInt16<short>()), bitmapLookup));
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x000C63A4 File Offset: 0x000C45A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> IndexOfAnyLookupCore(Vector128<byte> source, Vector128<byte> bitmapLookup)
		{
			Vector128<byte> indices = Ssse3.IsSupported ? source : (source & Vector128.Create(15));
			Vector128<byte> indices2 = Vector128<byte>.op_UnsignedRightShift(source, 4);
			Vector128<byte> left = Vector128.ShuffleUnsafe(bitmapLookup, indices);
			Vector128<byte> right = Vector128.ShuffleUnsafe(Vector128.Create(9241421688590303745UL, 0UL).AsByte<ulong>(), indices2);
			return left & right;
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x000C6400 File Offset: 0x000C4600
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> IndexOfAnyLookup<TNegator>(Vector128<byte> source, Vector128<byte> bitmapLookup0, Vector128<byte> bitmapLookup1) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			Vector128<byte> indices = source & Vector128.Create(15);
			Vector128<byte> vector = Vector128<byte>.op_UnsignedRightShift(source, 4);
			Vector128<byte> right = Vector128.ShuffleUnsafe(bitmapLookup0, indices);
			Vector128<byte> left = Vector128.ShuffleUnsafe(bitmapLookup1, indices);
			Vector128<byte> right2 = Vector128.ShuffleUnsafe(Vector128.Create(9241421688590303745UL).AsByte<ulong>(), vector);
			return IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(Vector128.Equals<byte>(Vector128.ConditionalSelect<byte>(Vector128.GreaterThan<sbyte>(vector.AsSByte<byte>(), Vector128.Create(7)).AsByte<sbyte>(), left, right) & right2, right2));
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x000C6484 File Offset: 0x000C4684
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ComputeLastIndex<T, TNegator>(ref T searchSpace, ref T current, Vector128<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			uint value = IndexOfAnyAsciiSearcher.INegator.ExtractMask(result) & 65535U;
			return 31 - BitOperations.LeadingZeroCount(value) + (int)(Unsafe.ByteOffset<T>(ref searchSpace, ref current) / (IntPtr)sizeof(T));
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x000C64C0 File Offset: 0x000C46C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ComputeLastIndexOverlapped<T, TNegator>(ref T searchSpace, ref T secondVector, Vector128<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			uint value = IndexOfAnyAsciiSearcher.INegator.ExtractMask(result) & 65535U;
			int num = 31 - BitOperations.LeadingZeroCount(value);
			if (num < Vector128<short>.Count)
			{
				return num;
			}
			return num - Vector128<short>.Count + (int)(Unsafe.ByteOffset<T>(ref searchSpace, ref secondVector) / (IntPtr)sizeof(T));
		}

		// Token: 0x02000363 RID: 867
		public struct AsciiState
		{
			// Token: 0x06003B74 RID: 15220 RVA: 0x000C650C File Offset: 0x000C470C
			public AsciiState(Vector128<byte> bitmap, BitVector256 lookup)
			{
				this.Bitmap = Vector256.Create<byte>(bitmap);
				this.Lookup = lookup;
			}

			// Token: 0x06003B75 RID: 15221 RVA: 0x000C6521 File Offset: 0x000C4721
			public readonly IndexOfAnyAsciiSearcher.AsciiState CreateInverse()
			{
				return new IndexOfAnyAsciiSearcher.AsciiState(~this.Bitmap._lower, this.Lookup.CreateInverse());
			}

			// Token: 0x04000C87 RID: 3207
			public Vector256<byte> Bitmap;

			// Token: 0x04000C88 RID: 3208
			public BitVector256 Lookup;
		}

		// Token: 0x02000364 RID: 868
		public struct AnyByteState
		{
			// Token: 0x06003B76 RID: 15222 RVA: 0x000C6543 File Offset: 0x000C4743
			public AnyByteState(Vector128<byte> bitmap0, Vector128<byte> bitmap1, BitVector256 lookup)
			{
				this.Bitmap0 = Vector256.Create<byte>(bitmap0);
				this.Bitmap1 = Vector256.Create<byte>(bitmap1);
				this.Lookup = lookup;
			}

			// Token: 0x04000C89 RID: 3209
			public Vector256<byte> Bitmap0;

			// Token: 0x04000C8A RID: 3210
			public Vector256<byte> Bitmap1;

			// Token: 0x04000C8B RID: 3211
			public BitVector256 Lookup;
		}

		// Token: 0x02000365 RID: 869
		internal interface INegator
		{
			// Token: 0x06003B77 RID: 15223
			public abstract static bool NegateIfNeeded(bool result);

			// Token: 0x06003B78 RID: 15224
			public abstract static Vector128<byte> NegateIfNeeded(Vector128<byte> result);

			// Token: 0x06003B79 RID: 15225
			public abstract static Vector256<byte> NegateIfNeeded(Vector256<byte> result);

			// Token: 0x06003B7A RID: 15226
			public abstract static uint ExtractMask(Vector128<byte> result);

			// Token: 0x06003B7B RID: 15227
			public abstract static uint ExtractMask(Vector256<byte> result);
		}

		// Token: 0x02000366 RID: 870
		internal readonly struct DontNegate : IndexOfAnyAsciiSearcher.INegator
		{
			// Token: 0x06003B7C RID: 15228 RVA: 0x00007B62 File Offset: 0x00005D62
			public static bool NegateIfNeeded(bool result)
			{
				return result;
			}

			// Token: 0x06003B7D RID: 15229 RVA: 0x00007B62 File Offset: 0x00005D62
			public static Vector128<byte> NegateIfNeeded(Vector128<byte> result)
			{
				return result;
			}

			// Token: 0x06003B7E RID: 15230 RVA: 0x00007B62 File Offset: 0x00005D62
			public static Vector256<byte> NegateIfNeeded(Vector256<byte> result)
			{
				return result;
			}

			// Token: 0x06003B7F RID: 15231 RVA: 0x000C6564 File Offset: 0x000C4764
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static uint ExtractMask(Vector128<byte> result)
			{
				return ~Vector128.Equals<byte>(result, Vector128<byte>.Zero).ExtractMostSignificantBits<byte>();
			}

			// Token: 0x06003B80 RID: 15232 RVA: 0x000C6577 File Offset: 0x000C4777
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static uint ExtractMask(Vector256<byte> result)
			{
				return ~Vector256.Equals<byte>(result, Vector256<byte>.Zero).ExtractMostSignificantBits<byte>();
			}
		}

		// Token: 0x02000367 RID: 871
		internal readonly struct Negate : IndexOfAnyAsciiSearcher.INegator
		{
			// Token: 0x06003B81 RID: 15233 RVA: 0x000202CE File Offset: 0x0001E4CE
			public static bool NegateIfNeeded(bool result)
			{
				return !result;
			}

			// Token: 0x06003B82 RID: 15234 RVA: 0x000C658A File Offset: 0x000C478A
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<byte> NegateIfNeeded(Vector128<byte> result)
			{
				return Vector128.Equals<byte>(result, Vector128<byte>.Zero);
			}

			// Token: 0x06003B83 RID: 15235 RVA: 0x000C6597 File Offset: 0x000C4797
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<byte> NegateIfNeeded(Vector256<byte> result)
			{
				return Vector256.Equals<byte>(result, Vector256<byte>.Zero);
			}

			// Token: 0x06003B84 RID: 15236 RVA: 0x000C65A4 File Offset: 0x000C47A4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static uint ExtractMask(Vector128<byte> result)
			{
				return result.ExtractMostSignificantBits<byte>();
			}

			// Token: 0x06003B85 RID: 15237 RVA: 0x000C65AC File Offset: 0x000C47AC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static uint ExtractMask(Vector256<byte> result)
			{
				return result.ExtractMostSignificantBits<byte>();
			}
		}

		// Token: 0x02000368 RID: 872
		internal interface IOptimizations
		{
			// Token: 0x06003B86 RID: 15238
			public abstract static Vector128<byte> PackSources(Vector128<ushort> lower, Vector128<ushort> upper);

			// Token: 0x06003B87 RID: 15239
			public abstract static Vector256<byte> PackSources(Vector256<ushort> lower, Vector256<ushort> upper);
		}

		// Token: 0x02000369 RID: 873
		internal readonly struct Ssse3AndWasmHandleZeroInNeedle : IndexOfAnyAsciiSearcher.IOptimizations
		{
			// Token: 0x06003B88 RID: 15240 RVA: 0x000C65B4 File Offset: 0x000C47B4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<byte> PackSources(Vector128<ushort> lower, Vector128<ushort> upper)
			{
				Vector128<short> vector = Vector128.Min<ushort>(lower, Vector128.Create(255)).AsInt16<ushort>();
				Vector128<short> vector2 = Vector128.Min<ushort>(upper, Vector128.Create(255)).AsInt16<ushort>();
				if (!Sse2.IsSupported)
				{
					return PackedSimd.ConvertNarrowingSaturateUnsigned(vector, vector2);
				}
				return Sse2.PackUnsignedSaturate(vector, vector2);
			}

			// Token: 0x06003B89 RID: 15241 RVA: 0x000C6603 File Offset: 0x000C4803
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<byte> PackSources(Vector256<ushort> lower, Vector256<ushort> upper)
			{
				return Avx2.PackUnsignedSaturate(Vector256.Min<ushort>(lower, Vector256.Create(255)).AsInt16<ushort>(), Vector256.Min<ushort>(upper, Vector256.Create(255)).AsInt16<ushort>());
			}
		}

		// Token: 0x0200036A RID: 874
		internal readonly struct Default : IndexOfAnyAsciiSearcher.IOptimizations
		{
			// Token: 0x06003B8A RID: 15242 RVA: 0x000C6634 File Offset: 0x000C4834
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<byte> PackSources(Vector128<ushort> lower, Vector128<ushort> upper)
			{
				if (!Sse2.IsSupported)
				{
					return PackedSimd.ConvertNarrowingSaturateUnsigned(lower.AsInt16<ushort>(), upper.AsInt16<ushort>());
				}
				return Sse2.PackUnsignedSaturate(lower.AsInt16<ushort>(), upper.AsInt16<ushort>());
			}

			// Token: 0x06003B8B RID: 15243 RVA: 0x000C6662 File Offset: 0x000C4862
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<byte> PackSources(Vector256<ushort> lower, Vector256<ushort> upper)
			{
				return Avx2.PackUnsignedSaturate(lower.AsInt16<ushort>(), upper.AsInt16<ushort>());
			}
		}

		// Token: 0x0200036B RID: 875
		private interface IResultMapper<T, TResult> where TResult : struct
		{
			// Token: 0x17000B1D RID: 2845
			// (get) Token: 0x06003B8C RID: 15244
			TResult NotFound { get; }

			// Token: 0x06003B8D RID: 15245
			public abstract static TResult ScalarResult(ref T searchSpace, ref T current);

			// Token: 0x06003B8E RID: 15246
			public abstract static TResult FirstIndex<TNegator>(ref T searchSpace, ref T current, Vector128<byte> result);

			// Token: 0x06003B8F RID: 15247
			public abstract static TResult FirstIndex<TNegator>(ref T searchSpace, ref T current, Vector256<byte> result);

			// Token: 0x06003B90 RID: 15248
			public abstract static TResult FirstIndexOverlapped<TNegator>(ref T searchSpace, ref T current0, ref T current1, Vector128<byte> result);

			// Token: 0x06003B91 RID: 15249
			public abstract static TResult FirstIndexOverlapped<TNegator>(ref T searchSpace, ref T current0, ref T current1, Vector256<byte> result);
		}

		// Token: 0x0200036C RID: 876
		private readonly struct ContainsAnyResultMapper<T> : IndexOfAnyAsciiSearcher.IResultMapper<T, bool>
		{
			// Token: 0x17000B1E RID: 2846
			// (get) Token: 0x06003B92 RID: 15250 RVA: 0x00007B65 File Offset: 0x00005D65
			public static bool NotFound
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06003B93 RID: 15251 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool ScalarResult(ref T searchSpace, ref T current)
			{
				return true;
			}

			// Token: 0x06003B94 RID: 15252 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool FirstIndex<TNegator>(ref T searchSpace, ref T current, Vector128<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
			{
				return true;
			}

			// Token: 0x06003B95 RID: 15253 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool FirstIndex<TNegator>(ref T searchSpace, ref T current, Vector256<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
			{
				return true;
			}

			// Token: 0x06003B96 RID: 15254 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool FirstIndexOverlapped<TNegator>(ref T searchSpace, ref T current0, ref T current1, Vector128<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
			{
				return true;
			}

			// Token: 0x06003B97 RID: 15255 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool FirstIndexOverlapped<TNegator>(ref T searchSpace, ref T current0, ref T current1, Vector256<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
			{
				return true;
			}
		}

		// Token: 0x0200036D RID: 877
		private readonly struct IndexOfAnyResultMapper<T> : IndexOfAnyAsciiSearcher.IResultMapper<T, int>
		{
			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x06003B98 RID: 15256 RVA: 0x0003F19A File Offset: 0x0003D39A
			public static int NotFound
			{
				get
				{
					return -1;
				}
			}

			// Token: 0x06003B99 RID: 15257 RVA: 0x000C6675 File Offset: 0x000C4875
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int ScalarResult(ref T searchSpace, ref T current)
			{
				return (int)(Unsafe.ByteOffset<T>(ref searchSpace, ref current) / (IntPtr)sizeof(T));
			}

			// Token: 0x06003B9A RID: 15258 RVA: 0x000C6687 File Offset: 0x000C4887
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int FirstIndex<TNegator>(ref T searchSpace, ref T current, Vector128<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
			{
				return BitOperations.TrailingZeroCount(IndexOfAnyAsciiSearcher.INegator.ExtractMask(result)) + (int)(Unsafe.ByteOffset<T>(ref searchSpace, ref current) / (IntPtr)sizeof(T));
			}

			// Token: 0x06003B9B RID: 15259 RVA: 0x000C66AC File Offset: 0x000C48AC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int FirstIndex<TNegator>(ref T searchSpace, ref T current, Vector256<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
			{
				if (typeof(T) == typeof(short))
				{
					result = PackedSpanHelpers.FixUpPackedVector256Result(result);
				}
				return BitOperations.TrailingZeroCount(IndexOfAnyAsciiSearcher.INegator.ExtractMask(result)) + (int)(Unsafe.ByteOffset<T>(ref searchSpace, ref current) / (IntPtr)sizeof(T));
			}

			// Token: 0x06003B9C RID: 15260 RVA: 0x000C6700 File Offset: 0x000C4900
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int FirstIndexOverlapped<TNegator>(ref T searchSpace, ref T current0, ref T current1, Vector128<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
			{
				int num = BitOperations.TrailingZeroCount(IndexOfAnyAsciiSearcher.INegator.ExtractMask(result));
				if (num >= Vector128<short>.Count)
				{
					current0 = ref current1;
					num -= Vector128<short>.Count;
				}
				return num + (int)(Unsafe.ByteOffset<T>(ref searchSpace, ref current0) / (IntPtr)sizeof(T));
			}

			// Token: 0x06003B9D RID: 15261 RVA: 0x000C6744 File Offset: 0x000C4944
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int FirstIndexOverlapped<TNegator>(ref T searchSpace, ref T current0, ref T current1, Vector256<byte> result) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
			{
				if (typeof(T) == typeof(short))
				{
					result = PackedSpanHelpers.FixUpPackedVector256Result(result);
				}
				int num = BitOperations.TrailingZeroCount(IndexOfAnyAsciiSearcher.INegator.ExtractMask(result));
				if (num >= Vector256<short>.Count)
				{
					current0 = ref current1;
					num -= Vector256<short>.Count;
				}
				return num + (int)(Unsafe.ByteOffset<T>(ref searchSpace, ref current0) / (IntPtr)sizeof(T));
			}
		}
	}
}
