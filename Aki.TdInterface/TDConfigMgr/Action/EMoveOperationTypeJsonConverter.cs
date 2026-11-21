using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002629 RID: 9769
	public class EMoveOperationTypeJsonConverter : JsonConverter<EMoveOperationType>
	{
		// Token: 0x0600D314 RID: 54036 RVA: 0x001EAD58 File Offset: 0x001E8F58
		public override EMoveOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveOperationType.Enable;
			}
			return EMoveOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D315 RID: 54037 RVA: 0x001EAD7C File Offset: 0x001E8F7C
		public override void Write(Utf8JsonWriter writer, EMoveOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
