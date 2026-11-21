using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x0200000A RID: 10
	internal static class HashHelpers
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00003BBB File Offset: 0x00001DBB
		internal static ReadOnlySpan<int> Primes
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.74BCD6ED20AF2231F2BB1CDE814C5F4FF48E54BAC46029EEF90DDF4A208E2B204).FieldHandle);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public static bool IsPrime(int candidate)
		{
			if ((candidate & 1) != 0)
			{
				int num = (int)Math.Sqrt((double)candidate);
				for (int i = 3; i <= num; i += 2)
				{
					if (candidate % i == 0)
					{
						return false;
					}
				}
				return true;
			}
			return candidate == 2;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003BFC File Offset: 0x00001DFC
		public unsafe static int GetPrime(int min)
		{
			if (min < 0)
			{
				throw new ArgumentException(SR.Arg_HTCapacityOverflow);
			}
			ReadOnlySpan<int> primes = HashHelpers.Primes;
			for (int i = 0; i < primes.Length; i++)
			{
				int num = *primes[i];
				if (num >= min)
				{
					return num;
				}
			}
			for (int j = min | 1; j < 2147483647; j += 2)
			{
				if (HashHelpers.IsPrime(j) && (j - 1) % 101 != 0)
				{
					return j;
				}
			}
			return min;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003C68 File Offset: 0x00001E68
		public static int ExpandPrime(int oldSize)
		{
			int num = 2 * oldSize;
			if (num > 2147483587 && 2147483587 > oldSize)
			{
				return 2147483587;
			}
			return HashHelpers.GetPrime(num);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003C95 File Offset: 0x00001E95
		public static ulong GetFastModMultiplier(uint divisor)
		{
			return ulong.MaxValue / (ulong)divisor + 1UL;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003C9F File Offset: 0x00001E9F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint FastMod(uint value, uint divisor, ulong multiplier)
		{
			return (uint)(((multiplier * (ulong)value >> 32) + 1UL) * (ulong)divisor >> 32);
		}
	}
}
