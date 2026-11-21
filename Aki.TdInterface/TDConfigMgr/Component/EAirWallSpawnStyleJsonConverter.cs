using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000998 RID: 2456
	public class EAirWallSpawnStyleJsonConverter : JsonConverter<EAirWallSpawnStyle>
	{
		// Token: 0x06003740 RID: 14144 RVA: 0x0008C37C File Offset: 0x0008A57C
		public override EAirWallSpawnStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAirWallSpawnStyle.AlongSpline;
			}
			return EAirWallSpawnStyleExtensions.FromString(@string);
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x0008C3A0 File Offset: 0x0008A5A0
		public override void Write(Utf8JsonWriter writer, EAirWallSpawnStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
