using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E2 RID: 2530
	public class EEntityBatchTypeJsonConverter : JsonConverter<EEntityBatchType>
	{
		// Token: 0x0600388D RID: 14477 RVA: 0x000926C8 File Offset: 0x000908C8
		public override EEntityBatchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityBatchType.EntityList;
			}
			return EEntityBatchTypeExtensions.FromString(@string);
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x000926EC File Offset: 0x000908EC
		public override void Write(Utf8JsonWriter writer, EEntityBatchType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
