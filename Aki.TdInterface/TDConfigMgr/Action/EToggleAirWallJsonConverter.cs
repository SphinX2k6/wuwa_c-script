using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002478 RID: 9336
	public class EToggleAirWallJsonConverter : JsonConverter<EToggleAirWall>
	{
		// Token: 0x0600CA9C RID: 51868 RVA: 0x001DD348 File Offset: 0x001DB548
		public override EToggleAirWall Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EToggleAirWall.Open;
			}
			return EToggleAirWallExtensions.FromString(@string);
		}

		// Token: 0x0600CA9D RID: 51869 RVA: 0x001DD36C File Offset: 0x001DB56C
		public override void Write(Utf8JsonWriter writer, EToggleAirWall value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
