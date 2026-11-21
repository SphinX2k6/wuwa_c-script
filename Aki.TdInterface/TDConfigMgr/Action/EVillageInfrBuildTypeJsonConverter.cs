using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002743 RID: 10051
	public class EVillageInfrBuildTypeJsonConverter : JsonConverter<EVillageInfrBuildType>
	{
		// Token: 0x0600D809 RID: 55305 RVA: 0x001F8FD0 File Offset: 0x001F71D0
		public override EVillageInfrBuildType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVillageInfrBuildType.Village;
			}
			return EVillageInfrBuildTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x001F8FF4 File Offset: 0x001F71F4
		public override void Write(Utf8JsonWriter writer, EVillageInfrBuildType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
