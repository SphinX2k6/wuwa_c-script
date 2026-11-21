using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F9 RID: 5113
	public class ETrapDefenseSystemVarTypeJsonConverter : JsonConverter<ETrapDefenseSystemVarType>
	{
		// Token: 0x0600723C RID: 29244 RVA: 0x001117BC File Offset: 0x0010F9BC
		public override ETrapDefenseSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrapDefenseSystemVarType.Health;
			}
			return ETrapDefenseSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x001117E0 File Offset: 0x0010F9E0
		public override void Write(Utf8JsonWriter writer, ETrapDefenseSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
