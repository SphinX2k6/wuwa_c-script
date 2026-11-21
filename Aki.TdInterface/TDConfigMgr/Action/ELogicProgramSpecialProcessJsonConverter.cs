using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025FF RID: 9727
	public class ELogicProgramSpecialProcessJsonConverter : JsonConverter<ELogicProgramSpecialProcess>
	{
		// Token: 0x0600D257 RID: 53847 RVA: 0x001E946C File Offset: 0x001E766C
		public override ELogicProgramSpecialProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELogicProgramSpecialProcess.ChangeTeamOptimization;
			}
			return ELogicProgramSpecialProcessExtensions.FromString(@string);
		}

		// Token: 0x0600D258 RID: 53848 RVA: 0x001E9490 File Offset: 0x001E7690
		public override void Write(Utf8JsonWriter writer, ELogicProgramSpecialProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
