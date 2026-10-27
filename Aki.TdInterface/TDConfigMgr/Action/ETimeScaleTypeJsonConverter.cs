using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002474 RID: 9332
	public class ETimeScaleTypeJsonConverter : JsonConverter<ETimeScaleType>
	{
		// Token: 0x0600CA8A RID: 51850 RVA: 0x001DD120 File Offset: 0x001DB320
		public override ETimeScaleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeScaleType.Global;
			}
			return ETimeScaleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x001DD144 File Offset: 0x001DB344
		public override void Write(Utf8JsonWriter writer, ETimeScaleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
