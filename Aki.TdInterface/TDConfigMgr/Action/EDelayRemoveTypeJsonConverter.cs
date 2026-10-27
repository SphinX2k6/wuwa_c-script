using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FA RID: 8954
	public class EDelayRemoveTypeJsonConverter : JsonConverter<EDelayRemoveType>
	{
		// Token: 0x0600C3E5 RID: 50149 RVA: 0x001C9C38 File Offset: 0x001C7E38
		public override EDelayRemoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDelayRemoveType.DelayRemoveAfterSkillFinish;
			}
			return EDelayRemoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C3E6 RID: 50150 RVA: 0x001C9C5C File Offset: 0x001C7E5C
		public override void Write(Utf8JsonWriter writer, EDelayRemoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
