using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A76 RID: 2678
	public class EPasserbyNpcExitTimingTypeJsonConverter : JsonConverter<EPasserbyNpcExitTimingType>
	{
		// Token: 0x06003B27 RID: 15143 RVA: 0x00098A4C File Offset: 0x00096C4C
		public override EPasserbyNpcExitTimingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcExitTimingType.LiftStop;
			}
			return EPasserbyNpcExitTimingTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00098A70 File Offset: 0x00096C70
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcExitTimingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
