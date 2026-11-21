using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF8 RID: 2808
	public class ETeleCtrlTriggerTypeJsonConverter : JsonConverter<ETeleCtrlTriggerType>
	{
		// Token: 0x06003D70 RID: 15728 RVA: 0x0009D440 File Offset: 0x0009B640
		public override ETeleCtrlTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleCtrlTriggerType.MechascoutJavelin;
			}
			return ETeleCtrlTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x0009D464 File Offset: 0x0009B664
		public override void Write(Utf8JsonWriter writer, ETeleCtrlTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
