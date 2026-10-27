using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DA RID: 8922
	public class ECharacterMoveToPointTypeJsonConverter : JsonConverter<ECharacterMoveToPointType>
	{
		// Token: 0x0600C355 RID: 50005 RVA: 0x001C8B0C File Offset: 0x001C6D0C
		public override ECharacterMoveToPointType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECharacterMoveToPointType.Walk;
			}
			return ECharacterMoveToPointTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C356 RID: 50006 RVA: 0x001C8B30 File Offset: 0x001C6D30
		public override void Write(Utf8JsonWriter writer, ECharacterMoveToPointType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
