using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002695 RID: 9877
	public class ESceneInteractionOperationTypeJsonConverter : JsonConverter<ESceneInteractionOperationType>
	{
		// Token: 0x0600D4FA RID: 54522 RVA: 0x001EEE78 File Offset: 0x001ED078
		public override ESceneInteractionOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneInteractionOperationType.Enable;
			}
			return ESceneInteractionOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4FB RID: 54523 RVA: 0x001EEE9C File Offset: 0x001ED09C
		public override void Write(Utf8JsonWriter writer, ESceneInteractionOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
