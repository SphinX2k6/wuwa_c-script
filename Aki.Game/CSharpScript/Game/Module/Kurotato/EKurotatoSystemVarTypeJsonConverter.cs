using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x0200571C RID: 22300
	public class EKurotatoSystemVarTypeJsonConverter : JsonConverter<EKurotatoSystemVarType>
	{
		// Token: 0x06038B26 RID: 232230 RVA: 0x00D7394C File Offset: 0x00D71B4C
		public override EKurotatoSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EKurotatoSystemVarType.Gold;
			}
			return EKurotatoSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06038B27 RID: 232231 RVA: 0x00D73970 File Offset: 0x00D71B70
		public override void Write(Utf8JsonWriter writer, EKurotatoSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
