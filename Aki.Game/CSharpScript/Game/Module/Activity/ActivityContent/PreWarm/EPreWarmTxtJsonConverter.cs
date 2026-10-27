using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x020062C1 RID: 25281
	public class EPreWarmTxtJsonConverter : JsonConverter<EPreWarmTxt>
	{
		// Token: 0x0603F954 RID: 260436 RVA: 0x00F617B4 File Offset: 0x00F5F9B4
		public override EPreWarmTxt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPreWarmTxt.RewardTxtUnFinish;
			}
			return EPreWarmTxtExtensions.FromString(@string);
		}

		// Token: 0x0603F955 RID: 260437 RVA: 0x00F617D8 File Offset: 0x00F5F9D8
		public override void Write(Utf8JsonWriter writer, EPreWarmTxt value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
