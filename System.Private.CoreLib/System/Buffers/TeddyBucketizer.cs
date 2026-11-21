using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace System.Buffers
{
	// Token: 0x0200038D RID: 909
	internal static class TeddyBucketizer
	{
		// Token: 0x06003C3B RID: 15419 RVA: 0x000C8C04 File Offset: 0x000C6E04
		[return: TupleElementNames(new string[]
		{
			"Low",
			"High"
		})]
		public unsafe static ValueTuple<Vector512<byte>, Vector512<byte>> GenerateNonBucketizedFingerprint(ReadOnlySpan<string> values, int offset)
		{
			Vector128<byte> value = default(Vector128<byte>);
			Vector128<byte> value2 = default(Vector128<byte>);
			for (int i = 0; i < values.Length; i++)
			{
				string text = *values[i];
				int num = 1 << i;
				char c = text[offset];
				int index = (int)(c & '\u000f');
				int index2 = (int)(c >> 4);
				value.SetElementUnsafe(index, (byte)((int)value.GetElementUnsafe(index) | num));
				value2.SetElementUnsafe(index2, (byte)((int)value2.GetElementUnsafe(index2) | num));
			}
			return new ValueTuple<Vector512<byte>, Vector512<byte>>(Vector512.Create<byte>(value), Vector512.Create<byte>(value2));
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x000C8C90 File Offset: 0x000C6E90
		[return: TupleElementNames(new string[]
		{
			"Low",
			"High"
		})]
		public static ValueTuple<Vector512<byte>, Vector512<byte>> GenerateBucketizedFingerprint(string[][] valueBuckets, int offset)
		{
			Vector128<byte> value = default(Vector128<byte>);
			Vector128<byte> value2 = default(Vector128<byte>);
			for (int i = 0; i < valueBuckets.Length; i++)
			{
				int num = 1 << i;
				string[] array = valueBuckets[i];
				for (int j = 0; j < array.Length; j++)
				{
					char c = array[j][offset];
					int index = (int)(c & '\u000f');
					int index2 = (int)(c >> 4);
					value.SetElementUnsafe(index, (byte)((int)value.GetElementUnsafe(index) | num));
					value2.SetElementUnsafe(index2, (byte)((int)value2.GetElementUnsafe(index2) | num));
				}
			}
			return new ValueTuple<Vector512<byte>, Vector512<byte>>(Vector512.Create<byte>(value), Vector512.Create<byte>(value2));
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x000C8D2C File Offset: 0x000C6F2C
		public unsafe static string[][] Bucketize(ReadOnlySpan<string> values, int bucketCount, int n)
		{
			Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)320], 80).Slice(0, values.Length);
			Dictionary<int, int> dictionary = new Dictionary<int, int>(bucketCount);
			int num = 0;
			for (int i = 0; i < values.Length; i++)
			{
				string text = *values[i];
				int num2 = 0;
				for (int j = 0; j < n; j++)
				{
					num2 = (num2 << 8 | (int)text[j]);
				}
				int num3;
				if (!dictionary.TryGetValue(num2, out num3))
				{
					num3 = num++ % bucketCount;
					dictionary.Add(num2, num3);
				}
				*span[i] = num3;
			}
			string[][] array = new string[bucketCount][];
			for (int k = 0; k < array.Length; k++)
			{
				string[] array2 = array[k] = new string[span.Count(k)];
				int num4 = 0;
				for (int l = 0; l < span.Length; l++)
				{
					if (*span[l] == k)
					{
						array2[num4++] = *values[l];
					}
				}
			}
			return array;
		}
	}
}
