using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200013E RID: 318
	[NullableContext(2)]
	[CLSCompliant(false)]
	public interface IConvertible
	{
		// Token: 0x060013BF RID: 5055
		TypeCode GetTypeCode();

		// Token: 0x060013C0 RID: 5056
		bool ToBoolean(IFormatProvider provider);

		// Token: 0x060013C1 RID: 5057
		char ToChar(IFormatProvider provider);

		// Token: 0x060013C2 RID: 5058
		sbyte ToSByte(IFormatProvider provider);

		// Token: 0x060013C3 RID: 5059
		byte ToByte(IFormatProvider provider);

		// Token: 0x060013C4 RID: 5060
		short ToInt16(IFormatProvider provider);

		// Token: 0x060013C5 RID: 5061
		ushort ToUInt16(IFormatProvider provider);

		// Token: 0x060013C6 RID: 5062
		int ToInt32(IFormatProvider provider);

		// Token: 0x060013C7 RID: 5063
		uint ToUInt32(IFormatProvider provider);

		// Token: 0x060013C8 RID: 5064
		long ToInt64(IFormatProvider provider);

		// Token: 0x060013C9 RID: 5065
		ulong ToUInt64(IFormatProvider provider);

		// Token: 0x060013CA RID: 5066
		float ToSingle(IFormatProvider provider);

		// Token: 0x060013CB RID: 5067
		double ToDouble(IFormatProvider provider);

		// Token: 0x060013CC RID: 5068
		decimal ToDecimal(IFormatProvider provider);

		// Token: 0x060013CD RID: 5069
		DateTime ToDateTime(IFormatProvider provider);

		// Token: 0x060013CE RID: 5070
		[NullableContext(1)]
		string ToString([Nullable(2)] IFormatProvider provider);

		// Token: 0x060013CF RID: 5071
		[NullableContext(1)]
		object ToType(Type conversionType, [Nullable(2)] IFormatProvider provider);
	}
}
