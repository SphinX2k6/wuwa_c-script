using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F9 RID: 9721
	public class ELiveScOperationTypeJsonConverter : JsonConverter<ELiveScOperationType>
	{
		// Token: 0x0600D23C RID: 53820 RVA: 0x001E9098 File Offset: 0x001E7298
		public override ELiveScOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveScOperationType.Send;
			}
			return ELiveScOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D23D RID: 53821 RVA: 0x001E90BC File Offset: 0x001E72BC
		public override void Write(Utf8JsonWriter writer, ELiveScOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
