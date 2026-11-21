using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AFC RID: 2812
	public class EThrowMotionJsonConverter : JsonConverter<EThrowMotion>
	{
		// Token: 0x06003D82 RID: 15746 RVA: 0x0009D70C File Offset: 0x0009B90C
		public override EThrowMotion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EThrowMotion.Projectile;
			}
			return EThrowMotionExtensions.FromString(@string);
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x0009D730 File Offset: 0x0009B930
		public override void Write(Utf8JsonWriter writer, EThrowMotion value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
