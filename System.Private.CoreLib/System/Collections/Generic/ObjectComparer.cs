using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009AC RID: 2476
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class ObjectComparer<T> : Comparer<T>
	{
		// Token: 0x06009215 RID: 37397 RVA: 0x0016B098 File Offset: 0x00169298
		public override int Compare(T x, T y)
		{
			return Comparer.Default.Compare(x, y);
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x0016A8CE File Offset: 0x00168ACE
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && base.GetType() == obj.GetType();
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
