using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002436 RID: 9270
	public class ESubScreenInitPresetJsonConverter : JsonConverter<ESubScreenInitPreset>
	{
		// Token: 0x0600C973 RID: 51571 RVA: 0x001D7F8C File Offset: 0x001D618C
		public override ESubScreenInitPreset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubScreenInitPreset.Left;
			}
			return ESubScreenInitPresetExtensions.FromString(@string);
		}

		// Token: 0x0600C974 RID: 51572 RVA: 0x001D7FB0 File Offset: 0x001D61B0
		public override void Write(Utf8JsonWriter writer, ESubScreenInitPreset value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
