using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200241E RID: 9246
	public class ESkillOperationTypeJsonConverter : JsonConverter<ESkillOperationType>
	{
		// Token: 0x0600C907 RID: 51463 RVA: 0x001D7110 File Offset: 0x001D5310
		public override ESkillOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkillOperationType.Enable;
			}
			return ESkillOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C908 RID: 51464 RVA: 0x001D7134 File Offset: 0x001D5334
		public override void Write(Utf8JsonWriter writer, ESkillOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
