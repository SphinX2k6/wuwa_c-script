using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022CC RID: 8908
	public class ECameraOperationTypeJsonConverter : JsonConverter<ECameraOperationType>
	{
		// Token: 0x0600C316 RID: 49942 RVA: 0x001C82B4 File Offset: 0x001C64B4
		public override ECameraOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECameraOperationType.Enable;
			}
			return ECameraOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C317 RID: 49943 RVA: 0x001C82D8 File Offset: 0x001C64D8
		public override void Write(Utf8JsonWriter writer, ECameraOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
