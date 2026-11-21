using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002715 RID: 10005
	public class ETimeScaleTypeJsonConverter : JsonConverter<ETimeScaleType>
	{
		// Token: 0x0600D73A RID: 55098 RVA: 0x001F71D4 File Offset: 0x001F53D4
		public override ETimeScaleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeScaleType.Global;
			}
			return ETimeScaleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D73B RID: 55099 RVA: 0x001F71F8 File Offset: 0x001F53F8
		public override void Write(Utf8JsonWriter writer, ETimeScaleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
