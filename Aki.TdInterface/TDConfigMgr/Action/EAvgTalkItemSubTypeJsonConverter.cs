using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B2 RID: 8882
	public class EAvgTalkItemSubTypeJsonConverter : JsonConverter<EAvgTalkItemSubType>
	{
		// Token: 0x0600C2A1 RID: 49825 RVA: 0x001C7134 File Offset: 0x001C5334
		public override EAvgTalkItemSubType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgTalkItemSubType.Dialog;
			}
			return EAvgTalkItemSubTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C2A2 RID: 49826 RVA: 0x001C7158 File Offset: 0x001C5358
		public override void Write(Utf8JsonWriter writer, EAvgTalkItemSubType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
