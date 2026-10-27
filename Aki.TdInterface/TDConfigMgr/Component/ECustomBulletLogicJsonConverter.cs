using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091D RID: 2333
	public class ECustomBulletLogicJsonConverter : JsonConverter<ECustomBulletLogic>
	{
		// Token: 0x060034B5 RID: 13493 RVA: 0x00089E74 File Offset: 0x00088074
		public override ECustomBulletLogic Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECustomBulletLogic.TrafficBullet;
			}
			return ECustomBulletLogicExtensions.FromString(@string);
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00089E98 File Offset: 0x00088098
		public override void Write(Utf8JsonWriter writer, ECustomBulletLogic value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
