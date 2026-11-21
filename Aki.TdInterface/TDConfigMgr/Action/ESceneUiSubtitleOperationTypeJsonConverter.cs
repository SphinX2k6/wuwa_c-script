using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002697 RID: 9879
	public class ESceneUiSubtitleOperationTypeJsonConverter : JsonConverter<ESceneUiSubtitleOperationType>
	{
		// Token: 0x0600D503 RID: 54531 RVA: 0x001EEF8C File Offset: 0x001ED18C
		public override ESceneUiSubtitleOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneUiSubtitleOperationType.Spawn;
			}
			return ESceneUiSubtitleOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D504 RID: 54532 RVA: 0x001EEFB0 File Offset: 0x001ED1B0
		public override void Write(Utf8JsonWriter writer, ESceneUiSubtitleOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
