using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200272B RID: 10027
	public class ETrapDefenseTipTypeJsonConverter : JsonConverter<ETrapDefenseTipType>
	{
		// Token: 0x0600D79D RID: 55197 RVA: 0x001F7E6C File Offset: 0x001F606C
		public override ETrapDefenseTipType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrapDefenseTipType.OpenNewAreaTip;
			}
			return ETrapDefenseTipTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D79E RID: 55198 RVA: 0x001F7E90 File Offset: 0x001F6090
		public override void Write(Utf8JsonWriter writer, ETrapDefenseTipType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
