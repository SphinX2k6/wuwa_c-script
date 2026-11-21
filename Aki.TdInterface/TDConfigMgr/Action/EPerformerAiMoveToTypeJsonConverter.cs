using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002651 RID: 9809
	public class EPerformerAiMoveToTypeJsonConverter : JsonConverter<EPerformerAiMoveToType>
	{
		// Token: 0x0600D3C8 RID: 54216 RVA: 0x001EC4EC File Offset: 0x001EA6EC
		public override EPerformerAiMoveToType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPerformerAiMoveToType.Position;
			}
			return EPerformerAiMoveToTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3C9 RID: 54217 RVA: 0x001EC510 File Offset: 0x001EA710
		public override void Write(Utf8JsonWriter writer, EPerformerAiMoveToType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
