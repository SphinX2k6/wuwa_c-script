using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CA RID: 2506
	public class ECustomBulletLogicJsonConverter : JsonConverter<ECustomBulletLogic>
	{
		// Token: 0x06003821 RID: 14369 RVA: 0x000919F4 File Offset: 0x0008FBF4
		public override ECustomBulletLogic Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECustomBulletLogic.TrafficBullet;
			}
			return ECustomBulletLogicExtensions.FromString(@string);
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00091A18 File Offset: 0x0008FC18
		public override void Write(Utf8JsonWriter writer, ECustomBulletLogic value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
