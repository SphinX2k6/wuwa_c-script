using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200272F RID: 10031
	public class ETuningStandGridTypeJsonConverter : JsonConverter<ETuningStandGridType>
	{
		// Token: 0x0600D7AF RID: 55215 RVA: 0x001F844C File Offset: 0x001F664C
		public override ETuningStandGridType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETuningStandGridType.Empty;
			}
			return ETuningStandGridTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D7B0 RID: 55216 RVA: 0x001F8470 File Offset: 0x001F6670
		public override void Write(Utf8JsonWriter writer, ETuningStandGridType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
