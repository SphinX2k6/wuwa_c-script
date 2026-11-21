using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002719 RID: 10009
	public class EToggleAirWallJsonConverter : JsonConverter<EToggleAirWall>
	{
		// Token: 0x0600D74C RID: 55116 RVA: 0x001F73FC File Offset: 0x001F55FC
		public override EToggleAirWall Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EToggleAirWall.Open;
			}
			return EToggleAirWallExtensions.FromString(@string);
		}

		// Token: 0x0600D74D RID: 55117 RVA: 0x001F7420 File Offset: 0x001F5620
		public override void Write(Utf8JsonWriter writer, EToggleAirWall value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
