using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x0200523F RID: 21055
	public class EPreWarmTxtJsonConverter : JsonConverter<EPreWarmTxt>
	{
		// Token: 0x06034615 RID: 214549 RVA: 0x00EA8710 File Offset: 0x00EA6910
		public override EPreWarmTxt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPreWarmTxt.RewardTxtUnFinish;
			}
			return EPreWarmTxtExtensions.FromString(@string);
		}

		// Token: 0x06034616 RID: 214550 RVA: 0x00EA8734 File Offset: 0x00EA6934
		public override void Write(Utf8JsonWriter writer, EPreWarmTxt value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
