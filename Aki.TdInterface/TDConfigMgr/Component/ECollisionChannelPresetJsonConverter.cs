using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B8 RID: 2488
	public class ECollisionChannelPresetJsonConverter : JsonConverter<ECollisionChannelPreset>
	{
		// Token: 0x060037D0 RID: 14288 RVA: 0x0008D6E4 File Offset: 0x0008B8E4
		public override ECollisionChannelPreset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECollisionChannelPreset.CanBePassedThrough;
			}
			return ECollisionChannelPresetExtensions.FromString(@string);
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x0008D708 File Offset: 0x0008B908
		public override void Write(Utf8JsonWriter writer, ECollisionChannelPreset value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
