using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000F4 RID: 244
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public sealed class DBNull : ISerializable, IConvertible
	{
		// Token: 0x06000F0C RID: 3852 RVA: 0x00005ACC File Offset: 0x00003CCC
		private DBNull()
		{
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00028E42 File Offset: 0x00027042
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			UnitySerializationHolder.GetUnitySerializationInfo(info, 2);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00028E4B File Offset: 0x0002704B
		public override string ToString()
		{
			return string.Empty;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00028E4B File Offset: 0x0002704B
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return string.Empty;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public TypeCode GetTypeCode()
		{
			return TypeCode.DBNull;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00028E52 File Offset: 0x00027052
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00028E52 File Offset: 0x00027052
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00028E52 File Offset: 0x00027052
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00028E52 File Offset: 0x00027052
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00028E52 File Offset: 0x00027052
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00028E52 File Offset: 0x00027052
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00028E52 File Offset: 0x00027052
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00028E52 File Offset: 0x00027052
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00028E52 File Offset: 0x00027052
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00028E52 File Offset: 0x00027052
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00028E52 File Offset: 0x00027052
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00028E52 File Offset: 0x00027052
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00028E52 File Offset: 0x00027052
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00028E52 File Offset: 0x00027052
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.InvalidCast_FromDBNull);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0000E0EE File Offset: 0x0000C2EE
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x04000357 RID: 855
		public static readonly DBNull Value = new DBNull();
	}
}
