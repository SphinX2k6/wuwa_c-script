using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000923 RID: 2339
	public class EDirectionJsonConverter : JsonConverter<EDirection>
	{
		// Token: 0x060034D0 RID: 13520 RVA: 0x0008A1EC File Offset: 0x000883EC
		public override EDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDirection.Right;
			}
			return EDirectionExtensions.FromString(@string);
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x0008A210 File Offset: 0x00088410
		public override void Write(Utf8JsonWriter writer, EDirection value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
