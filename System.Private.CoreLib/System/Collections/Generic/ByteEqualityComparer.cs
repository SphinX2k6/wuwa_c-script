using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009BB RID: 2491
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class ByteEqualityComparer : EqualityComparer<byte>
	{
		// Token: 0x060092B5 RID: 37557 RVA: 0x0016D6FD File Offset: 0x0016B8FD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(byte x, byte y)
		{
			return x == y;
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x0016D703 File Offset: 0x0016B903
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode(byte b)
		{
			return b.GetHashCode();
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x0016A8CE File Offset: 0x00168ACE
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && base.GetType() == obj.GetType();
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
