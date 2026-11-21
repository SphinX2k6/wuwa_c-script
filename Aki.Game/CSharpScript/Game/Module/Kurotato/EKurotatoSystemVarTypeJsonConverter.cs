using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046F3 RID: 18163
	public class EKurotatoSystemVarTypeJsonConverter : JsonConverter<EKurotatoSystemVarType>
	{
		// Token: 0x0602DA35 RID: 186933 RVA: 0x00CC1F2C File Offset: 0x00CC012C
		public override EKurotatoSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EKurotatoSystemVarType.Gold;
			}
			return EKurotatoSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x0602DA36 RID: 186934 RVA: 0x00CC1F50 File Offset: 0x00CC0150
		public override void Write(Utf8JsonWriter writer, EKurotatoSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
