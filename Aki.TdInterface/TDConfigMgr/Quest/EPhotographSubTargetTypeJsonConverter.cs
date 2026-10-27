using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001261 RID: 4705
	public class EPhotographSubTargetTypeJsonConverter : JsonConverter<EPhotographSubTargetType>
	{
		// Token: 0x06006A5D RID: 27229 RVA: 0x000FEED8 File Offset: 0x000FD0D8
		public override EPhotographSubTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhotographSubTargetType.SpecificRole;
			}
			return EPhotographSubTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x000FEEFC File Offset: 0x000FD0FC
		public override void Write(Utf8JsonWriter writer, EPhotographSubTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
