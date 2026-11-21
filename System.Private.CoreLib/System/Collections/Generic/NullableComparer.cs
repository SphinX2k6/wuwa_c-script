using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009AB RID: 2475
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class NullableComparer<T> : Comparer<T?>, ISerializable where T : struct
	{
		// Token: 0x0600920F RID: 37391 RVA: 0x0016B02A File Offset: 0x0016922A
		public NullableComparer()
		{
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x0016B02A File Offset: 0x0016922A
		private NullableComparer(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x0016B032 File Offset: 0x00169232
		[NullableContext(1)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (!typeof(T).IsAssignableTo(typeof(IComparable<T>)))
			{
				info.SetType(typeof(ObjectComparer<T?>));
			}
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x0016B05F File Offset: 0x0016925F
		public override int Compare(T? x, T? y)
		{
			if (x != null)
			{
				if (y != null)
				{
					return Comparer<T>.Default.Compare(x.value, y.value);
				}
				return 1;
			}
			else
			{
				if (y != null)
				{
					return -1;
				}
				return 0;
			}
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x0016A8CE File Offset: 0x00168ACE
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && base.GetType() == obj.GetType();
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
