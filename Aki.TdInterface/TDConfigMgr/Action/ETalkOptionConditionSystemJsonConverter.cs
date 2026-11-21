using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026FB RID: 9979
	public class ETalkOptionConditionSystemJsonConverter : JsonConverter<ETalkOptionConditionSystem>
	{
		// Token: 0x0600D6C5 RID: 54981 RVA: 0x001F5AF4 File Offset: 0x001F3CF4
		public override ETalkOptionConditionSystem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkOptionConditionSystem.SolarSchool;
			}
			return ETalkOptionConditionSystemExtensions.FromString(@string);
		}

		// Token: 0x0600D6C6 RID: 54982 RVA: 0x001F5B18 File Offset: 0x001F3D18
		public override void Write(Utf8JsonWriter writer, ETalkOptionConditionSystem value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
