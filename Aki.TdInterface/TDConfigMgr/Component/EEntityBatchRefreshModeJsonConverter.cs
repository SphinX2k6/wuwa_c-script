using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000933 RID: 2355
	public class EEntityBatchRefreshModeJsonConverter : JsonConverter<EEntityBatchRefreshMode>
	{
		// Token: 0x06003518 RID: 13592 RVA: 0x0008AA6C File Offset: 0x00088C6C
		public override EEntityBatchRefreshMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityBatchRefreshMode.SequenceBatch;
			}
			return EEntityBatchRefreshModeExtensions.FromString(@string);
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x0008AA90 File Offset: 0x00088C90
		public override void Write(Utf8JsonWriter writer, EEntityBatchRefreshMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
