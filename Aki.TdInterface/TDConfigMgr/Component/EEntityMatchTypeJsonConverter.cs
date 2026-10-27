using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093B RID: 2363
	public class EEntityMatchTypeJsonConverter : JsonConverter<EEntityMatchType>
	{
		// Token: 0x0600353C RID: 13628 RVA: 0x0008AF6C File Offset: 0x0008916C
		public override EEntityMatchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityMatchType.Player;
			}
			return EEntityMatchTypeExtensions.FromString(@string);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x0008AF90 File Offset: 0x00089190
		public override void Write(Utf8JsonWriter writer, EEntityMatchType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
