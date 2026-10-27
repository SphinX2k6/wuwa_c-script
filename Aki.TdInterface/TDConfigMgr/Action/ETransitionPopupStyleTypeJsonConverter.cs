using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002484 RID: 9348
	public class ETransitionPopupStyleTypeJsonConverter : JsonConverter<ETransitionPopupStyleType>
	{
		// Token: 0x0600CAD2 RID: 51922 RVA: 0x001DDA70 File Offset: 0x001DBC70
		public override ETransitionPopupStyleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETransitionPopupStyleType.LeftTopTip;
			}
			return ETransitionPopupStyleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CAD3 RID: 51923 RVA: 0x001DDA94 File Offset: 0x001DBC94
		public override void Write(Utf8JsonWriter writer, ETransitionPopupStyleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
