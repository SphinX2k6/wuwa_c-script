using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AEC RID: 2796
	public class ESwordRiderRailWallJsonConverter : JsonConverter<ESwordRiderRailWall>
	{
		// Token: 0x06003D3A RID: 15674 RVA: 0x0009CD04 File Offset: 0x0009AF04
		public override ESwordRiderRailWall Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESwordRiderRailWall.Inner;
			}
			return ESwordRiderRailWallExtensions.FromString(@string);
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x0009CD28 File Offset: 0x0009AF28
		public override void Write(Utf8JsonWriter writer, ESwordRiderRailWall value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
