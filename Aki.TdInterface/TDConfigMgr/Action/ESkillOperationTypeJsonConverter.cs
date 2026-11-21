using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026BD RID: 9917
	public class ESkillOperationTypeJsonConverter : JsonConverter<ESkillOperationType>
	{
		// Token: 0x0600D5AE RID: 54702 RVA: 0x001F0DE4 File Offset: 0x001EEFE4
		public override ESkillOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkillOperationType.Enable;
			}
			return ESkillOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D5AF RID: 54703 RVA: 0x001F0E08 File Offset: 0x001EF008
		public override void Write(Utf8JsonWriter writer, ESkillOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
