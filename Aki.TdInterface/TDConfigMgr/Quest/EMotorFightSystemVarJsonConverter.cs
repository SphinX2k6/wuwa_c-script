using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001399 RID: 5017
	public class EMotorFightSystemVarJsonConverter : JsonConverter<EMotorFightSystemVar>
	{
		// Token: 0x0600708C RID: 28812 RVA: 0x0010C724 File Offset: 0x0010A924
		public override EMotorFightSystemVar Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorFightSystemVar.LevelProgress;
			}
			return EMotorFightSystemVarExtensions.FromString(@string);
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x0010C748 File Offset: 0x0010A948
		public override void Write(Utf8JsonWriter writer, EMotorFightSystemVar value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
