using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace System.Buffers
{
	// Token: 0x0200037A RID: 890
	internal readonly struct ProbabilisticMap
	{
		// Token: 0x06003BE4 RID: 15332 RVA: 0x000C7330 File Offset: 0x000C5530
		public unsafe ProbabilisticMap(ReadOnlySpan<char> values)
		{
			this._e0 = 0U;
			this._e1 = 0U;
			this._e2 = 0U;
			this._e3 = 0U;
			this._e4 = 0U;
			this._e5 = 0U;
			this._e6 = 0U;
			this._e7 = 0U;
			bool flag = false;
			ref uint charMap = ref this._e0;
			for (int i = 0; i < values.Length; i++)
			{
				int num = (int)(*values[i]);
				ProbabilisticMap.SetCharBit(ref charMap, (byte)num);
				num >>= 8;
				if (num == 0)
				{
					flag = true;
				}
				else
				{
					ProbabilisticMap.SetCharBit(ref charMap, (byte)num);
				}
			}
			if (flag)
			{
				ProbabilisticMap.SetCharBit(ref charMap, 0);
			}
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x000C73C0 File Offset: 0x000C55C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void SetCharBit(ref uint charMap, byte value)
		{
			if (Sse41.IsSupported || false)
			{
				ref byte ptr = ref Unsafe.Add<byte>(Unsafe.As<uint, byte>(ref charMap), (UIntPtr)(value & 31));
				ptr |= (byte)(1 << (value >> 5));
				return;
			}
			*Unsafe.Add<uint>(ref charMap, (UIntPtr)(value & 7)) |= 1U << (value >> 3);
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x000C740C File Offset: 0x000C560C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool IsCharBitSet(ref uint charMap, byte value)
		{
			if (!Sse41.IsSupported)
			{
				return (*Unsafe.Add<uint>(ref charMap, (UIntPtr)(value & 7)) & 1U << (value >> 3)) > 0U;
			}
			return ((int)(*Unsafe.Add<byte>(Unsafe.As<uint, byte>(ref charMap), (UIntPtr)(value & 31))) & 1 << (value >> 5)) != 0;
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x000C744C File Offset: 0x000C564C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool Contains(ref uint charMap, ReadOnlySpan<char> values, int ch)
		{
			return ProbabilisticMap.IsCharBitSet(ref charMap, (byte)ch) && ProbabilisticMap.IsCharBitSet(ref charMap, (byte)(ch >> 8)) && ProbabilisticMap.Contains(values, (char)ch);
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x000C746E File Offset: 0x000C566E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool Contains(ReadOnlySpan<char> values, char ch)
		{
			return SpanHelpers.NonPackedContainsValueType<short>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(values)), (short)ch, values.Length);
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x000C748C File Offset: 0x000C568C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> ContainsMask16Chars(Vector128<byte> charMapLower, Vector128<byte> charMapUpper, ref char searchSpace)
		{
			Vector128<ushort> vector = Vector128.LoadUnsafe(ref searchSpace);
			Vector128<ushort> vector2 = Vector128.LoadUnsafe(ref searchSpace, (UIntPtr)((IntPtr)Vector128<ushort>.Count));
			Vector128<byte> values = Sse2.IsSupported ? Sse2.PackUnsignedSaturate((vector & Vector128.Create(255)).AsInt16<ushort>(), (vector2 & Vector128.Create(255)).AsInt16<ushort>()) : AdvSimd.Arm64.UnzipEven(vector.AsByte<ushort>(), vector2.AsByte<ushort>());
			Vector128<byte> values2 = Sse2.IsSupported ? Sse2.PackUnsignedSaturate(Vector128<ushort>.op_UnsignedRightShift(vector, 8).AsInt16<ushort>(), Vector128<ushort>.op_UnsignedRightShift(vector2, 8).AsInt16<ushort>()) : AdvSimd.Arm64.UnzipOdd(vector.AsByte<ushort>(), vector2.AsByte<ushort>());
			Vector128<byte> left = ProbabilisticMap.IsCharBitNotSet(charMapLower, charMapUpper, values);
			Vector128<byte> right = ProbabilisticMap.IsCharBitNotSet(charMapLower, charMapUpper, values2);
			return ~(left | right);
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x000C7550 File Offset: 0x000C5750
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> IsCharBitNotSet(Vector128<byte> charMapLower, Vector128<byte> charMapUpper, Vector128<byte> values)
		{
			Vector128<byte> indices = Vector128<byte>.op_UnsignedRightShift(values, 5);
			Vector128<byte> right = Vector128.ShuffleUnsafe(Vector128.Create(9241421688590303745UL).AsByte<ulong>(), indices);
			Vector128<byte> vector = values & Vector128.Create(31);
			if (false)
			{
			}
			Vector128<byte> right2 = Vector128.ShuffleUnsafe(charMapLower, vector);
			Vector128<byte> left = Vector128.ShuffleUnsafe(charMapUpper, vector - Vector128.Create(16));
			Vector128<byte> left2 = Vector128.ConditionalSelect<byte>(Vector128.GreaterThan<byte>(vector, Vector128.Create(15)), left, right2);
			return Vector128.Equals<byte>(left2 & right, Vector128<byte>.Zero);
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x000C75D6 File Offset: 0x000C57D6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ShouldUseSimpleLoop(int searchSpaceLength, int valuesLength)
		{
			return searchSpaceLength < Vector128<short>.Count || (searchSpaceLength < 20 && searchSpaceLength < valuesLength >> 1);
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x000C75F0 File Offset: 0x000C57F0
		public static int IndexOfAny(ref char searchSpace, int searchSpaceLength, ref char values, int valuesLength)
		{
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>(ref values, valuesLength);
			if (ProbabilisticMap.ShouldUseSimpleLoop(searchSpaceLength, valuesLength))
			{
				return ProbabilisticMap.IndexOfAnySimpleLoop<IndexOfAnyAsciiSearcher.DontNegate>(ref searchSpace, searchSpaceLength, readOnlySpan);
			}
			int result;
			if (IndexOfAnyAsciiSearcher.TryIndexOfAny(ref searchSpace, searchSpaceLength, readOnlySpan, out result))
			{
				return result;
			}
			return ProbabilisticMap.ProbabilisticIndexOfAny(ref searchSpace, searchSpaceLength, ref values, valuesLength);
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x000C7630 File Offset: 0x000C5830
		public static int IndexOfAnyExcept(ref char searchSpace, int searchSpaceLength, ref char values, int valuesLength)
		{
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>(ref values, valuesLength);
			int result;
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && !ProbabilisticMap.ShouldUseSimpleLoop(searchSpaceLength, valuesLength) && IndexOfAnyAsciiSearcher.TryIndexOfAnyExcept(ref searchSpace, searchSpaceLength, readOnlySpan, out result))
			{
				return result;
			}
			return ProbabilisticMap.IndexOfAnySimpleLoop<IndexOfAnyAsciiSearcher.Negate>(ref searchSpace, searchSpaceLength, readOnlySpan);
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x000C766C File Offset: 0x000C586C
		public static int LastIndexOfAny(ref char searchSpace, int searchSpaceLength, ref char values, int valuesLength)
		{
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>(ref values, valuesLength);
			if (ProbabilisticMap.ShouldUseSimpleLoop(searchSpaceLength, valuesLength))
			{
				return ProbabilisticMap.LastIndexOfAnySimpleLoop<IndexOfAnyAsciiSearcher.DontNegate>(ref searchSpace, searchSpaceLength, readOnlySpan);
			}
			int result;
			if (IndexOfAnyAsciiSearcher.TryLastIndexOfAny(ref searchSpace, searchSpaceLength, readOnlySpan, out result))
			{
				return result;
			}
			return ProbabilisticMap.ProbabilisticLastIndexOfAny(ref searchSpace, searchSpaceLength, ref values, valuesLength);
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x000C76AC File Offset: 0x000C58AC
		public static int LastIndexOfAnyExcept(ref char searchSpace, int searchSpaceLength, ref char values, int valuesLength)
		{
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>(ref values, valuesLength);
			int result;
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && !ProbabilisticMap.ShouldUseSimpleLoop(searchSpaceLength, valuesLength) && IndexOfAnyAsciiSearcher.TryLastIndexOfAnyExcept(ref searchSpace, searchSpaceLength, readOnlySpan, out result))
			{
				return result;
			}
			return ProbabilisticMap.LastIndexOfAnySimpleLoop<IndexOfAnyAsciiSearcher.Negate>(ref searchSpace, searchSpaceLength, readOnlySpan);
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x000C76E8 File Offset: 0x000C58E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static int ProbabilisticIndexOfAny(ref char searchSpace, int searchSpaceLength, ref char values, int valuesLength)
		{
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>(ref values, valuesLength);
			ProbabilisticMapState probabilisticMapState = new ProbabilisticMapState(&readOnlySpan);
			return ProbabilisticMap.IndexOfAny<SearchValues.FalseConst>(ref searchSpace, searchSpaceLength, ref probabilisticMapState);
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x000C7710 File Offset: 0x000C5910
		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static int ProbabilisticLastIndexOfAny(ref char searchSpace, int searchSpaceLength, ref char values, int valuesLength)
		{
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>(ref values, valuesLength);
			ProbabilisticMapState probabilisticMapState = new ProbabilisticMapState(&readOnlySpan);
			return ProbabilisticMap.LastIndexOfAny<SearchValues.FalseConst>(ref searchSpace, searchSpaceLength, ref probabilisticMapState);
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x000C7738 File Offset: 0x000C5938
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAny<TUseFastContains>(ref char searchSpace, int searchSpaceLength, ref ProbabilisticMapState state) where TUseFastContains : struct, SearchValues.IRuntimeConst
		{
			if ((Sse41.IsSupported || false) && searchSpaceLength >= 16)
			{
				if (false)
				{
				}
				return ProbabilisticMap.IndexOfAnyVectorized<TUseFastContains>(ref searchSpace, searchSpaceLength, ref state);
			}
			return ProbabilisticMapState.IndexOfAnySimpleLoop<TUseFastContains, IndexOfAnyAsciiSearcher.DontNegate>(ref searchSpace, searchSpaceLength, ref state);
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x000C775D File Offset: 0x000C595D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAny<TUseFastContains>(ref char searchSpace, int searchSpaceLength, ref ProbabilisticMapState state) where TUseFastContains : struct, SearchValues.IRuntimeConst
		{
			if ((Sse41.IsSupported || false) && searchSpaceLength >= 16)
			{
				if (false)
				{
				}
				return ProbabilisticMap.LastIndexOfAnyVectorized<TUseFastContains>(ref searchSpace, searchSpaceLength, ref state);
			}
			return ProbabilisticMapState.LastIndexOfAnySimpleLoop<TUseFastContains, IndexOfAnyAsciiSearcher.DontNegate>(ref searchSpace, searchSpaceLength, ref state);
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x000C7784 File Offset: 0x000C5984
		private static int IndexOfAnyVectorized<TUseFastContains>(ref char searchSpace, int searchSpaceLength, ref ProbabilisticMapState state) where TUseFastContains : struct, SearchValues.IRuntimeConst
		{
			ref char ptr = ref Unsafe.Add<char>(ref searchSpace, searchSpaceLength);
			ref char ptr2 = ref searchSpace;
			Vector128<byte> charMapLower = Vector128.LoadUnsafe<byte>(Unsafe.As<ProbabilisticMap, byte>(ref state.Map));
			Vector128<byte> charMapUpper = Vector128.LoadUnsafe<byte>(Unsafe.As<ProbabilisticMap, byte>(ref state.Map), (UIntPtr)((IntPtr)Vector128<byte>.Count));
			if (false)
			{
			}
			ref char ptr3 = ref Unsafe.Subtract<char>(ref ptr, 16);
			int num;
			for (;;)
			{
				Vector128<byte> vector = ProbabilisticMap.ContainsMask16Chars(charMapLower, charMapUpper, ref ptr2);
				if (vector != Vector128<byte>.Zero && ProbabilisticMap.TryFindMatch<TUseFastContains>(ref ptr2, vector.ExtractMostSignificantBits<byte>(), ref state, out num))
				{
					break;
				}
				ptr2 = Unsafe.Add<char>(ref ptr2, 16);
				if (Unsafe.IsAddressGreaterThan<char>(ref ptr2, ref ptr3))
				{
					if (Unsafe.AreSame<char>(ref ptr2, ref ptr))
					{
						return -1;
					}
					ptr2 = ref ptr3;
				}
			}
			return ProbabilisticMap.MatchOffset(ref searchSpace, ref ptr2) + num;
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x000C782C File Offset: 0x000C5A2C
		private static int LastIndexOfAnyVectorized<TUseFastContains>(ref char searchSpace, int searchSpaceLength, ref ProbabilisticMapState state) where TUseFastContains : struct, SearchValues.IRuntimeConst
		{
			ref char ptr = ref Unsafe.Add<char>(ref searchSpace, searchSpaceLength);
			Vector128<byte> charMapLower = Vector128.LoadUnsafe<byte>(Unsafe.As<ProbabilisticMap, byte>(ref state.Map));
			Vector128<byte> charMapUpper = Vector128.LoadUnsafe<byte>(Unsafe.As<ProbabilisticMap, byte>(ref state.Map), (UIntPtr)((IntPtr)Vector128<byte>.Count));
			if (false)
			{
			}
			ref char ptr2 = ref Unsafe.Add<char>(ref searchSpace, 16);
			int num;
			for (;;)
			{
				ptr = Unsafe.Subtract<char>(ref ptr, 16);
				Vector128<byte> vector = ProbabilisticMap.ContainsMask16Chars(charMapLower, charMapUpper, ref ptr);
				if (vector != Vector128<byte>.Zero && ProbabilisticMap.TryFindLastMatch<TUseFastContains>(ref ptr, vector.ExtractMostSignificantBits<byte>(), ref state, out num))
				{
					break;
				}
				if (!Unsafe.IsAddressGreaterThan<char>(ref ptr, ref ptr2))
				{
					if (Unsafe.AreSame<char>(ref ptr, ref searchSpace))
					{
						return -1;
					}
					ptr = ref ptr2;
				}
			}
			return ProbabilisticMap.MatchOffset(ref searchSpace, ref ptr) + num;
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x000C78CD File Offset: 0x000C5ACD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int MatchOffset(ref char searchSpace, ref char cur)
		{
			return (int)(Unsafe.ByteOffset<char>(ref searchSpace, ref cur) / (IntPtr)2);
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x000C78DA File Offset: 0x000C5ADA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryFindMatch<TUseFastContains>(ref char cur, uint mask, ref ProbabilisticMapState state, out int index) where TUseFastContains : struct, SearchValues.IRuntimeConst
		{
			for (;;)
			{
				index = BitOperations.TrailingZeroCount(mask);
				if (state.ConfirmProbabilisticMatch<TUseFastContains>(*Unsafe.Add<char>(ref cur, index)))
				{
					break;
				}
				mask = BitOperations.ResetLowestSetBit(mask);
				if (mask == 0U)
				{
					goto Block_1;
				}
			}
			return true;
			Block_1:
			index = 0;
			return false;
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x000C7906 File Offset: 0x000C5B06
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryFindLastMatch<TUseFastContains>(ref char cur, uint mask, ref ProbabilisticMapState state, out int index) where TUseFastContains : struct, SearchValues.IRuntimeConst
		{
			for (;;)
			{
				index = 31 - BitOperations.LeadingZeroCount(mask);
				if (state.ConfirmProbabilisticMatch<TUseFastContains>(*Unsafe.Add<char>(ref cur, index)))
				{
					break;
				}
				mask = BitOperations.FlipBit(mask, index);
				if (mask == 0U)
				{
					goto Block_1;
				}
			}
			return true;
			Block_1:
			index = 0;
			return false;
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x000C7938 File Offset: 0x000C5B38
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnySimpleLoop<TNegator>(ref char searchSpace, int searchSpaceLength, ReadOnlySpan<char> values) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			ref char right = ref Unsafe.Add<char>(ref searchSpace, searchSpaceLength);
			ref char ptr = ref searchSpace;
			while (!Unsafe.AreSame<char>(ref ptr, ref right))
			{
				char ch = ptr;
				if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(ProbabilisticMap.Contains(values, ch)))
				{
					return ProbabilisticMap.MatchOffset(ref searchSpace, ref ptr);
				}
				ptr = Unsafe.Add<char>(ref ptr, 1);
			}
			return -1;
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x000C7984 File Offset: 0x000C5B84
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static int LastIndexOfAnySimpleLoop<TNegator>(ref char searchSpace, int searchSpaceLength, ReadOnlySpan<char> values) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			for (int i = searchSpaceLength - 1; i >= 0; i--)
			{
				char ch = *Unsafe.Add<char>(ref searchSpace, i);
				if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(ProbabilisticMap.Contains(values, ch)))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x04000C99 RID: 3225
		private readonly uint _e0;

		// Token: 0x04000C9A RID: 3226
		private readonly uint _e1;

		// Token: 0x04000C9B RID: 3227
		private readonly uint _e2;

		// Token: 0x04000C9C RID: 3228
		private readonly uint _e3;

		// Token: 0x04000C9D RID: 3229
		private readonly uint _e4;

		// Token: 0x04000C9E RID: 3230
		private readonly uint _e5;

		// Token: 0x04000C9F RID: 3231
		private readonly uint _e6;

		// Token: 0x04000CA0 RID: 3232
		private readonly uint _e7;
	}
}
