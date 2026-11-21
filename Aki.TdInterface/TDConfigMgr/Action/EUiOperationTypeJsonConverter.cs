using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002735 RID: 10037
	public class EUiOperationTypeJsonConverter : JsonConverter<EUiOperationType>
	{
		// Token: 0x0600D7CA RID: 55242 RVA: 0x001F8794 File Offset: 0x001F6994
		public override EUiOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUiOperationType.Enable;
			}
			return EUiOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D7CB RID: 55243 RVA: 0x001F87B8 File Offset: 0x001F69B8
		public override void Write(Utf8JsonWriter writer, EUiOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
