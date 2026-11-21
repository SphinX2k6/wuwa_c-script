using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200253B RID: 9531
	public class ECameraOperationTypeJsonConverter : JsonConverter<ECameraOperationType>
	{
		// Token: 0x0600CEE5 RID: 52965 RVA: 0x001E00BC File Offset: 0x001DE2BC
		public override ECameraOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECameraOperationType.Enable;
			}
			return ECameraOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CEE6 RID: 52966 RVA: 0x001E00E0 File Offset: 0x001DE2E0
		public override void Write(Utf8JsonWriter writer, ECameraOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
