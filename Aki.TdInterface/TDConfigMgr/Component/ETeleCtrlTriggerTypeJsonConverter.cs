using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A33 RID: 2611
	public class ETeleCtrlTriggerTypeJsonConverter : JsonConverter<ETeleCtrlTriggerType>
	{
		// Token: 0x06003998 RID: 14744 RVA: 0x00094B0C File Offset: 0x00092D0C
		public override ETeleCtrlTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleCtrlTriggerType.MechascoutJavelin;
			}
			return ETeleCtrlTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x00094B30 File Offset: 0x00092D30
		public override void Write(Utf8JsonWriter writer, ETeleCtrlTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
