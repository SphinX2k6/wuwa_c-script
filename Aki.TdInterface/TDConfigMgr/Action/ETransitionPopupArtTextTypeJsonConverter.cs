using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002482 RID: 9346
	public class ETransitionPopupArtTextTypeJsonConverter : JsonConverter<ETransitionPopupArtTextType>
	{
		// Token: 0x0600CAC9 RID: 51913 RVA: 0x001DD918 File Offset: 0x001DBB18
		public override ETransitionPopupArtTextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETransitionPopupArtTextType.YuanCheng;
			}
			return ETransitionPopupArtTextTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CACA RID: 51914 RVA: 0x001DD93C File Offset: 0x001DBB3C
		public override void Write(Utf8JsonWriter writer, ETransitionPopupArtTextType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
