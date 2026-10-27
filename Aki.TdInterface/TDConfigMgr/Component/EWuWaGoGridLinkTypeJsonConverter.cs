using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A49 RID: 2633
	public class EWuWaGoGridLinkTypeJsonConverter : JsonConverter<EWuWaGoGridLinkType>
	{
		// Token: 0x060039FB RID: 14843 RVA: 0x00095A84 File Offset: 0x00093C84
		public override EWuWaGoGridLinkType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoGridLinkType.EmptyGrid;
			}
			return EWuWaGoGridLinkTypeExtensions.FromString(@string);
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00095AA8 File Offset: 0x00093CA8
		public override void Write(Utf8JsonWriter writer, EWuWaGoGridLinkType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
