using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A27 RID: 2599
	public class ESwordRiderRailWallJsonConverter : JsonConverter<ESwordRiderRailWall>
	{
		// Token: 0x06003962 RID: 14690 RVA: 0x000943D0 File Offset: 0x000925D0
		public override ESwordRiderRailWall Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESwordRiderRailWall.Inner;
			}
			return ESwordRiderRailWallExtensions.FromString(@string);
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x000943F4 File Offset: 0x000925F4
		public override void Write(Utf8JsonWriter writer, ESwordRiderRailWall value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
