using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F8C RID: 24460
	public class EGuaranteeActionJsonConverter : JsonConverter<EGuaranteeAction>
	{
		// Token: 0x0603ACBE RID: 240830 RVA: 0x0109FB44 File Offset: 0x0109DD44
		public override EGuaranteeAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGuaranteeAction.EnablePlayerMoveControl;
			}
			return EGuaranteeActionExtensions.FromString(@string);
		}

		// Token: 0x0603ACBF RID: 240831 RVA: 0x0109FB68 File Offset: 0x0109DD68
		public override void Write(Utf8JsonWriter writer, EGuaranteeAction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
