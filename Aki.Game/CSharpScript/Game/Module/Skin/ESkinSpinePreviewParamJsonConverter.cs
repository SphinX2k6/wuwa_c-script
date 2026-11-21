using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B94 RID: 15252
	public class ESkinSpinePreviewParamJsonConverter : JsonConverter<ESkinSpinePreviewParam>
	{
		// Token: 0x06027164 RID: 160100 RVA: 0x00AEFB3C File Offset: 0x00AEDD3C
		public override ESkinSpinePreviewParam Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkinSpinePreviewParam.ReboundTime;
			}
			return ESkinSpinePreviewParamExtensions.FromString(@string);
		}

		// Token: 0x06027165 RID: 160101 RVA: 0x00AEFB60 File Offset: 0x00AEDD60
		public override void Write(Utf8JsonWriter writer, ESkinSpinePreviewParam value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
