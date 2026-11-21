using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x0200051C RID: 1308
	[NullableContext(1)]
	[CLSCompliant(false)]
	[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public interface IFormatterConverter
	{
		// Token: 0x0600487C RID: 18556
		object Convert(object value, Type type);

		// Token: 0x0600487D RID: 18557
		object Convert(object value, TypeCode typeCode);

		// Token: 0x0600487E RID: 18558
		bool ToBoolean(object value);

		// Token: 0x0600487F RID: 18559
		char ToChar(object value);

		// Token: 0x06004880 RID: 18560
		sbyte ToSByte(object value);

		// Token: 0x06004881 RID: 18561
		byte ToByte(object value);

		// Token: 0x06004882 RID: 18562
		short ToInt16(object value);

		// Token: 0x06004883 RID: 18563
		ushort ToUInt16(object value);

		// Token: 0x06004884 RID: 18564
		int ToInt32(object value);

		// Token: 0x06004885 RID: 18565
		uint ToUInt32(object value);

		// Token: 0x06004886 RID: 18566
		long ToInt64(object value);

		// Token: 0x06004887 RID: 18567
		ulong ToUInt64(object value);

		// Token: 0x06004888 RID: 18568
		float ToSingle(object value);

		// Token: 0x06004889 RID: 18569
		double ToDouble(object value);

		// Token: 0x0600488A RID: 18570
		decimal ToDecimal(object value);

		// Token: 0x0600488B RID: 18571
		DateTime ToDateTime(object value);

		// Token: 0x0600488C RID: 18572
		[return: Nullable(2)]
		string ToString(object value);
	}
}
