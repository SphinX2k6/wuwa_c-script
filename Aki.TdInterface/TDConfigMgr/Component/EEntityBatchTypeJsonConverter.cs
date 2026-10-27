using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000935 RID: 2357
	public class EEntityBatchTypeJsonConverter : JsonConverter<EEntityBatchType>
	{
		// Token: 0x06003521 RID: 13601 RVA: 0x0008AB48 File Offset: 0x00088D48
		public override EEntityBatchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityBatchType.EntityList;
			}
			return EEntityBatchTypeExtensions.FromString(@string);
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x0008AB6C File Offset: 0x00088D6C
		public override void Write(Utf8JsonWriter writer, EEntityBatchType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
