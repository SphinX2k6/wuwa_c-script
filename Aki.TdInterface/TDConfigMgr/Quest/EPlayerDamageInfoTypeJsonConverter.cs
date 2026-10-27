using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001265 RID: 4709
	public class EPlayerDamageInfoTypeJsonConverter : JsonConverter<EPlayerDamageInfoType>
	{
		// Token: 0x06006A6F RID: 27247 RVA: 0x000FF100 File Offset: 0x000FD300
		public override EPlayerDamageInfoType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerDamageInfoType.DamagePoint;
			}
			return EPlayerDamageInfoTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x000FF124 File Offset: 0x000FD324
		public override void Write(Utf8JsonWriter writer, EPlayerDamageInfoType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
