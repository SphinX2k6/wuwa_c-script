using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000989 RID: 2441
	public class ELevelAiCycleModeJsonConverter : JsonConverter<ELevelAiCycleMode>
	{
		// Token: 0x0600369B RID: 13979 RVA: 0x0008E3D8 File Offset: 0x0008C5D8
		public override ELevelAiCycleMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelAiCycleMode.Loop;
			}
			return ELevelAiCycleModeExtensions.FromString(@string);
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x0008E3FC File Offset: 0x0008C5FC
		public override void Write(Utf8JsonWriter writer, ELevelAiCycleMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
