using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A43 RID: 2627
	public class ETriggerKeyJsonConverter : JsonConverter<ETriggerKey>
	{
		// Token: 0x060039E0 RID: 14816 RVA: 0x000953B4 File Offset: 0x000935B4
		public override ETriggerKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETriggerKey.Left;
			}
			return ETriggerKeyExtensions.FromString(@string);
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x000953D8 File Offset: 0x000935D8
		public override void Write(Utf8JsonWriter writer, ETriggerKey value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
