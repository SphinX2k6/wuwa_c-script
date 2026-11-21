using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002613 RID: 9747
	public class EMontageConfigTypeJsonConverter : JsonConverter<EMontageConfigType>
	{
		// Token: 0x0600D2B1 RID: 53937 RVA: 0x001EA014 File Offset: 0x001E8214
		public override EMontageConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMontageConfigType.Asset;
			}
			return EMontageConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2B2 RID: 53938 RVA: 0x001EA038 File Offset: 0x001E8238
		public override void Write(Utf8JsonWriter writer, EMontageConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
