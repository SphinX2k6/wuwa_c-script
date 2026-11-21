using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001379 RID: 4985
	public class EDistrubuteTypeJsonConverter : JsonConverter<EDistrubuteType>
	{
		// Token: 0x06006FFC RID: 28668 RVA: 0x0010AC48 File Offset: 0x00108E48
		public override EDistrubuteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDistrubuteType.Interact;
			}
			return EDistrubuteTypeExtensions.FromString(@string);
		}

		// Token: 0x06006FFD RID: 28669 RVA: 0x0010AC6C File Offset: 0x00108E6C
		public override void Write(Utf8JsonWriter writer, EDistrubuteType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
