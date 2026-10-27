using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248C RID: 9356
	public class ETuningStandGridTypeJsonConverter : JsonConverter<ETuningStandGridType>
	{
		// Token: 0x0600CAF6 RID: 51958 RVA: 0x001DE284 File Offset: 0x001DC484
		public override ETuningStandGridType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETuningStandGridType.Empty;
			}
			return ETuningStandGridTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CAF7 RID: 51959 RVA: 0x001DE2A8 File Offset: 0x001DC4A8
		public override void Write(Utf8JsonWriter writer, ETuningStandGridType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
