using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000594 RID: 1428
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Sse3 : Sse2
	{
		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06006DBE RID: 28094 RVA: 0x0010A4BC File Offset: 0x001086BC
		public new static bool IsSupported
		{
			get
			{
				return Sse3.IsSupported;
			}
		}

		// Token: 0x06006DBF RID: 28095 RVA: 0x0010A4C3 File Offset: 0x001086C3
		public static Vector128<float> AddSubtract(Vector128<float> left, Vector128<float> right)
		{
			return Sse3.AddSubtract(left, right);
		}

		// Token: 0x06006DC0 RID: 28096 RVA: 0x0010A4CC File Offset: 0x001086CC
		public static Vector128<double> AddSubtract(Vector128<double> left, Vector128<double> right)
		{
			return Sse3.AddSubtract(left, right);
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x0010A4D5 File Offset: 0x001086D5
		public static Vector128<float> HorizontalAdd(Vector128<float> left, Vector128<float> right)
		{
			return Sse3.HorizontalAdd(left, right);
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x0010A4DE File Offset: 0x001086DE
		public static Vector128<double> HorizontalAdd(Vector128<double> left, Vector128<double> right)
		{
			return Sse3.HorizontalAdd(left, right);
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x0010A4E7 File Offset: 0x001086E7
		public static Vector128<float> HorizontalSubtract(Vector128<float> left, Vector128<float> right)
		{
			return Sse3.HorizontalSubtract(left, right);
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x0010A4F0 File Offset: 0x001086F0
		public static Vector128<double> HorizontalSubtract(Vector128<double> left, Vector128<double> right)
		{
			return Sse3.HorizontalSubtract(left, right);
		}

		// Token: 0x06006DC5 RID: 28101 RVA: 0x0010A4F9 File Offset: 0x001086F9
		public unsafe static Vector128<double> LoadAndDuplicateToVector128(double* address)
		{
			return Sse3.LoadAndDuplicateToVector128(address);
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x0010A501 File Offset: 0x00108701
		public unsafe static Vector128<sbyte> LoadDquVector128(sbyte* address)
		{
			return Sse3.LoadDquVector128(address);
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x0010A509 File Offset: 0x00108709
		public unsafe static Vector128<byte> LoadDquVector128(byte* address)
		{
			return Sse3.LoadDquVector128(address);
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x0010A511 File Offset: 0x00108711
		public unsafe static Vector128<short> LoadDquVector128(short* address)
		{
			return Sse3.LoadDquVector128(address);
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x0010A519 File Offset: 0x00108719
		public unsafe static Vector128<ushort> LoadDquVector128(ushort* address)
		{
			return Sse3.LoadDquVector128(address);
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x0010A521 File Offset: 0x00108721
		public unsafe static Vector128<int> LoadDquVector128(int* address)
		{
			return Sse3.LoadDquVector128(address);
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x0010A529 File Offset: 0x00108729
		public unsafe static Vector128<uint> LoadDquVector128(uint* address)
		{
			return Sse3.LoadDquVector128(address);
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x0010A531 File Offset: 0x00108731
		public unsafe static Vector128<long> LoadDquVector128(long* address)
		{
			return Sse3.LoadDquVector128(address);
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x0010A539 File Offset: 0x00108739
		public unsafe static Vector128<ulong> LoadDquVector128(ulong* address)
		{
			return Sse3.LoadDquVector128(address);
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x0010A541 File Offset: 0x00108741
		public static Vector128<double> MoveAndDuplicate(Vector128<double> source)
		{
			return Sse3.MoveAndDuplicate(source);
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x0010A549 File Offset: 0x00108749
		public static Vector128<float> MoveHighAndDuplicate(Vector128<float> source)
		{
			return Sse3.MoveHighAndDuplicate(source);
		}

		// Token: 0x06006DD0 RID: 28112 RVA: 0x0010A551 File Offset: 0x00108751
		public static Vector128<float> MoveLowAndDuplicate(Vector128<float> source)
		{
			return Sse3.MoveLowAndDuplicate(source);
		}

		// Token: 0x02000595 RID: 1429
		[Intrinsic]
		public new abstract class X64 : Sse2.X64
		{
			// Token: 0x17000DA2 RID: 3490
			// (get) Token: 0x06006DD1 RID: 28113 RVA: 0x0010A559 File Offset: 0x00108759
			public new static bool IsSupported
			{
				get
				{
					return Sse3.X64.IsSupported;
				}
			}
		}
	}
}
