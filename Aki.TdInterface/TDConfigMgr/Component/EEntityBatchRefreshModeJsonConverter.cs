using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E0 RID: 2528
	public class EEntityBatchRefreshModeJsonConverter : JsonConverter<EEntityBatchRefreshMode>
	{
		// Token: 0x06003884 RID: 14468 RVA: 0x000925EC File Offset: 0x000907EC
		public override EEntityBatchRefreshMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityBatchRefreshMode.SequenceBatch;
			}
			return EEntityBatchRefreshModeExtensions.FromString(@string);
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00092610 File Offset: 0x00090810
		public override void Write(Utf8JsonWriter writer, EEntityBatchRefreshMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
