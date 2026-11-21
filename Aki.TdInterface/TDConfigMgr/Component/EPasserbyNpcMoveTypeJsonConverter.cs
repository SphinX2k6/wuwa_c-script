using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A7C RID: 2684
	public class EPasserbyNpcMoveTypeJsonConverter : JsonConverter<EPasserbyNpcMoveType>
	{
		// Token: 0x06003B42 RID: 15170 RVA: 0x00098D18 File Offset: 0x00096F18
		public override EPasserbyNpcMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcMoveType.Spline;
			}
			return EPasserbyNpcMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00098D3C File Offset: 0x00096F3C
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
