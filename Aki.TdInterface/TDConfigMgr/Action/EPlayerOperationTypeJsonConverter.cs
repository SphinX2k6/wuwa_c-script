using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002669 RID: 9833
	public class EPlayerOperationTypeJsonConverter : JsonConverter<EPlayerOperationType>
	{
		// Token: 0x0600D434 RID: 54324 RVA: 0x001ED3A4 File Offset: 0x001EB5A4
		public override EPlayerOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerOperationType.EnableAll;
			}
			return EPlayerOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D435 RID: 54325 RVA: 0x001ED3C8 File Offset: 0x001EB5C8
		public override void Write(Utf8JsonWriter writer, EPlayerOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
