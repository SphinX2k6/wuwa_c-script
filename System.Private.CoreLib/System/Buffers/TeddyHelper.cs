using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace System.Buffers
{
	// Token: 0x0200038E RID: 910
	internal static class TeddyHelper
	{
		// Token: 0x06003C3E RID: 15422 RVA: 0x000C8E40 File Offset: 0x000C7040
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Result",
			"Prev0"
		})]
		public static ValueTuple<Vector128<byte>, Vector128<byte>> ProcessInputN2(Vector128<byte> input, Vector128<byte> prev0, Vector128<byte> n0Low, Vector128<byte> n0High, Vector128<byte> n1Low, Vector128<byte> n1High)
		{
			ValueTuple<Vector128<byte>, Vector128<byte>> nibbles = TeddyHelper.GetNibbles(input);
			Vector128<byte> item = nibbles.Item1;
			Vector128<byte> item2 = nibbles.Item2;
			Vector128<byte> vector = TeddyHelper.Shuffle(n0Low, n0High, item, item2);
			Vector128<byte> right = TeddyHelper.Shuffle(n1Low, n1High, item, item2);
			return new ValueTuple<Vector128<byte>, Vector128<byte>>(TeddyHelper.RightShift1(prev0, vector) & right, vector);
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x000C8E8C File Offset: 0x000C708C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Result",
			"Prev0",
			"Prev1"
		})]
		public static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> ProcessInputN3(Vector128<byte> input, Vector128<byte> prev0, Vector128<byte> prev1, Vector128<byte> n0Low, Vector128<byte> n0High, Vector128<byte> n1Low, Vector128<byte> n1High, Vector128<byte> n2Low, Vector128<byte> n2High)
		{
			ValueTuple<Vector128<byte>, Vector128<byte>> nibbles = TeddyHelper.GetNibbles(input);
			Vector128<byte> item = nibbles.Item1;
			Vector128<byte> item2 = nibbles.Item2;
			Vector128<byte> vector = TeddyHelper.Shuffle(n0Low, n0High, item, item2);
			Vector128<byte> vector2 = TeddyHelper.Shuffle(n1Low, n1High, item, item2);
			Vector128<byte> right = TeddyHelper.Shuffle(n2Low, n2High, item, item2);
			Vector128<byte> left = TeddyHelper.RightShift2(prev0, vector);
			Vector128<byte> right2 = TeddyHelper.RightShift1(prev1, vector2);
			return new ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>>(left & right2 & right, vector, vector2);
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x000C8EF8 File Offset: 0x000C70F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<byte> LoadAndPack16AsciiChars(ref char source)
		{
			Vector128<ushort> vector = Vector128.LoadUnsafe(ref source);
			Vector128<ushort> vector2 = Vector128.LoadUnsafe(ref source, (UIntPtr)((IntPtr)Vector128<ushort>.Count));
			if (!Sse2.IsSupported)
			{
				return AdvSimd.ExtractNarrowingSaturateUpper(AdvSimd.ExtractNarrowingSaturateLower(vector), vector2);
			}
			return Sse2.PackUnsignedSaturate(vector.AsInt16<ushort>(), vector2.AsInt16<ushort>());
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x000C8F40 File Offset: 0x000C7140
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Low",
			"High"
		})]
		private static ValueTuple<Vector128<byte>, Vector128<byte>> GetNibbles(Vector128<byte> input)
		{
			Vector128<byte> item = Ssse3.IsSupported ? input : (input & Vector128.Create(15));
			Vector128<byte> item2 = Vector128<byte>.op_UnsignedRightShift(input, 4);
			return new ValueTuple<Vector128<byte>, Vector128<byte>>(item, item2);
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x000C8F72 File Offset: 0x000C7172
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> Shuffle(Vector128<byte> maskLow, Vector128<byte> maskHigh, Vector128<byte> low, Vector128<byte> high)
		{
			return Vector128.ShuffleUnsafe(maskLow, low) & Vector128.ShuffleUnsafe(maskHigh, high);
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x000C8F87 File Offset: 0x000C7187
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> RightShift1(Vector128<byte> left, Vector128<byte> right)
		{
			if (!Ssse3.IsSupported)
			{
				return AdvSimd.ExtractVector128(left, right, 15);
			}
			return Ssse3.AlignRight(right, left, 15);
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x000C8FA3 File Offset: 0x000C71A3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> RightShift2(Vector128<byte> left, Vector128<byte> right)
		{
			if (!Ssse3.IsSupported)
			{
				return AdvSimd.ExtractVector128(left, right, 14);
			}
			return Ssse3.AlignRight(right, left, 14);
		}
	}
}
