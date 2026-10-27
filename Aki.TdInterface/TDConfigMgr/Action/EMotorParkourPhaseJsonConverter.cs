using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002394 RID: 9108
	public class EMotorParkourPhaseJsonConverter : JsonConverter<EMotorParkourPhase>
	{
		// Token: 0x0600C69A RID: 50842 RVA: 0x001D168C File Offset: 0x001CF88C
		public override EMotorParkourPhase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorParkourPhase.Start;
			}
			return EMotorParkourPhaseExtensions.FromString(@string);
		}

		// Token: 0x0600C69B RID: 50843 RVA: 0x001D16B0 File Offset: 0x001CF8B0
		public override void Write(Utf8JsonWriter writer, EMotorParkourPhase value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
