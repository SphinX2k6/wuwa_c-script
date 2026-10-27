using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001247 RID: 4679
	public class EGradingSystemVarTypeJsonConverter : JsonConverter<EGradingSystemVarType>
	{
		// Token: 0x060069E8 RID: 27112 RVA: 0x000FDB50 File Offset: 0x000FBD50
		public override EGradingSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGradingSystemVarType.Score;
			}
			return EGradingSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x000FDB74 File Offset: 0x000FBD74
		public override void Write(Utf8JsonWriter writer, EGradingSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
