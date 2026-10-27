using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200127B RID: 4731
	public class ERecallOperationJsonConverter : JsonConverter<ERecallOperation>
	{
		// Token: 0x06006AD2 RID: 27346 RVA: 0x001002D0 File Offset: 0x000FE4D0
		public override ERecallOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERecallOperation.Include;
			}
			return ERecallOperationExtensions.FromString(@string);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x001002F4 File Offset: 0x000FE4F4
		public override void Write(Utf8JsonWriter writer, ERecallOperation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
