using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009B9 RID: 2489
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class NullableEqualityComparer<T> : EqualityComparer<T?>, ISerializable where T : struct
	{
		// Token: 0x060092A9 RID: 37545 RVA: 0x0016D60D File Offset: 0x0016B80D
		public NullableEqualityComparer()
		{
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x0016D60D File Offset: 0x0016B80D
		private NullableEqualityComparer(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x0016D615 File Offset: 0x0016B815
		[NullableContext(1)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (!typeof(T).IsAssignableTo(typeof(IEquatable<T>)))
			{
				info.SetType(typeof(ObjectEqualityComparer<T?>));
			}
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x0016D642 File Offset: 0x0016B842
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(T? x, T? y)
		{
			if (x != null)
			{
				return y != null && EqualityComparer<T>.Default.Equals(x.value, y.value);
			}
			return y == null;
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x0016D67B File Offset: 0x0016B87B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode(T? obj)
		{
			return obj.GetHashCode();
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x0016A8CE File Offset: 0x00168ACE
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && base.GetType() == obj.GetType();
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
