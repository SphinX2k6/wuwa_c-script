using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200250B RID: 9483
	public class EAkEventMapJsonConverter : JsonConverter<EAkEventMap>
	{
		// Token: 0x0600CE0D RID: 52749 RVA: 0x001DE008 File Offset: 0x001DC208
		public override EAkEventMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAkEventMap.PlayMapMusic;
			}
			return EAkEventMapExtensions.FromString(@string);
		}

		// Token: 0x0600CE0E RID: 52750 RVA: 0x001DE02C File Offset: 0x001DC22C
		public override void Write(Utf8JsonWriter writer, EAkEventMap value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
