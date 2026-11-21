using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Collections
{
	// Token: 0x0200096D RID: 2413
	internal static class HashHelpers
	{
		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x0600900C RID: 36876 RVA: 0x00163F72 File Offset: 0x00162172
		internal static ReadOnlySpan<int> Primes
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.74BCD6ED20AF2231F2BB1CDE814C5F4FF48E54BAC46029EEF90DDF4A208E2B204).FieldHandle);
			}
		}

		// Token: 0x0600900D RID: 36877 RVA: 0x00163F80 File Offset: 0x00162180
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

		// Token: 0x0600900E RID: 36878 RVA: 0x00163FB4 File Offset: 0x001621B4
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

		// Token: 0x0600900F RID: 36879 RVA: 0x00164020 File Offset: 0x00162220
		public static int ExpandPrime(int oldSize)
		{
			int num = 2 * oldSize;
			if (num > 2147483587 && 2147483587 > oldSize)
			{
				return 2147483587;
			}
			return HashHelpers.GetPrime(num);
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0016404D File Offset: 0x0016224D
		public static ulong GetFastModMultiplier(uint divisor)
		{
			return ulong.MaxValue / (ulong)divisor + 1UL;
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x00164057 File Offset: 0x00162257
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint FastMod(uint value, uint divisor, ulong multiplier)
		{
			return (uint)(((multiplier * (ulong)value >> 32) + 1UL) * (ulong)divisor >> 32);
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06009012 RID: 36882 RVA: 0x0016406A File Offset: 0x0016226A
		public static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable
		{
			get
			{
				if (HashHelpers.s_serializationInfoTable == null)
				{
					Interlocked.CompareExchange<ConditionalWeakTable<object, SerializationInfo>>(ref HashHelpers.s_serializationInfoTable, new ConditionalWeakTable<object, SerializationInfo>(), null);
				}
				return HashHelpers.s_serializationInfoTable;
			}
		}

		// Token: 0x040021F7 RID: 8695
		private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable;
	}
}
