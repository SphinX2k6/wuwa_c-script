using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E0C RID: 28172
	public class EGuaranteeActionJsonConverter : JsonConverter<EGuaranteeAction>
	{
		// Token: 0x06044B58 RID: 281432 RVA: 0x010F5784 File Offset: 0x010F3984
		public override EGuaranteeAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGuaranteeAction.EnablePlayerMoveControl;
			}
			return EGuaranteeActionExtensions.FromString(@string);
		}

		// Token: 0x06044B59 RID: 281433 RVA: 0x010F57A8 File Offset: 0x010F39A8
		public override void Write(Utf8JsonWriter writer, EGuaranteeAction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
