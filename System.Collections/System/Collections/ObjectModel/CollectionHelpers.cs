using System;
using System.Collections.Generic;

namespace System.Collections.ObjectModel
{
	// Token: 0x0200000B RID: 11
	internal static class CollectionHelpers
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00003CB4 File Offset: 0x00001EB4
		internal static void ValidateCopyToArguments(int sourceCount, Array array, int index)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (array.Rank != 1)
			{
				throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
			}
			if (array.GetLowerBound(0) != 0)
			{
				throw new ArgumentException(SR.Arg_NonZeroLowerBound, "array");
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(index, array.Length, "index");
			if (array.Length - index < sourceCount)
			{
				throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003D30 File Offset: 0x00001F30
		internal static void CopyTo<T>(ICollection<T> collection, Array array, int index)
		{
			CollectionHelpers.ValidateCopyToArguments(collection.Count, array, index);
			ICollection collection2 = collection as ICollection;
			if (collection2 != null)
			{
				collection2.CopyTo(array, index);
				return;
			}
			T[] array2 = array as T[];
			if (array2 != null)
			{
				collection.CopyTo(array2, index);
				return;
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
			try
			{
				foreach (T t in collection)
				{
					array3[index++] = t;
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
		}
	}
}
