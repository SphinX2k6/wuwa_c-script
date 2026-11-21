using System;
using System.Collections.Generic;

namespace System.Collections.ObjectModel
{
	// Token: 0x02000987 RID: 2439
	internal static class CollectionHelpers
	{
		// Token: 0x060090E8 RID: 37096 RVA: 0x0016663C File Offset: 0x0016483C
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

		// Token: 0x060090E9 RID: 37097 RVA: 0x001666B8 File Offset: 0x001648B8
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
