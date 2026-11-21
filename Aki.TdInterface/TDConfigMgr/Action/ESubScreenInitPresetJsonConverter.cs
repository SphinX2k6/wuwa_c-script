using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D7 RID: 9943
	public class ESubScreenInitPresetJsonConverter : JsonConverter<ESubScreenInitPreset>
	{
		// Token: 0x0600D623 RID: 54819 RVA: 0x001F1E54 File Offset: 0x001F0054
		public override ESubScreenInitPreset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubScreenInitPreset.Left;
			}
			return ESubScreenInitPresetExtensions.FromString(@string);
		}

		// Token: 0x0600D624 RID: 54820 RVA: 0x001F1E78 File Offset: 0x001F0078
		public override void Write(Utf8JsonWriter writer, ESubScreenInitPreset value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
