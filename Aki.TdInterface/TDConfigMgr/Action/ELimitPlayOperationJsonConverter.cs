using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E7 RID: 9703
	public class ELimitPlayOperationJsonConverter : JsonConverter<ELimitPlayOperation>
	{
		// Token: 0x0600D1EB RID: 53739 RVA: 0x001E8588 File Offset: 0x001E6788
		public override ELimitPlayOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELimitPlayOperation.AllowCamera;
			}
			return ELimitPlayOperationExtensions.FromString(@string);
		}

		// Token: 0x0600D1EC RID: 53740 RVA: 0x001E85AC File Offset: 0x001E67AC
		public override void Write(Utf8JsonWriter writer, ELimitPlayOperation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
