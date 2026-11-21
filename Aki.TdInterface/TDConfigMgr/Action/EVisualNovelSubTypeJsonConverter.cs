using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200275F RID: 10079
	public class EVisualNovelSubTypeJsonConverter : JsonConverter<EVisualNovelSubType>
	{
		// Token: 0x0600D887 RID: 55431 RVA: 0x001FA3C4 File Offset: 0x001F85C4
		public override EVisualNovelSubType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelSubType.SolarSchool;
			}
			return EVisualNovelSubTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D888 RID: 55432 RVA: 0x001FA3E8 File Offset: 0x001F85E8
		public override void Write(Utf8JsonWriter writer, EVisualNovelSubType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
