using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200238E RID: 9102
	public class EMoraleUiTypeJsonConverter : JsonConverter<EMoraleUiType>
	{
		// Token: 0x0600C67F RID: 50815 RVA: 0x001D130C File Offset: 0x001CF50C
		public override EMoraleUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoraleUiType.MoraleUi24;
			}
			return EMoraleUiTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C680 RID: 50816 RVA: 0x001D1330 File Offset: 0x001CF530
		public override void Write(Utf8JsonWriter writer, EMoraleUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
