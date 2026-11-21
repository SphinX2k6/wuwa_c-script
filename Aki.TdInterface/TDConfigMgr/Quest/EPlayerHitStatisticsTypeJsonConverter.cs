using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A7 RID: 5031
	public class EPlayerHitStatisticsTypeJsonConverter : JsonConverter<EPlayerHitStatisticsType>
	{
		// Token: 0x060070CB RID: 28875 RVA: 0x0010CE40 File Offset: 0x0010B040
		public override EPlayerHitStatisticsType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerHitStatisticsType.HitCount;
			}
			return EPlayerHitStatisticsTypeExtensions.FromString(@string);
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x0010CE64 File Offset: 0x0010B064
		public override void Write(Utf8JsonWriter writer, EPlayerHitStatisticsType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
