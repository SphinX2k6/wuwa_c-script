using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025EF RID: 9711
	public class ELiveDanmakuOperationTypeJsonConverter : JsonConverter<ELiveDanmakuOperationType>
	{
		// Token: 0x0600D20F RID: 53775 RVA: 0x001E8A4C File Offset: 0x001E6C4C
		public override ELiveDanmakuOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveDanmakuOperationType.Load;
			}
			return ELiveDanmakuOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D210 RID: 53776 RVA: 0x001E8A70 File Offset: 0x001E6C70
		public override void Write(Utf8JsonWriter writer, ELiveDanmakuOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
