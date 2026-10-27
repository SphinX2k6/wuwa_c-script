using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001239 RID: 4665
	public class EDistrubuteTypeJsonConverter : JsonConverter<EDistrubuteType>
	{
		// Token: 0x060069A9 RID: 27049 RVA: 0x000FD07C File Offset: 0x000FB27C
		public override EDistrubuteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDistrubuteType.Interact;
			}
			return EDistrubuteTypeExtensions.FromString(@string);
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x000FD0A0 File Offset: 0x000FB2A0
		public override void Write(Utf8JsonWriter writer, EDistrubuteType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
