using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000A7 RID: 167
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public abstract class ValueType
	{
		// Token: 0x060008AD RID: 2221 RVA: 0x0001BF78 File Offset: 0x0001A178
		internal static bool DefaultEquals(object o1, object o2)
		{
			RuntimeType left = (RuntimeType)o1.GetType();
			RuntimeType right = (RuntimeType)o2.GetType();
			if (left != right)
			{
				return false;
			}
			object[] array;
			bool result = ValueType.InternalEquals(o1, o2, out array);
			if (array == null)
			{
				return result;
			}
			for (int i = 0; i < array.Length; i += 2)
			{
				object obj = array[i];
				object obj2 = array[i + 1];
				if (obj == null)
				{
					if (obj2 != null)
					{
						return false;
					}
				}
				else if (!obj.Equals(obj2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0001BFE7 File Offset: 0x0001A1E7
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && ValueType.DefaultEquals(this, obj);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
		public override int GetHashCode()
		{
			object[] array;
			int num = ValueType.InternalGetHashCode(this, out array);
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null)
					{
						num ^= array[i].GetHashCode();
					}
				}
			}
			return num;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0000FF1D File Offset: 0x0000E11D
		public override string ToString()
		{
			return base.GetType().ToString();
		}

		// Token: 0x060008B1 RID: 2225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int InternalGetHashCode(object o, out object[] fields);

		// Token: 0x060008B2 RID: 2226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalEquals(object o1, object o2, out object[] fields);
	}
}
