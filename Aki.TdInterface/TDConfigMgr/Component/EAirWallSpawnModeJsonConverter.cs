using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000996 RID: 2454
	public class EAirWallSpawnModeJsonConverter : JsonConverter<EAirWallSpawnMode>
	{
		// Token: 0x06003737 RID: 14135 RVA: 0x0008C268 File Offset: 0x0008A468
		public override EAirWallSpawnMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAirWallSpawnMode.Whole;
			}
			return EAirWallSpawnModeExtensions.FromString(@string);
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x0008C28C File Offset: 0x0008A48C
		public override void Write(Utf8JsonWriter writer, EAirWallSpawnMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
