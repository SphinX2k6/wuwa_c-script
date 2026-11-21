using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Buffers
{
	// Token: 0x02000393 RID: 915
	internal abstract class AsciiStringSearchValuesTeddyBase<TBucketized, TStartCaseSensitivity, TCaseSensitivity> : StringSearchValuesRabinKarp<TCaseSensitivity> where TBucketized : struct, SearchValues.IRuntimeConst where TStartCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
	{
		// Token: 0x06003C4D RID: 15437 RVA: 0x000C9014 File Offset: 0x000C7214
		protected AsciiStringSearchValuesTeddyBase(ReadOnlySpan<string> values, HashSet<string> uniqueValues, int n) : base(values, uniqueValues)
		{
			ReadOnlySpan<object>.CastUp<string>(values).CopyTo(<PrivateImplementationDetails>.InlineArrayAsSpan<EightObjects, object>(ref this._buckets, 8));
			ValueTuple<Vector512<byte>, Vector512<byte>> valueTuple = TeddyBucketizer.GenerateNonBucketizedFingerprint(values, 0);
			this._n0Low = valueTuple.Item1;
			this._n0High = valueTuple.Item2;
			valueTuple = TeddyBucketizer.GenerateNonBucketizedFingerprint(values, 1);
			this._n1Low = valueTuple.Item1;
			this._n1High = valueTuple.Item2;
			if (n == 3)
			{
				valueTuple = TeddyBucketizer.GenerateNonBucketizedFingerprint(values, 2);
				this._n2Low = valueTuple.Item1;
				this._n2High = valueTuple.Item2;
			}
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x000C90A8 File Offset: 0x000C72A8
		protected AsciiStringSearchValuesTeddyBase(string[][] buckets, ReadOnlySpan<string> values, HashSet<string> uniqueValues, int n) : base(values, uniqueValues)
		{
			buckets.CopyTo(<PrivateImplementationDetails>.InlineArrayAsSpan<EightObjects, object>(ref this._buckets, 8));
			ValueTuple<Vector512<byte>, Vector512<byte>> valueTuple = TeddyBucketizer.GenerateBucketizedFingerprint(buckets, 0);
			this._n0Low = valueTuple.Item1;
			this._n0High = valueTuple.Item2;
			valueTuple = TeddyBucketizer.GenerateBucketizedFingerprint(buckets, 1);
			this._n1Low = valueTuple.Item1;
			this._n1High = valueTuple.Item2;
			if (n == 3)
			{
				valueTuple = TeddyBucketizer.GenerateBucketizedFingerprint(buckets, 2);
				this._n2Low = valueTuple.Item1;
				this._n2High = valueTuple.Item2;
			}
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x000C913E File Offset: 0x000C733E
		protected int IndexOfAnyN2(ReadOnlySpan<char> span)
		{
			if (false)
			{
			}
			if (false)
			{
			}
			return this.IndexOfAnyN2Vector128(span);
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x000C914D File Offset: 0x000C734D
		protected int IndexOfAnyN3(ReadOnlySpan<char> span)
		{
			if (false)
			{
			}
			if (false)
			{
			}
			return this.IndexOfAnyN3Vector128(span);
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x000C915C File Offset: 0x000C735C
		private int IndexOfAnyN2Vector128(ReadOnlySpan<char> span)
		{
			if (span.Length < 17)
			{
				return base.ShortInputFallback(span);
			}
			ref char ptr = ref MemoryMarshal.GetReference<char>(span);
			ref char ptr2 = ref Unsafe.Add<char>(ref ptr, span.Length - 16);
			ptr = Unsafe.Add<char>(ref ptr, 1);
			Vector128<byte> lower = this._n0Low._lower._lower;
			Vector128<byte> lower2 = this._n0High._lower._lower;
			Vector128<byte> lower3 = this._n1Low._lower._lower;
			Vector128<byte> lower4 = this._n1High._lower._lower;
			Vector128<byte> prev = Vector128<byte>.AllBitsSet;
			for (;;)
			{
				ValueTuple<Vector128<byte>, Vector128<byte>> valueTuple = TeddyHelper.ProcessInputN2(StringSearchValuesHelper.ICaseSensitivity.TransformInput(TeddyHelper.LoadAndPack16AsciiChars(ref ptr)), prev, lower, lower2, lower3, lower4);
				Vector128<byte> item = valueTuple.Item1;
				prev = valueTuple.Item2;
				int result;
				if (item != Vector128<byte>.Zero && this.TryFindMatch(span, ref ptr, item, 1, out result))
				{
					return result;
				}
				ptr = Unsafe.Add<char>(ref ptr, 16);
				if (Unsafe.IsAddressGreaterThan<char>(ref ptr, ref ptr2))
				{
					if (Unsafe.AreSame<char>(ref ptr, Unsafe.Add<char>(ref ptr2, 16)))
					{
						break;
					}
					prev = Vector128<byte>.AllBitsSet;
					ptr = ref ptr2;
				}
			}
			return -1;
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x000C9264 File Offset: 0x000C7464
		private int IndexOfAnyN3Vector128(ReadOnlySpan<char> span)
		{
			if (span.Length < 18)
			{
				return base.ShortInputFallback(span);
			}
			ref char ptr = ref MemoryMarshal.GetReference<char>(span);
			ref char ptr2 = ref Unsafe.Add<char>(ref ptr, span.Length - 16);
			ptr = Unsafe.Add<char>(ref ptr, 2);
			Vector128<byte> lower = this._n0Low._lower._lower;
			Vector128<byte> lower2 = this._n0High._lower._lower;
			Vector128<byte> lower3 = this._n1Low._lower._lower;
			Vector128<byte> lower4 = this._n1High._lower._lower;
			Vector128<byte> lower5 = this._n2Low._lower._lower;
			Vector128<byte> lower6 = this._n2High._lower._lower;
			Vector128<byte> prev = Vector128<byte>.AllBitsSet;
			Vector128<byte> prev2 = Vector128<byte>.AllBitsSet;
			for (;;)
			{
				ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> valueTuple = TeddyHelper.ProcessInputN3(StringSearchValuesHelper.ICaseSensitivity.TransformInput(TeddyHelper.LoadAndPack16AsciiChars(ref ptr)), prev, prev2, lower, lower2, lower3, lower4, lower5, lower6);
				Vector128<byte> item = valueTuple.Item1;
				prev = valueTuple.Item2;
				prev2 = valueTuple.Item3;
				int result;
				if (item != Vector128<byte>.Zero && this.TryFindMatch(span, ref ptr, item, 2, out result))
				{
					return result;
				}
				ptr = Unsafe.Add<char>(ref ptr, 16);
				if (Unsafe.IsAddressGreaterThan<char>(ref ptr, ref ptr2))
				{
					if (Unsafe.AreSame<char>(ref ptr, Unsafe.Add<char>(ref ptr2, 16)))
					{
						break;
					}
					prev = Vector128<byte>.AllBitsSet;
					prev2 = Vector128<byte>.AllBitsSet;
					ptr = ref ptr2;
				}
			}
			return -1;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x000C93AC File Offset: 0x000C75AC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe bool TryFindMatch(ReadOnlySpan<char> span, ref char searchSpace, Vector128<byte> result, int matchStartOffset, out int offsetFromStart)
		{
			uint num = (~Vector128.Equals<byte>(result, Vector128<byte>.Zero)).ExtractMostSignificantBits<byte>();
			for (;;)
			{
				int num2 = BitOperations.TrailingZeroCount(num);
				ref char ptr = ref Unsafe.Add<char>(ref searchSpace, num2 - matchStartOffset);
				offsetFromStart = (int)(Unsafe.ByteOffset<char>(MemoryMarshal.GetReference<char>(span), ref ptr) / (IntPtr)2);
				int lengthRemaining = span.Length - offsetFromStart;
				uint num3 = (uint)result.GetElementUnsafe(num2);
				do
				{
					int index = BitOperations.TrailingZeroCount(num3);
					object o = *<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<EightObjects, object>(this._buckets, 8)[index];
					if (SearchValues.IRuntimeConst.Value ? StringSearchValuesHelper.StartsWith<TCaseSensitivity>(ref ptr, lengthRemaining, Unsafe.As<string[]>(o)) : StringSearchValuesHelper.StartsWith<TCaseSensitivity>(ref ptr, lengthRemaining, Unsafe.As<string>(o)))
					{
						return true;
					}
					num3 = BitOperations.ResetLowestSetBit(num3);
				}
				while (num3 != 0U);
				num = BitOperations.ResetLowestSetBit(num);
				if (num == 0U)
				{
					goto Block_4;
				}
			}
			return true;
			Block_4:
			offsetFromStart = 0;
			return false;
		}

		// Token: 0x04000CB0 RID: 3248
		private readonly EightObjects _buckets;

		// Token: 0x04000CB1 RID: 3249
		private readonly Vector512<byte> _n0Low;

		// Token: 0x04000CB2 RID: 3250
		private readonly Vector512<byte> _n0High;

		// Token: 0x04000CB3 RID: 3251
		private readonly Vector512<byte> _n1Low;

		// Token: 0x04000CB4 RID: 3252
		private readonly Vector512<byte> _n1High;

		// Token: 0x04000CB5 RID: 3253
		private readonly Vector512<byte> _n2Low;

		// Token: 0x04000CB6 RID: 3254
		private readonly Vector512<byte> _n2High;
	}
}
