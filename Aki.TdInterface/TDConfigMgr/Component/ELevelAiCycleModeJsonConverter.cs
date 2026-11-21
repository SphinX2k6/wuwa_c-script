using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3C RID: 2620
	public class ELevelAiCycleModeJsonConverter : JsonConverter<ELevelAiCycleMode>
	{
		// Token: 0x06003A22 RID: 14882 RVA: 0x00096344 File Offset: 0x00094544
		public override ELevelAiCycleMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelAiCycleMode.Loop;
			}
			return ELevelAiCycleModeExtensions.FromString(@string);
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x00096368 File Offset: 0x00094568
		public override void Write(Utf8JsonWriter writer, ELevelAiCycleMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
