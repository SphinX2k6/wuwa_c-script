using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009B8 RID: 2488
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class GenericEqualityComparer<[Nullable(0)] T> : EqualityComparer<T> where T : IEquatable<T>
	{
		// Token: 0x060092A4 RID: 37540 RVA: 0x0016D5C6 File Offset: 0x0016B7C6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(T x, T y)
		{
			if (x != null)
			{
				return y != null && x.Equals(y);
			}
			return y == null;
		}

		// Token: 0x060092A5 RID: 37541 RVA: 0x0016D5F4 File Offset: 0x0016B7F4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode([DisallowNull] T obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x060092A6 RID: 37542 RVA: 0x0016A8CE File Offset: 0x00168ACE
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && base.GetType() == obj.GetType();
		}

		// Token: 0x060092A7 RID: 37543 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
