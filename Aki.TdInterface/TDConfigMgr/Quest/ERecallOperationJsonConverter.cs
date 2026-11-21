using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013BB RID: 5051
	public class ERecallOperationJsonConverter : JsonConverter<ERecallOperation>
	{
		// Token: 0x06007125 RID: 28965 RVA: 0x0010DEFC File Offset: 0x0010C0FC
		public override ERecallOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERecallOperation.Include;
			}
			return ERecallOperationExtensions.FromString(@string);
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x0010DF20 File Offset: 0x0010C120
		public override void Write(Utf8JsonWriter writer, ERecallOperation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
