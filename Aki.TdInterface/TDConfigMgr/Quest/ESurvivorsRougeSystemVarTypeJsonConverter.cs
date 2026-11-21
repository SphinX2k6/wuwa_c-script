using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013DB RID: 5083
	public class ESurvivorsRougeSystemVarTypeJsonConverter : JsonConverter<ESurvivorsRougeSystemVarType>
	{
		// Token: 0x060071B5 RID: 29109 RVA: 0x0010FD30 File Offset: 0x0010DF30
		public override ESurvivorsRougeSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESurvivorsRougeSystemVarType.Gold;
			}
			return ESurvivorsRougeSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x0010FD54 File Offset: 0x0010DF54
		public override void Write(Utf8JsonWriter writer, ESurvivorsRougeSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
