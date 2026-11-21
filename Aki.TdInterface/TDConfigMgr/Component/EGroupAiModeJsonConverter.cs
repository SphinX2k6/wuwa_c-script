using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A10 RID: 2576
	public class EGroupAiModeJsonConverter : JsonConverter<EGroupAiMode>
	{
		// Token: 0x0600395C RID: 14684 RVA: 0x00094344 File Offset: 0x00092544
		public override EGroupAiMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupAiMode.Default;
			}
			return EGroupAiModeExtensions.FromString(@string);
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x00094368 File Offset: 0x00092568
		public override void Write(Utf8JsonWriter writer, EGroupAiMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
