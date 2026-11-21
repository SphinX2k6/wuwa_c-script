using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D3 RID: 5075
	public class ESpecialProcessJsonConverter : JsonConverter<ESpecialProcess>
	{
		// Token: 0x06007191 RID: 29073 RVA: 0x0010F394 File Offset: 0x0010D594
		public override ESpecialProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialProcess.LowMemorySceneSwitch;
			}
			return ESpecialProcessExtensions.FromString(@string);
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x0010F3B8 File Offset: 0x0010D5B8
		public override void Write(Utf8JsonWriter writer, ESpecialProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
