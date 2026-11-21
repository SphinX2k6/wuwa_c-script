using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002617 RID: 9751
	public class EMoraleUiTypeJsonConverter : JsonConverter<EMoraleUiType>
	{
		// Token: 0x0600D2C3 RID: 53955 RVA: 0x001EA2E0 File Offset: 0x001E84E0
		public override EMoraleUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoraleUiType.MoraleUi24;
			}
			return EMoraleUiTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2C4 RID: 53956 RVA: 0x001EA304 File Offset: 0x001E8504
		public override void Write(Utf8JsonWriter writer, EMoraleUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
