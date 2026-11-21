using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001395 RID: 5013
	public class ELogicProgramSpecialProcessJsonConverter : JsonConverter<ELogicProgramSpecialProcess>
	{
		// Token: 0x0600707A RID: 28794 RVA: 0x0010C414 File Offset: 0x0010A614
		public override ELogicProgramSpecialProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELogicProgramSpecialProcess.DisableURO;
			}
			return ELogicProgramSpecialProcessExtensions.FromString(@string);
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x0010C438 File Offset: 0x0010A638
		public override void Write(Utf8JsonWriter writer, ELogicProgramSpecialProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
