using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BD RID: 2493
	public class EPasserbyNpcMoveTypeJsonConverter : JsonConverter<EPasserbyNpcMoveType>
	{
		// Token: 0x06003785 RID: 14213 RVA: 0x0009075C File Offset: 0x0008E95C
		public override EPasserbyNpcMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcMoveType.Spline;
			}
			return EPasserbyNpcMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00090780 File Offset: 0x0008E980
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
