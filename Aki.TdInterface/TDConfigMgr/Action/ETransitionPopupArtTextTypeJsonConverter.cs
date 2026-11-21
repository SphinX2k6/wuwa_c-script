using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002725 RID: 10021
	public class ETransitionPopupArtTextTypeJsonConverter : JsonConverter<ETransitionPopupArtTextType>
	{
		// Token: 0x0600D782 RID: 55170 RVA: 0x001F7AE0 File Offset: 0x001F5CE0
		public override ETransitionPopupArtTextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETransitionPopupArtTextType.YuanCheng;
			}
			return ETransitionPopupArtTextTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D783 RID: 55171 RVA: 0x001F7B04 File Offset: 0x001F5D04
		public override void Write(Utf8JsonWriter writer, ETransitionPopupArtTextType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
