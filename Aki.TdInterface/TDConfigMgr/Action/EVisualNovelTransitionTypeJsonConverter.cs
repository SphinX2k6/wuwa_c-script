using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002761 RID: 10081
	public class EVisualNovelTransitionTypeJsonConverter : JsonConverter<EVisualNovelTransitionType>
	{
		// Token: 0x0600D890 RID: 55440 RVA: 0x001FA4D8 File Offset: 0x001F86D8
		public override EVisualNovelTransitionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelTransitionType.Location;
			}
			return EVisualNovelTransitionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D891 RID: 55441 RVA: 0x001FA4FC File Offset: 0x001F86FC
		public override void Write(Utf8JsonWriter writer, EVisualNovelTransitionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
