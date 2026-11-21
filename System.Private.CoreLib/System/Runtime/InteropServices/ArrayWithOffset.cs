using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005AA RID: 1450
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct ArrayWithOffset : IEquatable<ArrayWithOffset>
	{
		// Token: 0x06006FB8 RID: 28600 RVA: 0x0010D2CC File Offset: 0x0010B4CC
		public ArrayWithOffset(object array, int offset)
		{
			int num = 0;
			if (array != null)
			{
				Array array2 = array as Array;
				if (array2 == null || array2.Rank != 1 || !Marshal.IsPinnable(array2))
				{
					throw new ArgumentException(SR.ArgumentException_NotIsomorphic);
				}
				UIntPtr uintPtr = array2.NativeLength * (UIntPtr)((IntPtr)array2.GetElementSize());
				if (uintPtr > (UIntPtr)((IntPtr)2147483632))
				{
					throw new ArgumentException(SR.Argument_StructArrayTooLarge);
				}
				num = (int)uintPtr;
			}
			if (offset > num)
			{
				throw new IndexOutOfRangeException(SR.IndexOutOfRange_ArrayWithOffset);
			}
			this.m_array = array;
			this.m_offset = offset;
			this.m_count = num - offset;
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x0010D34E File Offset: 0x0010B54E
		public object GetArray()
		{
			return this.m_array;
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x0010D356 File Offset: 0x0010B556
		public int GetOffset()
		{
			return this.m_offset;
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x0010D35E File Offset: 0x0010B55E
		public override int GetHashCode()
		{
			return this.m_count + this.m_offset;
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x0010D370 File Offset: 0x0010B570
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ArrayWithOffset)
			{
				ArrayWithOffset obj2 = (ArrayWithOffset)obj;
				return this.Equals(obj2);
			}
			return false;
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x0010D395 File Offset: 0x0010B595
		public bool Equals(ArrayWithOffset obj)
		{
			return obj.m_array == this.m_array && obj.m_offset == this.m_offset && obj.m_count == this.m_count;
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x0010D3C3 File Offset: 0x0010B5C3
		public static bool operator ==(ArrayWithOffset a, ArrayWithOffset b)
		{
			return a.Equals(b);
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x0010D3CD File Offset: 0x0010B5CD
		public static bool operator !=(ArrayWithOffset a, ArrayWithOffset b)
		{
			return !(a == b);
		}

		// Token: 0x04001248 RID: 4680
		private readonly object m_array;

		// Token: 0x04001249 RID: 4681
		private readonly int m_offset;

		// Token: 0x0400124A RID: 4682
		private readonly int m_count;
	}
}
