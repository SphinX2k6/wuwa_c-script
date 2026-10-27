using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002376 RID: 9078
	public class ELogicProgramSpecialProcessJsonConverter : JsonConverter<ELogicProgramSpecialProcess>
	{
		// Token: 0x0600C613 RID: 50707 RVA: 0x001D0498 File Offset: 0x001CE698
		public override ELogicProgramSpecialProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELogicProgramSpecialProcess.ChangeTeamOptimization;
			}
			return ELogicProgramSpecialProcessExtensions.FromString(@string);
		}

		// Token: 0x0600C614 RID: 50708 RVA: 0x001D04BC File Offset: 0x001CE6BC
		public override void Write(Utf8JsonWriter writer, ELogicProgramSpecialProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
