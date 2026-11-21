using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Buffers
{
	// Token: 0x02000395 RID: 917
	internal sealed class SingleStringSearchValuesThreeChars<TValueLength, TCaseSensitivity> : StringSearchValuesBase where TValueLength : struct, StringSearchValuesHelper.IValueLength where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
	{
		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x000C9500 File Offset: 0x000C7700
		private static bool IgnoreCase
		{
			get
			{
				return typeof(TCaseSensitivity) != typeof(StringSearchValuesHelper.CaseSensitive);
			}
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x000C951C File Offset: 0x000C771C
		public SingleStringSearchValuesThreeChars(HashSet<string> uniqueValues, string value) : base(uniqueValues)
		{
			int num;
			int num2;
			CharacterFrequencyHelper.GetSingleStringMultiCharacterOffsets(value, SingleStringSearchValuesThreeChars<TValueLength, TCaseSensitivity>.IgnoreCase, out num, out num2);
			this._value = value;
			this._minusValueTailLength = (IntPtr)(-(IntPtr)(value.Length - 1));
			this._ch1 = (ushort)value[0];
			this._ch2 = (ushort)value[num];
			this._ch3 = (ushort)value[num2];
			if (SingleStringSearchValuesThreeChars<TValueLength, TCaseSensitivity>.IgnoreCase)
			{
				this._ch1 &= 65503;
				this._ch2 &= 65503;
				this._ch3 &= 65503;
			}
			this._ch2ByteOffset = (UIntPtr)((IntPtr)num * (IntPtr)2);
			this._ch3ByteOffset = (UIntPtr)((IntPtr)num2 * (IntPtr)2);
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x000C95D3 File Offset: 0x000C77D3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			return this.IndexOf(MemoryMarshal.GetReference<char>(span), span.Length);
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x000C95E8 File Offset: 0x000C77E8
		private unsafe int IndexOf(ref char searchSpace, int searchSpaceLength)
		{
			ref char searchSpaceStart = ref searchSpace;
			IntPtr intPtr = (IntPtr)searchSpaceLength + this._minusValueTailLength;
			if (Vector128.IsHardwareAccelerated && intPtr >= (IntPtr)Vector128<ushort>.Count)
			{
				UIntPtr ch2ByteOffset = this._ch2ByteOffset;
				UIntPtr ch3ByteOffset = this._ch3ByteOffset;
				if (false)
				{
				}
				if (false)
				{
				}
				Vector128<ushort> ch = Vector128.Create(this._ch1);
				Vector128<ushort> ch2 = Vector128.Create(this._ch2);
				Vector128<ushort> ch3 = Vector128.Create(this._ch3);
				ref char ptr = ref Unsafe.Add<char>(ref searchSpace, intPtr - (IntPtr)Vector128<ushort>.Count);
				for (;;)
				{
					Vector128<byte> comparisonResult = SingleStringSearchValuesThreeChars<TValueLength, TCaseSensitivity>.GetComparisonResult(ref searchSpace, ch2ByteOffset, ch3ByteOffset, ch, ch2, ch3);
					int result;
					if (comparisonResult != Vector128<byte>.Zero && this.TryMatch(ref searchSpaceStart, searchSpaceLength, ref searchSpace, comparisonResult.ExtractMostSignificantBits<byte>(), out result))
					{
						return result;
					}
					searchSpace = Unsafe.Add<char>(ref searchSpace, Vector128<ushort>.Count);
					if (Unsafe.IsAddressGreaterThan<char>(ref searchSpace, ref ptr))
					{
						if (Unsafe.AreSame<char>(ref searchSpace, Unsafe.Add<char>(ref ptr, Vector128<ushort>.Count)))
						{
							break;
						}
						searchSpace = ref ptr;
					}
				}
				return -1;
			}
			string value = this._value;
			char c = *value.GetRawStringData();
			for (IntPtr intPtr2 = (IntPtr)0; intPtr2 < intPtr; intPtr2++)
			{
				ref char ptr2 = ref Unsafe.Add<char>(ref searchSpace, intPtr2);
				if ((typeof(TCaseSensitivity) == typeof(StringSearchValuesHelper.CaseInsensitiveUnicode) || StringSearchValuesHelper.ICaseSensitivity.TransformInput(ptr2) == c) && StringSearchValuesHelper.ICaseSensitivity.Equals<TValueLength>(ref ptr2, value))
				{
					return (int)intPtr2;
				}
			}
			return -1;
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x000C9740 File Offset: 0x000C7940
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> GetComparisonResult(ref char searchSpace, UIntPtr ch2ByteOffset, UIntPtr ch3ByteOffset, Vector128<ushort> ch1, Vector128<ushort> ch2, Vector128<ushort> ch3)
		{
			if (typeof(TCaseSensitivity) == typeof(StringSearchValuesHelper.CaseSensitive))
			{
				Vector128<ushort> left = Vector128.Equals<ushort>(ch1, Vector128.LoadUnsafe(ref searchSpace));
				Vector128<ushort> right = Vector128.Equals<ushort>(ch2, Vector128.LoadUnsafe<byte>(Unsafe.As<char, byte>(ref searchSpace), ch2ByteOffset).AsUInt16<byte>());
				Vector128<ushort> right2 = Vector128.Equals<ushort>(ch3, Vector128.LoadUnsafe<byte>(Unsafe.As<char, byte>(ref searchSpace), ch3ByteOffset).AsUInt16<byte>());
				return (left & right & right2).AsByte<ushort>();
			}
			Vector128<ushort> right3 = Vector128.Create(65503);
			Vector128<ushort> left2 = Vector128.Equals<ushort>(ch1, Vector128.LoadUnsafe(ref searchSpace) & right3);
			Vector128<ushort> right4 = Vector128.Equals<ushort>(ch2, Vector128.LoadUnsafe<byte>(Unsafe.As<char, byte>(ref searchSpace), ch2ByteOffset).AsUInt16<byte>() & right3);
			Vector128<ushort> right5 = Vector128.Equals<ushort>(ch3, Vector128.LoadUnsafe<byte>(Unsafe.As<char, byte>(ref searchSpace), ch3ByteOffset).AsUInt16<byte>() & right3);
			return (left2 & right4 & right5).AsByte<ushort>();
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x000C9828 File Offset: 0x000C7A28
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool TryMatch(ref char searchSpaceStart, int searchSpaceLength, ref char searchSpace, uint mask, out int offsetFromStart)
		{
			char ptr;
			for (;;)
			{
				int num = BitOperations.TrailingZeroCount(mask);
				ptr = Unsafe.AddByteOffset<char>(ref searchSpace, (IntPtr)num);
				if ((typeof(TCaseSensitivity) == typeof(StringSearchValuesHelper.CaseSensitive) && !StringSearchValuesHelper.IValueLength.AtLeast4Chars) || StringSearchValuesHelper.ICaseSensitivity.Equals<TValueLength>(ref ptr, this._value))
				{
					break;
				}
				mask = BitOperations.ResetLowestSetBit(BitOperations.ResetLowestSetBit(mask));
				if (mask == 0U)
				{
					goto Block_1;
				}
			}
			offsetFromStart = (int)(Unsafe.ByteOffset<char>(ref searchSpaceStart, ref ptr) / (IntPtr)2);
			return true;
			Block_1:
			offsetFromStart = 0;
			return false;
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000C98A9 File Offset: 0x000C7AA9
		internal override bool ContainsCore(string value)
		{
			if (!base.HasUniqueValues)
			{
				return this._value.Equals(value, SingleStringSearchValuesThreeChars<TValueLength, TCaseSensitivity>.IgnoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
			}
			return base.ContainsCore(value);
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x000C98D2 File Offset: 0x000C7AD2
		internal override string[] GetValues()
		{
			if (!base.HasUniqueValues)
			{
				return new string[]
				{
					this._value
				};
			}
			return base.GetValues();
		}

		// Token: 0x04000CB8 RID: 3256
		private readonly string _value;

		// Token: 0x04000CB9 RID: 3257
		private readonly IntPtr _minusValueTailLength;

		// Token: 0x04000CBA RID: 3258
		private readonly UIntPtr _ch2ByteOffset;

		// Token: 0x04000CBB RID: 3259
		private readonly UIntPtr _ch3ByteOffset;

		// Token: 0x04000CBC RID: 3260
		private readonly ushort _ch1;

		// Token: 0x04000CBD RID: 3261
		private readonly ushort _ch2;

		// Token: 0x04000CBE RID: 3262
		private readonly ushort _ch3;
	}
}
