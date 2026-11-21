using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025BF RID: 9663
	public class EGroupAiCommunicateTypeJsonConverter : JsonConverter<EGroupAiCommunicateType>
	{
		// Token: 0x0600D137 RID: 53559 RVA: 0x001E4FB8 File Offset: 0x001E31B8
		public override EGroupAiCommunicateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupAiCommunicateType.AddTag;
			}
			return EGroupAiCommunicateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D138 RID: 53560 RVA: 0x001E4FDC File Offset: 0x001E31DC
		public override void Write(Utf8JsonWriter writer, EGroupAiCommunicateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
