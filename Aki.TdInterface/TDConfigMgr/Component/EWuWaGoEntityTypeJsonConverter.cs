using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B10 RID: 2832
	public class EWuWaGoEntityTypeJsonConverter : JsonConverter<EWuWaGoEntityType>
	{
		// Token: 0x06003DDC RID: 15836 RVA: 0x0009E470 File Offset: 0x0009C670
		public override EWuWaGoEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoEntityType.LevelCenter;
			}
			return EWuWaGoEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x0009E494 File Offset: 0x0009C694
		public override void Write(Utf8JsonWriter writer, EWuWaGoEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
