using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001255 RID: 4693
	public class ELogicProgramSpecialProcessJsonConverter : JsonConverter<ELogicProgramSpecialProcess>
	{
		// Token: 0x06006A27 RID: 27175 RVA: 0x000FE7E8 File Offset: 0x000FC9E8
		public override ELogicProgramSpecialProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELogicProgramSpecialProcess.DisableURO;
			}
			return ELogicProgramSpecialProcessExtensions.FromString(@string);
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x000FE80C File Offset: 0x000FCA0C
		public override void Write(Utf8JsonWriter writer, ELogicProgramSpecialProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
