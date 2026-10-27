using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001267 RID: 4711
	public class EPlayerHitStatisticsTypeJsonConverter : JsonConverter<EPlayerHitStatisticsType>
	{
		// Token: 0x06006A78 RID: 27256 RVA: 0x000FF214 File Offset: 0x000FD414
		public override EPlayerHitStatisticsType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerHitStatisticsType.HitCount;
			}
			return EPlayerHitStatisticsTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x000FF238 File Offset: 0x000FD438
		public override void Write(Utf8JsonWriter writer, EPlayerHitStatisticsType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
