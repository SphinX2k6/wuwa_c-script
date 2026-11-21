using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009BA RID: 2490
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class ObjectEqualityComparer<T> : EqualityComparer<T>
	{
		// Token: 0x060092B0 RID: 37552 RVA: 0x0016D68A File Offset: 0x0016B88A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(T x, T y)
		{
			if (x != null)
			{
				return y != null && x.Equals(y);
			}
			return y == null;
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x0016D6C0 File Offset: 0x0016B8C0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode([DisallowNull] T obj)
		{
			ref T ptr = ref obj;
			T t = default(T);
			if (t == null)
			{
				t = obj;
				ptr = ref t;
				if (t == null)
				{
					return 0;
				}
			}
			return ptr.GetHashCode();
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x0016A8CE File Offset: 0x00168ACE
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && base.GetType() == obj.GetType();
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
