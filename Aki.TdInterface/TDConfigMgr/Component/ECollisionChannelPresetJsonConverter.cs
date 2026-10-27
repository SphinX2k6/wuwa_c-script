using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090B RID: 2315
	public class ECollisionChannelPresetJsonConverter : JsonConverter<ECollisionChannelPreset>
	{
		// Token: 0x06003464 RID: 13412 RVA: 0x00085BD8 File Offset: 0x00083DD8
		public override ECollisionChannelPreset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECollisionChannelPreset.CanBePassedThrough;
			}
			return ECollisionChannelPresetExtensions.FromString(@string);
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00085BFC File Offset: 0x00083DFC
		public override void Write(Utf8JsonWriter writer, ECollisionChannelPreset value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
