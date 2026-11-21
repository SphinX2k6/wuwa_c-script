using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200056D RID: 1389
	[CLSCompliant(false)]
	public abstract class Avx2 : Avx
	{
		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060063E5 RID: 25573 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Abs(Vector256<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Abs(Vector256<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Abs(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Add(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Add(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Add(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> AddSaturate(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> AddSaturate(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> AddSaturate(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> AddSaturate(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> AlignRight(Vector256<sbyte> left, Vector256<sbyte> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> AlignRight(Vector256<byte> left, Vector256<byte> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> AlignRight(Vector256<short> left, Vector256<short> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> AlignRight(Vector256<ushort> left, Vector256<ushort> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> AlignRight(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> AlignRight(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> AlignRight(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> AlignRight(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> And(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> And(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> And(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> And(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> And(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> And(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> And(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> And(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> AndNot(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> AndNot(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> AndNot(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> AndNot(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> AndNot(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> AndNot(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> AndNot(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> AndNot(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Average(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Average(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Blend(Vector128<int> left, Vector128<int> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Blend(Vector128<uint> left, Vector128<uint> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Blend(Vector256<short> left, Vector256<short> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Blend(Vector256<ushort> left, Vector256<ushort> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Blend(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Blend(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> BlendVariable(Vector256<sbyte> left, Vector256<sbyte> right, Vector256<sbyte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> BlendVariable(Vector256<byte> left, Vector256<byte> right, Vector256<byte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> BlendVariable(Vector256<short> left, Vector256<short> right, Vector256<short> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> BlendVariable(Vector256<ushort> left, Vector256<ushort> right, Vector256<ushort> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> BlendVariable(Vector256<int> left, Vector256<int> right, Vector256<int> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> BlendVariable(Vector256<uint> left, Vector256<uint> right, Vector256<uint> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> BlendVariable(Vector256<long> left, Vector256<long> right, Vector256<long> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> BlendVariable(Vector256<ulong> left, Vector256<ulong> right, Vector256<ulong> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> BroadcastScalarToVector128(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> BroadcastScalarToVector128(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> BroadcastScalarToVector128(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> BroadcastScalarToVector128(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> BroadcastScalarToVector128(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> BroadcastScalarToVector128(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> BroadcastScalarToVector128(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> BroadcastScalarToVector128(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> BroadcastScalarToVector128(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> BroadcastScalarToVector128(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<byte> BroadcastScalarToVector128(byte* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<sbyte> BroadcastScalarToVector128(sbyte* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<short> BroadcastScalarToVector128(short* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ushort> BroadcastScalarToVector128(ushort* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600642B RID: 25643 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> BroadcastScalarToVector128(int* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> BroadcastScalarToVector128(uint* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> BroadcastScalarToVector128(long* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600642E RID: 25646 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> BroadcastScalarToVector128(ulong* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600642F RID: 25647 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> BroadcastScalarToVector256(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> BroadcastScalarToVector256(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> BroadcastScalarToVector256(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> BroadcastScalarToVector256(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> BroadcastScalarToVector256(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> BroadcastScalarToVector256(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> BroadcastScalarToVector256(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> BroadcastScalarToVector256(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> BroadcastScalarToVector256(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> BroadcastScalarToVector256(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<byte> BroadcastScalarToVector256(byte* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<sbyte> BroadcastScalarToVector256(sbyte* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<short> BroadcastScalarToVector256(short* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ushort> BroadcastScalarToVector256(ushort* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> BroadcastScalarToVector256(int* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> BroadcastScalarToVector256(uint* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> BroadcastScalarToVector256(long* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> BroadcastScalarToVector256(ulong* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006441 RID: 25665 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<sbyte> BroadcastVector128ToVector256(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<byte> BroadcastVector128ToVector256(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<short> BroadcastVector128ToVector256(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006444 RID: 25668 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ushort> BroadcastVector128ToVector256(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006445 RID: 25669 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> BroadcastVector128ToVector256(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006446 RID: 25670 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> BroadcastVector128ToVector256(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006447 RID: 25671 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> BroadcastVector128ToVector256(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> BroadcastVector128ToVector256(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> CompareEqual(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> CompareEqual(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> CompareEqual(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> CompareEqual(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> CompareEqual(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> CompareEqual(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> CompareEqual(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> CompareEqual(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> CompareGreaterThan(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> CompareGreaterThan(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> CompareGreaterThan(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> CompareGreaterThan(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ConvertToInt32(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ConvertToVector256Int16(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ConvertToVector256Int16(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<short> ConvertToVector256Int16(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<short> ConvertToVector256Int16(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> ConvertToVector256Int32(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> ConvertToVector256Int32(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> ConvertToVector256Int32(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> ConvertToVector256Int32(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> ConvertToVector256Int64(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> ConvertToVector256Int64(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> ConvertToVector256Int64(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> ConvertToVector256Int64(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> ConvertToVector256Int64(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> ConvertToVector256Int64(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<sbyte> ExtractVector128(Vector256<sbyte> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<byte> ExtractVector128(Vector256<byte> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<short> ExtractVector128(Vector256<short> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<ushort> ExtractVector128(Vector256<ushort> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006473 RID: 25715 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<int> ExtractVector128(Vector256<int> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006474 RID: 25716 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<uint> ExtractVector128(Vector256<uint> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<long> ExtractVector128(Vector256<long> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<ulong> ExtractVector128(Vector256<ulong> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> GatherVector128(int* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> GatherVector128(uint* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> GatherVector128(long* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> GatherVector128(ulong* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> GatherVector128(float* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> GatherVector128(double* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> GatherVector128(int* baseAddress, Vector128<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> GatherVector128(uint* baseAddress, Vector128<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> GatherVector128(long* baseAddress, Vector128<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> GatherVector128(ulong* baseAddress, Vector128<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> GatherVector128(float* baseAddress, Vector128<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> GatherVector128(double* baseAddress, Vector128<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> GatherVector256(int* baseAddress, Vector256<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> GatherVector256(uint* baseAddress, Vector256<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> GatherVector256(long* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> GatherVector256(ulong* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<float> GatherVector256(float* baseAddress, Vector256<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> GatherVector256(double* baseAddress, Vector128<int> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> GatherVector128(int* baseAddress, Vector256<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> GatherVector128(uint* baseAddress, Vector256<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> GatherVector256(long* baseAddress, Vector256<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> GatherVector256(ulong* baseAddress, Vector256<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> GatherVector128(float* baseAddress, Vector256<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> GatherVector256(double* baseAddress, Vector256<long> index, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector128<int> index, Vector128<int> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector128<int> index, Vector128<uint> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> GatherMaskVector128(Vector128<long> source, long* baseAddress, Vector128<int> index, Vector128<long> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> GatherMaskVector128(Vector128<ulong> source, ulong* baseAddress, Vector128<int> index, Vector128<ulong> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector128<int> index, Vector128<float> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> GatherMaskVector128(Vector128<double> source, double* baseAddress, Vector128<int> index, Vector128<double> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector128<long> index, Vector128<int> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector128<long> index, Vector128<uint> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> GatherMaskVector128(Vector128<long> source, long* baseAddress, Vector128<long> index, Vector128<long> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> GatherMaskVector128(Vector128<ulong> source, ulong* baseAddress, Vector128<long> index, Vector128<ulong> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector128<long> index, Vector128<float> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> GatherMaskVector128(Vector128<double> source, double* baseAddress, Vector128<long> index, Vector128<double> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> GatherMaskVector256(Vector256<int> source, int* baseAddress, Vector256<int> index, Vector256<int> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> GatherMaskVector256(Vector256<uint> source, uint* baseAddress, Vector256<int> index, Vector256<uint> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> GatherMaskVector256(Vector256<long> source, long* baseAddress, Vector128<int> index, Vector256<long> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> GatherMaskVector256(Vector256<ulong> source, ulong* baseAddress, Vector128<int> index, Vector256<ulong> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<float> GatherMaskVector256(Vector256<float> source, float* baseAddress, Vector256<int> index, Vector256<float> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> GatherMaskVector256(Vector256<double> source, double* baseAddress, Vector128<int> index, Vector256<double> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector256<long> index, Vector128<int> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector256<long> index, Vector128<uint> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> GatherMaskVector256(Vector256<long> source, long* baseAddress, Vector256<long> index, Vector256<long> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> GatherMaskVector256(Vector256<ulong> source, ulong* baseAddress, Vector256<long> index, Vector256<ulong> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector256<long> index, Vector128<float> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<double> GatherMaskVector256(Vector256<double> source, double* baseAddress, Vector256<long> index, Vector256<double> mask, [ConstantExpected(Min = 1, Max = 8)] byte scale)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> HorizontalAdd(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> HorizontalAdd(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> HorizontalAddSaturate(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> HorizontalSubtract(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> HorizontalSubtract(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064AC RID: 25772 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> HorizontalSubtractSaturate(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<sbyte> InsertVector128(Vector256<sbyte> value, Vector128<sbyte> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<byte> InsertVector128(Vector256<byte> value, Vector128<byte> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<short> InsertVector128(Vector256<short> value, Vector128<short> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<ushort> InsertVector128(Vector256<ushort> value, Vector128<ushort> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<int> InsertVector128(Vector256<int> value, Vector128<int> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<uint> InsertVector128(Vector256<uint> value, Vector128<uint> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<long> InsertVector128(Vector256<long> value, Vector128<long> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<ulong> InsertVector128(Vector256<ulong> value, Vector128<ulong> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<sbyte> LoadAlignedVector256NonTemporal(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<byte> LoadAlignedVector256NonTemporal(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<short> LoadAlignedVector256NonTemporal(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ushort> LoadAlignedVector256NonTemporal(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> LoadAlignedVector256NonTemporal(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> LoadAlignedVector256NonTemporal(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> LoadAlignedVector256NonTemporal(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> LoadAlignedVector256NonTemporal(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> MaskLoad(int* address, Vector128<int> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> MaskLoad(uint* address, Vector128<uint> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> MaskLoad(long* address, Vector128<long> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> MaskLoad(ulong* address, Vector128<ulong> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<int> MaskLoad(int* address, Vector256<int> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<uint> MaskLoad(uint* address, Vector256<uint> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<long> MaskLoad(long* address, Vector256<long> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector256<ulong> MaskLoad(ulong* address, Vector256<ulong> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(int* address, Vector128<int> mask, Vector128<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(uint* address, Vector128<uint> mask, Vector128<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(long* address, Vector128<long> mask, Vector128<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(ulong* address, Vector128<ulong> mask, Vector128<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(int* address, Vector256<int> mask, Vector256<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(uint* address, Vector256<uint> mask, Vector256<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(long* address, Vector256<long> mask, Vector256<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void MaskStore(ulong* address, Vector256<ulong> mask, Vector256<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> MultiplyAddAdjacent(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> MultiplyAddAdjacent(Vector256<byte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Max(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Max(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Max(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Min(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Min(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int MoveMask(Vector256<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int MoveMask(Vector256<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> MultipleSumAbsoluteDifferences(Vector256<byte> left, Vector256<byte> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Multiply(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Multiply(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> MultiplyHigh(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> MultiplyHigh(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> MultiplyHighRoundScale(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> MultiplyLow(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> MultiplyLow(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> MultiplyLow(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> MultiplyLow(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Or(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Or(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Or(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Or(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Or(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Or(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Or(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Or(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> PackSignedSaturate(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> PackSignedSaturate(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> PackUnsignedSaturate(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> PackUnsignedSaturate(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<sbyte> Permute2x128(Vector256<sbyte> left, Vector256<sbyte> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<byte> Permute2x128(Vector256<byte> left, Vector256<byte> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<short> Permute2x128(Vector256<short> left, Vector256<short> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<ushort> Permute2x128(Vector256<ushort> left, Vector256<ushort> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<int> Permute2x128(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<uint> Permute2x128(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<long> Permute2x128(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<ulong> Permute2x128(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Permute4x64(Vector256<long> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Permute4x64(Vector256<ulong> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Permute4x64(Vector256<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> PermuteVar8x32(Vector256<int> left, Vector256<int> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> PermuteVar8x32(Vector256<uint> left, Vector256<uint> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> PermuteVar8x32(Vector256<float> left, Vector256<int> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftLeftLogical(Vector256<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShiftLeftLogical(Vector256<ushort> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftLeftLogical(Vector256<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ShiftLeftLogical(Vector256<uint> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftLeftLogical(Vector256<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ShiftLeftLogical(Vector256<ulong> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftLeftLogical(Vector256<short> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShiftLeftLogical(Vector256<ushort> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftLeftLogical(Vector256<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ShiftLeftLogical(Vector256<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftLeftLogical(Vector256<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ShiftLeftLogical(Vector256<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> ShiftLeftLogical128BitLane(Vector256<sbyte> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> ShiftLeftLogical128BitLane(Vector256<byte> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftLeftLogical128BitLane(Vector256<short> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShiftLeftLogical128BitLane(Vector256<ushort> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftLeftLogical128BitLane(Vector256<int> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ShiftLeftLogical128BitLane(Vector256<uint> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftLeftLogical128BitLane(Vector256<long> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ShiftLeftLogical128BitLane(Vector256<ulong> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLeftLogicalVariable(Vector128<int> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLeftLogicalVariable(Vector128<uint> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLeftLogicalVariable(Vector128<long> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLeftLogicalVariable(Vector128<ulong> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftLeftLogicalVariable(Vector256<int> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ShiftLeftLogicalVariable(Vector256<uint> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftLeftLogicalVariable(Vector256<long> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ShiftLeftLogicalVariable(Vector256<ulong> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightArithmeticVariable(Vector128<int> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftRightArithmeticVariable(Vector256<int> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftRightLogical(Vector256<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftRightLogical(Vector256<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftRightLogical(Vector256<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftRightLogical(Vector256<short> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftRightLogical(Vector256<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftRightLogical(Vector256<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> ShiftRightLogical128BitLane(Vector256<sbyte> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> ShiftRightLogical128BitLane(Vector256<byte> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftRightLogical128BitLane(Vector256<short> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShiftRightLogical128BitLane(Vector256<ushort> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftRightLogical128BitLane(Vector256<int> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ShiftRightLogical128BitLane(Vector256<uint> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftRightLogical128BitLane(Vector256<long> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ShiftRightLogical128BitLane(Vector256<ulong> value, [ConstantExpected] byte numBytes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogicalVariable(Vector128<int> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogicalVariable(Vector128<uint> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightLogicalVariable(Vector128<long> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftRightLogicalVariable(Vector128<ulong> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ShiftRightLogicalVariable(Vector256<int> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ShiftRightLogicalVariable(Vector256<uint> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftRightLogicalVariable(Vector256<long> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ShiftRightLogicalVariable(Vector256<ulong> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Shuffle(Vector256<sbyte> value, Vector256<sbyte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Shuffle(Vector256<byte> value, Vector256<byte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Shuffle(Vector256<int> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Shuffle(Vector256<uint> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShuffleHigh(Vector256<short> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006544 RID: 25924 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShuffleHigh(Vector256<ushort> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShuffleLow(Vector256<short> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShuffleLow(Vector256<ushort> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Sign(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Sign(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Sign(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Subtract(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Subtract(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Subtract(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> SubtractSaturate(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> SubtractSaturate(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> SubtractSaturate(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> SubtractSaturate(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> SumAbsoluteDifferences(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> UnpackHigh(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006558 RID: 25944 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> UnpackHigh(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> UnpackHigh(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> UnpackHigh(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> UnpackHigh(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> UnpackHigh(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> UnpackHigh(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> UnpackHigh(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> UnpackLow(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> UnpackLow(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> UnpackLow(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> UnpackLow(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> UnpackLow(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> UnpackLow(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> UnpackLow(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> UnpackLow(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> Xor(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> Xor(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> Xor(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> Xor(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Xor(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Xor(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Xor(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Xor(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0200056E RID: 1390
		public new abstract class X64 : Avx.X64
		{
			// Token: 0x17000D7B RID: 3451
			// (get) Token: 0x0600656F RID: 25967 RVA: 0x00007B65 File Offset: 0x00005D65
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
