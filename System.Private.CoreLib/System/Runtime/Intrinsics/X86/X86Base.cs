using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000565 RID: 1381
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class X86Base
	{
		// Token: 0x060062D9 RID: 25305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void __cpuidex(int* cpuInfo, int functionId, int subFunctionId);

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x001094A5 File Offset: 0x001076A5
		public static bool IsSupported
		{
			get
			{
				return X86Base.IsSupported;
			}
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x001094AC File Offset: 0x001076AC
		internal static uint BitScanForward(uint value)
		{
			return X86Base.BitScanForward(value);
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x001094B4 File Offset: 0x001076B4
		internal static uint BitScanReverse(uint value)
		{
			return X86Base.BitScanReverse(value);
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x001094BC File Offset: 0x001076BC
		[return: TupleElementNames(new string[]
		{
			"Eax",
			"Ebx",
			"Ecx",
			"Edx"
		})]
		public unsafe static ValueTuple<int, int, int, int> CpuId(int functionId, int subFunctionId)
		{
			int* ptr = stackalloc int[(UIntPtr)16];
			X86Base.__cpuidex(ptr, functionId, subFunctionId);
			return new ValueTuple<int, int, int, int>(*ptr, ptr[1], ptr[2], ptr[3]);
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x001094F0 File Offset: 0x001076F0
		[Experimental("SYSLIB5004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<uint, uint> DivRem(uint lower, uint upper, uint divisor)
		{
			return X86Base.DivRem(lower, upper, divisor);
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x001094FA File Offset: 0x001076FA
		[Experimental("SYSLIB5004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<int, int> DivRem(uint lower, int upper, int divisor)
		{
			return X86Base.DivRem(lower, upper, divisor);
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x00109504 File Offset: 0x00107704
		[Experimental("SYSLIB5004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<UIntPtr, UIntPtr> DivRem(UIntPtr lower, UIntPtr upper, UIntPtr divisor)
		{
			return X86Base.DivRem(lower, upper, divisor);
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x0010950E File Offset: 0x0010770E
		[Experimental("SYSLIB5004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<IntPtr, IntPtr> DivRem(UIntPtr lower, IntPtr upper, IntPtr divisor)
		{
			return X86Base.DivRem(lower, upper, divisor);
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x00109518 File Offset: 0x00107718
		public static void Pause()
		{
			X86Base.Pause();
		}

		// Token: 0x02000566 RID: 1382
		[Intrinsic]
		public abstract class X64
		{
			// Token: 0x17000D75 RID: 3445
			// (get) Token: 0x060062E3 RID: 25315 RVA: 0x0010951F File Offset: 0x0010771F
			public static bool IsSupported
			{
				get
				{
					return X86Base.X64.IsSupported;
				}
			}

			// Token: 0x060062E4 RID: 25316 RVA: 0x00109526 File Offset: 0x00107726
			internal static ulong BitScanForward(ulong value)
			{
				return X86Base.X64.BitScanForward(value);
			}

			// Token: 0x060062E5 RID: 25317 RVA: 0x0010952E File Offset: 0x0010772E
			internal static ulong BitScanReverse(ulong value)
			{
				return X86Base.X64.BitScanReverse(value);
			}

			// Token: 0x060062E6 RID: 25318 RVA: 0x00109536 File Offset: 0x00107736
			[Experimental("SYSLIB5004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
			[return: TupleElementNames(new string[]
			{
				"Quotient",
				"Remainder"
			})]
			public static ValueTuple<ulong, ulong> DivRem(ulong lower, ulong upper, ulong divisor)
			{
				return X86Base.X64.DivRem(lower, upper, divisor);
			}

			// Token: 0x060062E7 RID: 25319 RVA: 0x00109540 File Offset: 0x00107740
			[Experimental("SYSLIB5004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
			[return: TupleElementNames(new string[]
			{
				"Quotient",
				"Remainder"
			})]
			public static ValueTuple<long, long> DivRem(ulong lower, long upper, long divisor)
			{
				return X86Base.X64.DivRem(lower, upper, divisor);
			}
		}
	}
}
