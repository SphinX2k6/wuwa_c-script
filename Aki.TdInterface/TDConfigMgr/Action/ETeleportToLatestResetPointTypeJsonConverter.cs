using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002707 RID: 9991
	public class ETeleportToLatestResetPointTypeJsonConverter : JsonConverter<ETeleportToLatestResetPointType>
	{
		// Token: 0x0600D6FB RID: 55035 RVA: 0x001F650C File Offset: 0x001F470C
		public override ETeleportToLatestResetPointType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleportToLatestResetPointType.Directly;
			}
			return ETeleportToLatestResetPointTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D6FC RID: 55036 RVA: 0x001F6530 File Offset: 0x001F4730
		public override void Write(Utf8JsonWriter writer, ETeleportToLatestResetPointType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
