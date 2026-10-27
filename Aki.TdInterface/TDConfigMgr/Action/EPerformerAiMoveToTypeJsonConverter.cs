using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BE RID: 9150
	public class EPerformerAiMoveToTypeJsonConverter : JsonConverter<EPerformerAiMoveToType>
	{
		// Token: 0x0600C757 RID: 51031 RVA: 0x001D2F30 File Offset: 0x001D1130
		public override EPerformerAiMoveToType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPerformerAiMoveToType.Position;
			}
			return EPerformerAiMoveToTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C758 RID: 51032 RVA: 0x001D2F54 File Offset: 0x001D1154
		public override void Write(Utf8JsonWriter writer, EPerformerAiMoveToType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
