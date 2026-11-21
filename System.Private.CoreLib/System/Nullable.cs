using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x0200008D RID: 141
	[NonVersionable]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public struct Nullable<T> where T : struct
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x000116E2 File Offset: 0x0000F8E2
		private static object Box(T? o)
		{
			if (!o.hasValue)
			{
				return null;
			}
			return o.value;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000116FC File Offset: 0x0000F8FC
		private static T? Unbox(object o)
		{
			if (o == null)
			{
				return null;
			}
			return new T?((T)((object)o));
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00011724 File Offset: 0x0000F924
		private static T? UnboxExact(object o)
		{
			if (o == null)
			{
				return null;
			}
			if (o.GetType() != typeof(T))
			{
				throw new InvalidCastException();
			}
			return new T?((T)((object)o));
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00011766 File Offset: 0x0000F966
		[NonVersionable]
		public Nullable(T value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00011776 File Offset: 0x0000F976
		public readonly bool HasValue
		{
			[NonVersionable]
			get
			{
				return this.hasValue;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001177E File Offset: 0x0000F97E
		public readonly T Value
		{
			get
			{
				if (!this.hasValue)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue();
				}
				return this.value;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00011793 File Offset: 0x0000F993
		[NonVersionable]
		public readonly T GetValueOrDefault()
		{
			return this.value;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0001179B File Offset: 0x0000F99B
		[NonVersionable]
		public readonly T GetValueOrDefault(T defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000117AD File Offset: 0x0000F9AD
		[NullableContext(2)]
		public override bool Equals(object other)
		{
			if (!this.hasValue)
			{
				return other == null;
			}
			return other != null && this.value.Equals(other);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000117D3 File Offset: 0x0000F9D3
		public override int GetHashCode()
		{
			if (!this.hasValue)
			{
				return 0;
			}
			return this.value.GetHashCode();
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[NullableContext(2)]
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString();
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00011811 File Offset: 0x0000FA11
		[NonVersionable]
		public static implicit operator T?(T value)
		{
			return new T?(value);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00011819 File Offset: 0x0000FA19
		[NonVersionable]
		public static explicit operator T(T? value)
		{
			return value.Value;
		}

		// Token: 0x0400026E RID: 622
		private readonly bool hasValue;

		// Token: 0x0400026F RID: 623
		internal T value;
	}
}
