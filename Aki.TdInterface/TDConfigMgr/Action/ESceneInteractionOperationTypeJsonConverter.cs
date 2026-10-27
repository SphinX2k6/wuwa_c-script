using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023FE RID: 9214
	public class ESceneInteractionOperationTypeJsonConverter : JsonConverter<ESceneInteractionOperationType>
	{
		// Token: 0x0600C877 RID: 51319 RVA: 0x001D56CC File Offset: 0x001D38CC
		public override ESceneInteractionOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneInteractionOperationType.Enable;
			}
			return ESceneInteractionOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C878 RID: 51320 RVA: 0x001D56F0 File Offset: 0x001D38F0
		public override void Write(Utf8JsonWriter writer, ESceneInteractionOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
