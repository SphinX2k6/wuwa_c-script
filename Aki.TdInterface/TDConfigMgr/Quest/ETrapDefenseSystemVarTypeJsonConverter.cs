using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B3 RID: 4787
	public class ETrapDefenseSystemVarTypeJsonConverter : JsonConverter<ETrapDefenseSystemVarType>
	{
		// Token: 0x06006BCE RID: 27598 RVA: 0x001037F4 File Offset: 0x001019F4
		public override ETrapDefenseSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrapDefenseSystemVarType.Health;
			}
			return ETrapDefenseSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x00103818 File Offset: 0x00101A18
		public override void Write(Utf8JsonWriter writer, ETrapDefenseSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
