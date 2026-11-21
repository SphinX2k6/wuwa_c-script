using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000573 RID: 1395
	[CLSCompliant(false)]
	public abstract class Avx512BW : Avx512F
	{
		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Abs(Vector512<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> Abs(Vector512<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> Add(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Add(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> Add(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> Add(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> AddSaturate(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> AddSaturate(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> AddSaturate(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> AddSaturate(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> AlignRight(Vector512<sbyte> left, Vector512<sbyte> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> AlignRight(Vector512<byte> left, Vector512<byte> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Average(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> Average(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> BlendVariable(Vector512<byte> left, Vector512<byte> right, Vector512<byte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> BlendVariable(Vector512<short> left, Vector512<short> right, Vector512<short> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> BlendVariable(Vector512<sbyte> left, Vector512<sbyte> right, Vector512<sbyte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> BlendVariable(Vector512<ushort> left, Vector512<ushort> right, Vector512<ushort> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> BroadcastScalarToVector512(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> BroadcastScalarToVector512(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> BroadcastScalarToVector512(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> BroadcastScalarToVector512(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> CompareEqual(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> CompareGreaterThan(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> CompareGreaterThanOrEqual(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006792 RID: 26514 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> CompareLessThan(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> CompareLessThanOrEqual(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> CompareNotEqual(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> CompareEqual(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> CompareGreaterThan(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> CompareGreaterThanOrEqual(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> CompareLessThan(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> CompareLessThanOrEqual(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> CompareNotEqual(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> CompareEqual(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> CompareGreaterThan(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> CompareGreaterThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> CompareLessThan(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> CompareLessThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> CompareNotEqual(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> CompareEqual(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> CompareGreaterThan(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> CompareGreaterThanOrEqual(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> CompareLessThan(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> CompareLessThanOrEqual(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> CompareNotEqual(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> ConvertToVector256Byte(Vector512<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> ConvertToVector256Byte(Vector512<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067A9 RID: 26537 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> ConvertToVector256ByteWithSaturation(Vector512<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067AA RID: 26538 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> ConvertToVector256SByte(Vector512<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> ConvertToVector256SByte(Vector512<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> ConvertToVector256SByteWithSaturation(Vector512<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ConvertToVector512Int16(Vector256<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ConvertToVector512Int16(Vector256<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ConvertToVector512UInt16(Vector256<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ConvertToVector512UInt16(Vector256<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new unsafe static Vector512<sbyte> LoadVector512(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new unsafe static Vector512<byte> LoadVector512(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new unsafe static Vector512<short> LoadVector512(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new unsafe static Vector512<ushort> LoadVector512(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> Max(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Max(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> Max(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> Max(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> Min(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Min(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> Min(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> Min(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> MultiplyAddAdjacent(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> MultiplyAddAdjacent(Vector512<byte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> MultiplyHigh(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> MultiplyHigh(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> MultiplyHighRoundScale(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> MultiplyLow(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> MultiplyLow(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> PackSignedSaturate(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> PackSignedSaturate(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> PackUnsignedSaturate(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> PackUnsignedSaturate(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> PermuteVar32x16(Vector512<short> left, Vector512<short> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> PermuteVar32x16(Vector512<ushort> left, Vector512<ushort> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> PermuteVar32x16x2(Vector512<short> lower, Vector512<short> indices, Vector512<short> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> PermuteVar32x16x2(Vector512<ushort> lower, Vector512<ushort> indices, Vector512<ushort> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftLeftLogical(Vector512<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ShiftLeftLogical(Vector512<ushort> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftLeftLogical(Vector512<short> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ShiftLeftLogical(Vector512<ushort> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> ShiftLeftLogical128BitLane(Vector512<sbyte> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> ShiftLeftLogical128BitLane(Vector512<byte> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftLeftLogicalVariable(Vector512<short> value, Vector512<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ShiftLeftLogicalVariable(Vector512<ushort> value, Vector512<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftRightArithmeticVariable(Vector512<short> value, Vector512<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftRightLogical(Vector512<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftRightLogical(Vector512<short> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> ShiftRightLogical128BitLane(Vector512<sbyte> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067DC RID: 26588 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> ShiftRightLogical128BitLane(Vector512<byte> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067DD RID: 26589 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShiftRightLogicalVariable(Vector512<short> value, Vector512<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ShiftRightLogicalVariable(Vector512<ushort> value, Vector512<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> Shuffle(Vector512<sbyte> value, Vector512<sbyte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Shuffle(Vector512<byte> value, Vector512<byte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShuffleHigh(Vector512<short> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ShuffleHigh(Vector512<ushort> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> ShuffleLow(Vector512<short> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> ShuffleLow(Vector512<ushort> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new unsafe static void Store(sbyte* address, Vector512<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new unsafe static void Store(byte* address, Vector512<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new unsafe static void Store(short* address, Vector512<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new unsafe static void Store(ushort* address, Vector512<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> Subtract(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Subtract(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> Subtract(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> Subtract(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> SubtractSaturate(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> SubtractSaturate(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> SubtractSaturate(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> SubtractSaturate(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> SumAbsoluteDifferences(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> SumAbsoluteDifferencesInBlock32(Vector512<byte> left, Vector512<byte> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> UnpackHigh(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> UnpackHigh(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> UnpackHigh(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> UnpackHigh(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> UnpackLow(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> UnpackLow(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> UnpackLow(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> UnpackLow(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000574 RID: 1396
		public new abstract class VL : Avx512F.VL
		{
			// Token: 0x17000D81 RID: 3457
			// (get) Token: 0x060067FB RID: 26619 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x060067FC RID: 26620 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> CompareGreaterThan(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060067FD RID: 26621 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> CompareGreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060067FE RID: 26622 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> CompareLessThan(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060067FF RID: 26623 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> CompareLessThanOrEqual(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006800 RID: 26624 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> CompareNotEqual(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006801 RID: 26625 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> CompareGreaterThan(Vector256<byte> left, Vector256<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006802 RID: 26626 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> CompareGreaterThanOrEqual(Vector256<byte> left, Vector256<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006803 RID: 26627 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> CompareLessThan(Vector256<byte> left, Vector256<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006804 RID: 26628 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> CompareLessThanOrEqual(Vector256<byte> left, Vector256<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006805 RID: 26629 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> CompareNotEqual(Vector256<byte> left, Vector256<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006806 RID: 26630 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> CompareGreaterThanOrEqual(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006807 RID: 26631 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006808 RID: 26632 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> CompareLessThanOrEqual(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006809 RID: 26633 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> CompareNotEqual(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600680A RID: 26634 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> CompareGreaterThanOrEqual(Vector256<short> left, Vector256<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600680B RID: 26635 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> CompareLessThan(Vector256<short> left, Vector256<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600680C RID: 26636 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> CompareLessThanOrEqual(Vector256<short> left, Vector256<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600680D RID: 26637 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> CompareNotEqual(Vector256<short> left, Vector256<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600680E RID: 26638 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> CompareGreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600680F RID: 26639 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> CompareLessThan(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006810 RID: 26640 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> CompareLessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006811 RID: 26641 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> CompareNotEqual(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006812 RID: 26642 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<sbyte> CompareGreaterThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006813 RID: 26643 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<sbyte> CompareLessThan(Vector256<sbyte> left, Vector256<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006814 RID: 26644 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<sbyte> CompareLessThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006815 RID: 26645 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<sbyte> CompareNotEqual(Vector256<sbyte> left, Vector256<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006816 RID: 26646 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> CompareGreaterThan(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006817 RID: 26647 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> CompareGreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006818 RID: 26648 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> CompareLessThan(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006819 RID: 26649 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> CompareLessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600681A RID: 26650 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> CompareNotEqual(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600681B RID: 26651 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> CompareGreaterThan(Vector256<ushort> left, Vector256<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600681C RID: 26652 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> CompareGreaterThanOrEqual(Vector256<ushort> left, Vector256<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600681D RID: 26653 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> CompareLessThan(Vector256<ushort> left, Vector256<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600681E RID: 26654 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> CompareLessThanOrEqual(Vector256<ushort> left, Vector256<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600681F RID: 26655 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> CompareNotEqual(Vector256<ushort> left, Vector256<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006820 RID: 26656 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector128<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006821 RID: 26657 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector128<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006822 RID: 26658 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector256<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006823 RID: 26659 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector256<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006824 RID: 26660 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006825 RID: 26661 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006826 RID: 26662 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector128<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006827 RID: 26663 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector128<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006828 RID: 26664 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector256<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006829 RID: 26665 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector256<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600682A RID: 26666 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600682B RID: 26667 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600682C RID: 26668 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> PermuteVar8x16(Vector128<short> left, Vector128<short> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600682D RID: 26669 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> PermuteVar8x16(Vector128<ushort> left, Vector128<ushort> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600682E RID: 26670 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> PermuteVar8x16x2(Vector128<short> lower, Vector128<short> indices, Vector128<short> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600682F RID: 26671 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> PermuteVar8x16x2(Vector128<ushort> lower, Vector128<ushort> indices, Vector128<ushort> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006830 RID: 26672 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> PermuteVar16x16(Vector256<short> left, Vector256<short> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006831 RID: 26673 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> PermuteVar16x16(Vector256<ushort> left, Vector256<ushort> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006832 RID: 26674 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> PermuteVar16x16x2(Vector256<short> lower, Vector256<short> indices, Vector256<short> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006833 RID: 26675 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> PermuteVar16x16x2(Vector256<ushort> lower, Vector256<ushort> indices, Vector256<ushort> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006834 RID: 26676 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ShiftLeftLogicalVariable(Vector128<short> value, Vector128<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006835 RID: 26677 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ShiftLeftLogicalVariable(Vector128<ushort> value, Vector128<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006836 RID: 26678 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> ShiftLeftLogicalVariable(Vector256<short> value, Vector256<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006837 RID: 26679 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> ShiftLeftLogicalVariable(Vector256<ushort> value, Vector256<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006838 RID: 26680 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ShiftRightArithmeticVariable(Vector128<short> value, Vector128<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006839 RID: 26681 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> ShiftRightArithmeticVariable(Vector256<short> value, Vector256<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600683A RID: 26682 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ShiftRightLogicalVariable(Vector128<short> value, Vector128<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600683B RID: 26683 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ShiftRightLogicalVariable(Vector128<ushort> value, Vector128<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600683C RID: 26684 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> ShiftRightLogicalVariable(Vector256<short> value, Vector256<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600683D RID: 26685 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> ShiftRightLogicalVariable(Vector256<ushort> value, Vector256<ushort> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600683E RID: 26686 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> SumAbsoluteDifferencesInBlock32(Vector128<byte> left, Vector128<byte> right, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600683F RID: 26687 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> SumAbsoluteDifferencesInBlock32(Vector256<byte> left, Vector256<byte> right, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}
		}

		// Token: 0x02000575 RID: 1397
		public new abstract class X64 : Avx512F.X64
		{
			// Token: 0x17000D82 RID: 3458
			// (get) Token: 0x06006840 RID: 26688 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}
		}
	}
}
