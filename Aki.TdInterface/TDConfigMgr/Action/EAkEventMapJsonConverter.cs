using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229E RID: 8862
	public class EAkEventMapJsonConverter : JsonConverter<EAkEventMap>
	{
		// Token: 0x0600C247 RID: 49735 RVA: 0x001C6314 File Offset: 0x001C4514
		public override EAkEventMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAkEventMap.PlayMapMusic;
			}
			return EAkEventMapExtensions.FromString(@string);
		}

		// Token: 0x0600C248 RID: 49736 RVA: 0x001C6338 File Offset: 0x001C4538
		public override void Write(Utf8JsonWriter writer, EAkEventMap value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
