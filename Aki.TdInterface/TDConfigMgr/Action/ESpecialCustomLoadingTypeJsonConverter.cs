using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C3 RID: 9923
	public class ESpecialCustomLoadingTypeJsonConverter : JsonConverter<ESpecialCustomLoadingType>
	{
		// Token: 0x0600D5C9 RID: 54729 RVA: 0x001F10B0 File Offset: 0x001EF2B0
		public override ESpecialCustomLoadingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialCustomLoadingType.HonamiStory;
			}
			return ESpecialCustomLoadingTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D5CA RID: 54730 RVA: 0x001F10D4 File Offset: 0x001EF2D4
		public override void Write(Utf8JsonWriter writer, ESpecialCustomLoadingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
