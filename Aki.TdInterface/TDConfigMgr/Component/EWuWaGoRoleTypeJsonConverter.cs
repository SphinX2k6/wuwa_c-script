using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4F RID: 2639
	public class EWuWaGoRoleTypeJsonConverter : JsonConverter<EWuWaGoRoleType>
	{
		// Token: 0x06003A16 RID: 14870 RVA: 0x00095E78 File Offset: 0x00094078
		public override EWuWaGoRoleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoRoleType.AircraftSoldiers;
			}
			return EWuWaGoRoleTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00095E9C File Offset: 0x0009409C
		public override void Write(Utf8JsonWriter writer, EWuWaGoRoleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
