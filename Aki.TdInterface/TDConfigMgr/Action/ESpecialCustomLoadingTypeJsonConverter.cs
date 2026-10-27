using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002424 RID: 9252
	public class ESpecialCustomLoadingTypeJsonConverter : JsonConverter<ESpecialCustomLoadingType>
	{
		// Token: 0x0600C922 RID: 51490 RVA: 0x001D73DC File Offset: 0x001D55DC
		public override ESpecialCustomLoadingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialCustomLoadingType.HonamiStory;
			}
			return ESpecialCustomLoadingTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C923 RID: 51491 RVA: 0x001D7400 File Offset: 0x001D5600
		public override void Write(Utf8JsonWriter writer, ESpecialCustomLoadingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
