using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001259 RID: 4697
	public class EMotorFightSystemVarJsonConverter : JsonConverter<EMotorFightSystemVar>
	{
		// Token: 0x06006A39 RID: 27193 RVA: 0x000FEAF8 File Offset: 0x000FCCF8
		public override EMotorFightSystemVar Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorFightSystemVar.LevelProgress;
			}
			return EMotorFightSystemVarExtensions.FromString(@string);
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x000FEB1C File Offset: 0x000FCD1C
		public override void Write(Utf8JsonWriter writer, EMotorFightSystemVar value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
