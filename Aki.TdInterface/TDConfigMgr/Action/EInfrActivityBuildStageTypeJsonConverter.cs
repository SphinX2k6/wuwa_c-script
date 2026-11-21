using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D1 RID: 9681
	public class EInfrActivityBuildStageTypeJsonConverter : JsonConverter<EInfrActivityBuildStageType>
	{
		// Token: 0x0600D188 RID: 53640 RVA: 0x001E59E4 File Offset: 0x001E3BE4
		public override EInfrActivityBuildStageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInfrActivityBuildStageType.Infrastructure;
			}
			return EInfrActivityBuildStageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D189 RID: 53641 RVA: 0x001E5A08 File Offset: 0x001E3C08
		public override void Write(Utf8JsonWriter writer, EInfrActivityBuildStageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
