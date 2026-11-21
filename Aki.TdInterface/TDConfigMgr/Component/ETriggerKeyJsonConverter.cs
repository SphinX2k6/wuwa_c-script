using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B08 RID: 2824
	public class ETriggerKeyJsonConverter : JsonConverter<ETriggerKey>
	{
		// Token: 0x06003DB8 RID: 15800 RVA: 0x0009DD20 File Offset: 0x0009BF20
		public override ETriggerKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETriggerKey.Left;
			}
			return ETriggerKeyExtensions.FromString(@string);
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x0009DD44 File Offset: 0x0009BF44
		public override void Write(Utf8JsonWriter writer, ETriggerKey value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
