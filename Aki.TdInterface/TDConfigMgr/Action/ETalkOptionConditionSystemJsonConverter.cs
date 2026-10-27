using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245A RID: 9306
	public class ETalkOptionConditionSystemJsonConverter : JsonConverter<ETalkOptionConditionSystem>
	{
		// Token: 0x0600CA15 RID: 51733 RVA: 0x001DBA40 File Offset: 0x001D9C40
		public override ETalkOptionConditionSystem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkOptionConditionSystem.SolarSchool;
			}
			return ETalkOptionConditionSystemExtensions.FromString(@string);
		}

		// Token: 0x0600CA16 RID: 51734 RVA: 0x001DBA64 File Offset: 0x001D9C64
		public override void Write(Utf8JsonWriter writer, ETalkOptionConditionSystem value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
