using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D0 RID: 2512
	public class EDirectionJsonConverter : JsonConverter<EDirection>
	{
		// Token: 0x0600383C RID: 14396 RVA: 0x00091D6C File Offset: 0x0008FF6C
		public override EDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDirection.Right;
			}
			return EDirectionExtensions.FromString(@string);
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00091D90 File Offset: 0x0008FF90
		public override void Write(Utf8JsonWriter writer, EDirection value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
