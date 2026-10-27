using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A0 RID: 9376
	public class EVillageInfrBuildTypeJsonConverter : JsonConverter<EVillageInfrBuildType>
	{
		// Token: 0x0600CB50 RID: 52048 RVA: 0x001DEE08 File Offset: 0x001DD008
		public override EVillageInfrBuildType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVillageInfrBuildType.Village;
			}
			return EVillageInfrBuildTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB51 RID: 52049 RVA: 0x001DEE2C File Offset: 0x001DD02C
		public override void Write(Utf8JsonWriter writer, EVillageInfrBuildType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
