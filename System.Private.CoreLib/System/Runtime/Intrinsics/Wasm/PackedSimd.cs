using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Wasm
{
	// Token: 0x02000550 RID: 1360
	[CLSCompliant(false)]
	public abstract class PackedSimd
	{
		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06005092 RID: 20626 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Splat(sbyte value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Splat(byte value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Splat(short value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Splat(ushort value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Splat(int value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Splat(uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Splat(long value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Splat(ulong value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Splat(float value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Splat(double value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Splat(IntPtr value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> Splat(UIntPtr value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ExtractScalar(Vector128<sbyte> value, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ExtractScalar(Vector128<byte> value, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ExtractScalar(Vector128<short> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ExtractScalar(Vector128<ushort> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ExtractScalar(Vector128<int> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ExtractScalar(Vector128<uint> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long ExtractScalar(Vector128<long> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong ExtractScalar(Vector128<ulong> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static float ExtractScalar(Vector128<float> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static double ExtractScalar(Vector128<double> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static IntPtr ExtractScalar(Vector128<IntPtr> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static UIntPtr ExtractScalar(Vector128<UIntPtr> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ReplaceScalar(Vector128<sbyte> vector, [ConstantExpected(Max = 15)] byte imm, int value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ReplaceScalar(Vector128<byte> vector, [ConstantExpected(Max = 15)] byte imm, uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ReplaceScalar(Vector128<short> vector, [ConstantExpected(Max = 7)] byte imm, int value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ReplaceScalar(Vector128<ushort> vector, [ConstantExpected(Max = 7)] byte imm, uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ReplaceScalar(Vector128<int> vector, [ConstantExpected(Max = 3)] byte imm, int value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ReplaceScalar(Vector128<uint> vector, [ConstantExpected(Max = 3)] byte imm, uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ReplaceScalar(Vector128<long> vector, [ConstantExpected(Max = 1)] byte imm, long value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ReplaceScalar(Vector128<ulong> vector, [ConstantExpected(Max = 1)] byte imm, ulong value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReplaceScalar(Vector128<float> vector, [ConstantExpected(Max = 3)] byte imm, float value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReplaceScalar(Vector128<double> vector, [ConstantExpected(Max = 1)] byte imm, double value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> ReplaceScalar(Vector128<IntPtr> vector, [ConstantExpected(Max = 3)] byte imm, IntPtr value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> ReplaceScalar(Vector128<UIntPtr> vector, [ConstantExpected(Max = 3)] byte imm, UIntPtr value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Swizzle(Vector128<sbyte> vector, Vector128<sbyte> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Swizzle(Vector128<byte> vector, Vector128<byte> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Add(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Add(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Add(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Add(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> Add(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Subtract(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> Subtract(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Multiply(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Multiply(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Multiply(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Multiply(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> Multiply(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Dot(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Negate(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Negate(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Negate(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Negate(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Negate(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Negate(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Negate(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Negate(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Negate(Vector128<IntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> Negate(Vector128<UIntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyWideningLower(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyWideningLower(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningLower(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyWideningLower(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyWideningLower(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyWideningLower(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyWideningUpper(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningUpper(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyWideningUpper(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyWideningUpper(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddPairwiseWidening(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddPairwiseWidening(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddPairwiseWidening(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddPairwiseWidening(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> AddSaturate(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AddSaturate(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddSaturate(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddSaturate(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> SubtractSaturate(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> SubtractSaturate(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SubtractSaturate(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SubtractSaturate(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedSaturateQ15(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Min(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Min(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Max(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Max(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AverageRounded(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AverageRounded(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Abs(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Abs(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Abs(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Abs(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Abs(Vector128<IntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLeft(Vector128<byte> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLeft(Vector128<short> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLeft(Vector128<ushort> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLeft(Vector128<int> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLeft(Vector128<uint> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLeft(Vector128<long> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLeft(Vector128<ulong> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> ShiftLeft(Vector128<IntPtr> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> ShiftLeft(Vector128<UIntPtr> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightArithmetic(Vector128<byte> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightArithmetic(Vector128<ushort> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightArithmetic(Vector128<uint> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftRightArithmetic(Vector128<ulong> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> ShiftRightArithmetic(Vector128<IntPtr> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> ShiftRightArithmetic(Vector128<UIntPtr> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogical(Vector128<byte> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogical(Vector128<short> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogical(Vector128<int> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightLogical(Vector128<long> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> ShiftRightLogical(Vector128<IntPtr> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> ShiftRightLogical(Vector128<UIntPtr> value, int count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> And(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> And(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> And(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> And(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> And(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> And(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> And(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> And(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> And(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> And(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> And(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> And(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Or(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Or(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Or(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Or(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Or(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Or(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Or(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Or(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Or(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Or(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Or(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> Or(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Xor(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Xor(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Xor(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Xor(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Xor(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Xor(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Xor(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Xor(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Xor(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Xor(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Xor(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> Xor(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Not(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Not(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Not(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Not(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Not(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Not(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Not(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Not(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Not(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Not(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> Not(Vector128<IntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> Not(Vector128<UIntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> AndNot(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AndNot(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AndNot(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AndNot(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AndNot(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AndNot(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AndNot(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AndNot(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> AndNot(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> AndNot(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> AndNot(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> AndNot(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> BitwiseSelect(Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> BitwiseSelect(Vector128<byte> left, Vector128<byte> right, Vector128<byte> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> BitwiseSelect(Vector128<short> left, Vector128<short> right, Vector128<short> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> BitwiseSelect(Vector128<ushort> left, Vector128<ushort> right, Vector128<ushort> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> BitwiseSelect(Vector128<int> left, Vector128<int> right, Vector128<int> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> BitwiseSelect(Vector128<uint> left, Vector128<uint> right, Vector128<uint> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> BitwiseSelect(Vector128<long> left, Vector128<long> right, Vector128<long> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> BitwiseSelect(Vector128<ulong> left, Vector128<ulong> right, Vector128<ulong> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> BitwiseSelect(Vector128<float> left, Vector128<float> right, Vector128<float> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> BitwiseSelect(Vector128<double> left, Vector128<double> right, Vector128<double> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> BitwiseSelect(Vector128<IntPtr> left, Vector128<IntPtr> right, Vector128<IntPtr> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> BitwiseSelect(Vector128<UIntPtr> left, Vector128<UIntPtr> right, Vector128<UIntPtr> select)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> PopCount(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<IntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AnyTrue(Vector128<UIntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<IntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool AllTrue(Vector128<UIntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<IntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Bitmask(Vector128<UIntPtr> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareEqual(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareEqual(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> CompareEqual(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> CompareEqual(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> CompareEqual(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareNotEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareNotEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareNotEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareNotEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareNotEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareNotEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareNotEqual(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareNotEqual(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareNotEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> CompareNotEqual(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> CompareNotEqual(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> CompareNotEqual(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareLessThan(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareLessThan(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareLessThan(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareLessThan(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareLessThan(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareLessThan(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareLessThan(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareLessThan(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> CompareLessThan(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> CompareLessThan(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> CompareLessThan(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareLessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareLessThanOrEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareLessThanOrEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareLessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareLessThanOrEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareLessThanOrEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareLessThanOrEqual(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareLessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> CompareLessThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> CompareLessThanOrEqual(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> CompareLessThanOrEqual(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareGreaterThan(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareGreaterThan(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareGreaterThan(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareGreaterThan(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareGreaterThan(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareGreaterThan(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareGreaterThan(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareGreaterThan(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> CompareGreaterThan(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> CompareGreaterThan(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> CompareGreaterThan(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareGreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareGreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareGreaterThanOrEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareGreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareGreaterThanOrEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareGreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareGreaterThanOrEqual(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareGreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> CompareGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<IntPtr> CompareGreaterThanOrEqual(Vector128<IntPtr> left, Vector128<IntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<UIntPtr> CompareGreaterThanOrEqual(Vector128<UIntPtr> left, Vector128<UIntPtr> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<sbyte> LoadVector128(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<byte> LoadVector128(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<short> LoadVector128(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ushort> LoadVector128(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> LoadVector128(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> LoadVector128(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> LoadVector128(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> LoadVector128(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> LoadVector128(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> LoadVector128(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<IntPtr> LoadVector128(IntPtr* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<UIntPtr> LoadVector128(UIntPtr* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> LoadScalarVector128(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> LoadScalarVector128(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> LoadScalarVector128(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> LoadScalarVector128(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> LoadScalarVector128(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> LoadScalarVector128(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<IntPtr> LoadScalarVector128(IntPtr* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<UIntPtr> LoadScalarVector128(UIntPtr* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<sbyte> LoadScalarAndSplatVector128(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<byte> LoadScalarAndSplatVector128(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<short> LoadScalarAndSplatVector128(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ushort> LoadScalarAndSplatVector128(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> LoadScalarAndSplatVector128(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> LoadScalarAndSplatVector128(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> LoadScalarAndSplatVector128(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> LoadScalarAndSplatVector128(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> LoadScalarAndSplatVector128(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> LoadScalarAndSplatVector128(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051F9 RID: 20985 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<IntPtr> LoadScalarAndSplatVector128(IntPtr* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<UIntPtr> LoadScalarAndSplatVector128(UIntPtr* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<sbyte> LoadScalarAndInsert(sbyte* address, Vector128<sbyte> vector, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<byte> LoadScalarAndInsert(byte* address, Vector128<byte> vector, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<short> LoadScalarAndInsert(short* address, Vector128<short> vector, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ushort> LoadScalarAndInsert(ushort* address, Vector128<ushort> vector, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> LoadScalarAndInsert(int* address, Vector128<int> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> LoadScalarAndInsert(uint* address, Vector128<uint> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> LoadScalarAndInsert(long* address, Vector128<long> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> LoadScalarAndInsert(ulong* address, Vector128<ulong> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> LoadScalarAndInsert(float* address, Vector128<float> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> LoadScalarAndInsert(double* address, Vector128<double> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<IntPtr> LoadScalarAndInsert(IntPtr* address, Vector128<IntPtr> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<UIntPtr> LoadScalarAndInsert(UIntPtr* address, Vector128<UIntPtr> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<short> LoadWideningVector128(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ushort> LoadWideningVector128(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> LoadWideningVector128(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> LoadWideningVector128(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> LoadWideningVector128(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> LoadWideningVector128(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(sbyte* address, Vector128<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(byte* address, Vector128<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(short* address, Vector128<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ushort* address, Vector128<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(int* address, Vector128<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(uint* address, Vector128<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(long* address, Vector128<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ulong* address, Vector128<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(float* address, Vector128<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(double* address, Vector128<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(IntPtr* address, Vector128<IntPtr> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(UIntPtr* address, Vector128<UIntPtr> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(sbyte* address, Vector128<sbyte> source, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(byte* address, Vector128<byte> source, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(short* address, Vector128<short> source, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(ushort* address, Vector128<ushort> source, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(int* address, Vector128<int> source, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(uint* address, Vector128<uint> source, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(long* address, Vector128<long> source, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(ulong* address, Vector128<ulong> source, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(float* address, Vector128<float> source, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(double* address, Vector128<double> source, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(IntPtr* address, Vector128<IntPtr> source, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(UIntPtr* address, Vector128<UIntPtr> source, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Negate(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Negate(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Abs(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Abs(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Min(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Min(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Max(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Max(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> PseudoMin(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> PseudoMin(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> PseudoMax(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> PseudoMax(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Add(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Add(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Sqrt(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Sqrt(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Ceiling(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Ceiling(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Floor(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Floor(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Truncate(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Truncate(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundToNearest(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> RoundToNearest(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToSingle(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToSingle(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToSingle(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ConvertToDoubleLower(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ConvertToDoubleLower(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ConvertToDoubleLower(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToInt32Saturate(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToUInt32Saturate(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToInt32Saturate(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToUInt32Saturate(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertNarrowingSaturateSigned(Vector128<short> lower, Vector128<short> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertNarrowingSaturateSigned(Vector128<int> lower, Vector128<int> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertNarrowingSaturateUnsigned(Vector128<short> lower, Vector128<short> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertNarrowingSaturateUnsigned(Vector128<int> lower, Vector128<int> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SignExtendWideningLower(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SignExtendWideningLower(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SignExtendWideningLower(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SignExtendWideningLower(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SignExtendWideningLower(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> SignExtendWideningLower(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SignExtendWideningUpper(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SignExtendWideningUpper(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SignExtendWideningUpper(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SignExtendWideningUpper(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SignExtendWideningUpper(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> SignExtendWideningUpper(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ZeroExtendWideningLower(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ZeroExtendWideningLower(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ZeroExtendWideningLower(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ZeroExtendWideningLower(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ZeroExtendWideningLower(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ZeroExtendWideningLower(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ZeroExtendWideningUpper(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ZeroExtendWideningUpper(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ZeroExtendWideningUpper(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ZeroExtendWideningUpper(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ZeroExtendWideningUpper(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ZeroExtendWideningUpper(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}
	}
}
