using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A47 RID: 2631
	public class EWuWaGoEntityTypeJsonConverter : JsonConverter<EWuWaGoEntityType>
	{
		// Token: 0x060039F2 RID: 14834 RVA: 0x000958A0 File Offset: 0x00093AA0
		public override EWuWaGoEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoEntityType.LevelCenter;
			}
			return EWuWaGoEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x000958C4 File Offset: 0x00093AC4
		public override void Write(Utf8JsonWriter writer, EWuWaGoEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
