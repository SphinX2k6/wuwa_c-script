using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009A5 RID: 2469
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class EnumEqualityComparer<T> : EqualityComparer<T>, ISerializable where T : struct, Enum
	{
		// Token: 0x060091F2 RID: 37362 RVA: 0x0016AB13 File Offset: 0x00168D13
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(T x, T y)
		{
			return JitHelpers.EnumEquals<T>(x, y);
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x0016AB1C File Offset: 0x00168D1C
		public EnumEqualityComparer()
		{
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x0016AB1C File Offset: 0x00168D1C
		private EnumEqualityComparer(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x0016AB24 File Offset: 0x00168D24
		[NullableContext(1)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (Type.GetTypeCode(typeof(T)) != TypeCode.Int32)
			{
				info.SetType(typeof(ObjectEqualityComparer<T>));
			}
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x0016AB49 File Offset: 0x00168D49
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x0016A8CE File Offset: 0x00168ACE
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && base.GetType() == obj.GetType();
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
