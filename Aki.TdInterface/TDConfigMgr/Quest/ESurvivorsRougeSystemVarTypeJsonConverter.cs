using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001299 RID: 4761
	public class ESurvivorsRougeSystemVarTypeJsonConverter : JsonConverter<ESurvivorsRougeSystemVarType>
	{
		// Token: 0x06006B59 RID: 27481 RVA: 0x00101F58 File Offset: 0x00100158
		public override ESurvivorsRougeSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESurvivorsRougeSystemVarType.Gold;
			}
			return ESurvivorsRougeSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x00101F7C File Offset: 0x0010017C
		public override void Write(Utf8JsonWriter writer, ESurvivorsRougeSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
