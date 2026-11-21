using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x0200035C RID: 860
	internal struct ProbabilisticMapState
	{
		// Token: 0x06003B23 RID: 15139 RVA: 0x000C4B64 File Offset: 0x000C2D64
		public unsafe ProbabilisticMapState(ReadOnlySpan<char> values, int maxInclusive)
		{
			this._slowContainsValuesPtr = default(ReadOnlySpan<char>*);
			this.Map = new ProbabilisticMap(values);
			uint num = ProbabilisticMapState.FindModulus(values, maxInclusive);
			this._multiplier = ProbabilisticMapState.GetFastModMultiplier(num);
			this._hashEntries = new char[num];
			this._hashEntries.AsSpan<char>().Fill((char)(*values[0]));
			ReadOnlySpan<char> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				char c = (char)(*readOnlySpan[i]);
				this._hashEntries[(int)(checked((IntPtr)ProbabilisticMapState.FastMod(c, num, this._multiplier)))] = c;
			}
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x000C4BFC File Offset: 0x000C2DFC
		public unsafe ProbabilisticMapState(ReadOnlySpan<char>* valuesPtr)
		{
			this._multiplier = 0U;
			this._hashEntries = null;
			this.Map = new ProbabilisticMap(*valuesPtr);
			this._slowContainsValuesPtr = valuesPtr;
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x000C4C24 File Offset: 0x000C2E24
		public char[] GetValues()
		{
			HashSet<char> hashSet = new HashSet<char>(this._hashEntries);
			char[] array = new char[hashSet.Count];
			hashSet.CopyTo(array);
			return array;
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x000C4C4F File Offset: 0x000C2E4F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool FastContains(char value)
		{
			return ProbabilisticMapState.FastContains(this._hashEntries, this._multiplier, value);
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x000C4C64 File Offset: 0x000C2E64
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool FastContains(char[] hashEntries, uint multiplier, char value)
		{
			ulong num = ProbabilisticMapState.FastMod(value, (uint)hashEntries.Length, multiplier);
			return *Unsafe.Add<char>(MemoryMarshal.GetArrayDataReference<char>(hashEntries), (UIntPtr)num) == value;
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x000C4C8D File Offset: 0x000C2E8D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe bool SlowProbabilisticContains(char value)
		{
			return ProbabilisticMap.Contains(Unsafe.As<ProbabilisticMap, uint>(ref this.Map), *this._slowContainsValuesPtr, (int)value);
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x000C4CAB File Offset: 0x000C2EAB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe bool SlowContains(char value)
		{
			return ProbabilisticMap.Contains(*this._slowContainsValuesPtr, value);
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x000C4CBE File Offset: 0x000C2EBE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool ConfirmProbabilisticMatch<TUseFastContains>(char value) where TUseFastContains : struct, SearchValues.IRuntimeConst
		{
			if (SearchValues.IRuntimeConst.Value)
			{
				return this.FastContains(value);
			}
			return this.SlowContains(value);
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x000C4CDC File Offset: 0x000C2EDC
		private static uint FindModulus(ReadOnlySpan<char> values, int maxInclusive)
		{
			int prime = HashHelpers.GetPrime(values.Length);
			bool flag = false;
			if (prime >= maxInclusive)
			{
				return (uint)(maxInclusive + 1);
			}
			for (;;)
			{
				if (prime >= maxInclusive)
				{
					char[] array;
					if (flag || !ProbabilisticMapState.<FindModulus>g__TryRemoveDuplicates|13_1(values, out array))
					{
						break;
					}
					flag = true;
					values = array;
					prime = HashHelpers.GetPrime(values.Length);
				}
				else
				{
					if (ProbabilisticMapState.<FindModulus>g__TestModulus|13_0(values, prime))
					{
						return (uint)prime;
					}
					prime = HashHelpers.GetPrime(prime + 1);
				}
			}
			return (uint)(maxInclusive + 1);
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x000C4D43 File Offset: 0x000C2F43
		private static uint GetFastModMultiplier(uint divisor)
		{
			return uint.MaxValue / divisor + 1U;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x000C4D4A File Offset: 0x000C2F4A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong FastMod(char value, uint divisor, uint multiplier)
		{
			return (ulong)(multiplier * (uint)value) * (ulong)divisor >> 32;
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x000C4D58 File Offset: 0x000C2F58
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnySimpleLoop<TUseFastContains, TNegator>(ref char searchSpace, int searchSpaceLength, ref ProbabilisticMapState state) where TUseFastContains : struct, SearchValues.IRuntimeConst where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			ref char right = ref Unsafe.Add<char>(ref searchSpace, searchSpaceLength);
			ref char ptr = ref searchSpace;
			if (SearchValues.IRuntimeConst.Value)
			{
				char[] hashEntries = state._hashEntries;
				uint multiplier = state._multiplier;
				while (!Unsafe.AreSame<char>(ref ptr, ref right))
				{
					char value = ptr;
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(ProbabilisticMapState.FastContains(hashEntries, multiplier, value)))
					{
						return (int)(Unsafe.ByteOffset<char>(ref searchSpace, ref ptr) / (IntPtr)2);
					}
					ptr = Unsafe.Add<char>(ref ptr, 1);
				}
			}
			else
			{
				while (!Unsafe.AreSame<char>(ref ptr, ref right))
				{
					char value2 = ptr;
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(state.SlowProbabilisticContains(value2)))
					{
						return (int)(Unsafe.ByteOffset<char>(ref searchSpace, ref ptr) / (IntPtr)2);
					}
					ptr = Unsafe.Add<char>(ref ptr, 1);
				}
			}
			return -1;
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x000C4DFC File Offset: 0x000C2FFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int LastIndexOfAnySimpleLoop<TUseFastContains, TNegator>(ref char searchSpace, int searchSpaceLength, ref ProbabilisticMapState state) where TUseFastContains : struct, SearchValues.IRuntimeConst where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			if (SearchValues.IRuntimeConst.Value)
			{
				char[] hashEntries = state._hashEntries;
				uint multiplier = state._multiplier;
				while (--searchSpaceLength >= 0)
				{
					char value = *Unsafe.Add<char>(ref searchSpace, searchSpaceLength);
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(ProbabilisticMapState.FastContains(hashEntries, multiplier, value)))
					{
						break;
					}
				}
			}
			else
			{
				while (--searchSpaceLength >= 0)
				{
					char value2 = *Unsafe.Add<char>(ref searchSpace, searchSpaceLength);
					if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(state.SlowProbabilisticContains(value2)))
					{
						break;
					}
				}
			}
			return searchSpaceLength;
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x000C4E78 File Offset: 0x000C3078
		[CompilerGenerated]
		internal unsafe static bool <FindModulus>g__TestModulus|13_0(ReadOnlySpan<char> values, int modulus)
		{
			bool[] array = ArrayPool<bool>.Shared.Rent(modulus);
			array.AsSpan(0, modulus).Clear();
			uint fastModMultiplier = ProbabilisticMapState.GetFastModMultiplier((uint)modulus);
			ReadOnlySpan<char> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				ulong num = ProbabilisticMapState.FastMod((char)(*readOnlySpan[i]), (uint)modulus, fastModMultiplier);
				checked
				{
					if (array[(int)((IntPtr)num)])
					{
						ArrayPool<bool>.Shared.Return(array, false);
						return false;
					}
					array[(int)((IntPtr)num)] = true;
				}
			}
			ArrayPool<bool>.Shared.Return(array, false);
			return true;
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x000C4EFC File Offset: 0x000C30FC
		[CompilerGenerated]
		internal static bool <FindModulus>g__TryRemoveDuplicates|13_1(ReadOnlySpan<char> values, [NotNullWhen(true)] out char[] deduplicated)
		{
			HashSet<char> hashSet = new HashSet<char>();
			foreach (char ptr in values)
			{
				char item = (char)ptr;
				hashSet.Add(item);
			}
			HashSet<char> hashSet2 = hashSet;
			if (hashSet2.Count == values.Length)
			{
				deduplicated = null;
				return false;
			}
			deduplicated = new char[hashSet2.Count];
			hashSet2.CopyTo(deduplicated);
			return true;
		}

		// Token: 0x04000C75 RID: 3189
		public ProbabilisticMap Map;

		// Token: 0x04000C76 RID: 3190
		private readonly uint _multiplier;

		// Token: 0x04000C77 RID: 3191
		private readonly char[] _hashEntries;

		// Token: 0x04000C78 RID: 3192
		private unsafe readonly ReadOnlySpan<char>* _slowContainsValuesPtr;
	}
}
