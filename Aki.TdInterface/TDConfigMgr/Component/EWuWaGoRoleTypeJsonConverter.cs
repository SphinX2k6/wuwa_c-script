using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B18 RID: 2840
	public class EWuWaGoRoleTypeJsonConverter : JsonConverter<EWuWaGoRoleType>
	{
		// Token: 0x06003E00 RID: 15872 RVA: 0x0009EA48 File Offset: 0x0009CC48
		public override EWuWaGoRoleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoRoleType.AircraftSoldiers;
			}
			return EWuWaGoRoleTypeExtensions.FromString(@string);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x0009EA6C File Offset: 0x0009CC6C
		public override void Write(Utf8JsonWriter writer, EWuWaGoRoleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
