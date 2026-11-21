using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002609 RID: 9737
	public class EMapMarkTypeJsonConverter : JsonConverter<EMapMarkType>
	{
		// Token: 0x0600D284 RID: 53892 RVA: 0x001E9A50 File Offset: 0x001E7C50
		public override EMapMarkType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMapMarkType.Custom;
			}
			return EMapMarkTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x001E9A74 File Offset: 0x001E7C74
		public override void Write(Utf8JsonWriter writer, EMapMarkType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
