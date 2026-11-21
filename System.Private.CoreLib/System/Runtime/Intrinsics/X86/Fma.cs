using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000588 RID: 1416
	[CLSCompliant(false)]
	public abstract class Fma : Avx
	{
		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06006BFE RID: 27646 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyAdd(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplyAdd(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> MultiplyAdd(Vector256<float> a, Vector256<float> b, Vector256<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> MultiplyAdd(Vector256<double> a, Vector256<double> b, Vector256<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C03 RID: 27651 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyAddScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplyAddScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyAddSubtract(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplyAddSubtract(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> MultiplyAddSubtract(Vector256<float> a, Vector256<float> b, Vector256<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> MultiplyAddSubtract(Vector256<double> a, Vector256<double> b, Vector256<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplySubtract(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplySubtract(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C0B RID: 27659 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> MultiplySubtract(Vector256<float> a, Vector256<float> b, Vector256<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C0C RID: 27660 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> MultiplySubtract(Vector256<double> a, Vector256<double> b, Vector256<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplySubtractScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplySubtractScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C0F RID: 27663 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplySubtractAdd(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplySubtractAdd(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> MultiplySubtractAdd(Vector256<float> a, Vector256<float> b, Vector256<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> MultiplySubtractAdd(Vector256<double> a, Vector256<double> b, Vector256<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyAddNegated(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplyAddNegated(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> MultiplyAddNegated(Vector256<float> a, Vector256<float> b, Vector256<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> MultiplyAddNegated(Vector256<double> a, Vector256<double> b, Vector256<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyAddNegatedScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplyAddNegatedScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplySubtractNegated(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplySubtractNegated(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> MultiplySubtractNegated(Vector256<float> a, Vector256<float> b, Vector256<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> MultiplySubtractNegated(Vector256<double> a, Vector256<double> b, Vector256<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C1D RID: 27677 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplySubtractNegatedScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006C1E RID: 27678 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplySubtractNegatedScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000589 RID: 1417
		public new abstract class X64 : Avx.X64
		{
			// Token: 0x17000D96 RID: 3478
			// (get) Token: 0x06006C1F RID: 27679 RVA: 0x00007B65 File Offset: 0x00005D65
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
