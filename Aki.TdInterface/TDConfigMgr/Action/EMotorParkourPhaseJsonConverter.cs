using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200261D RID: 9757
	public class EMotorParkourPhaseJsonConverter : JsonConverter<EMotorParkourPhase>
	{
		// Token: 0x0600D2DE RID: 53982 RVA: 0x001EA660 File Offset: 0x001E8860
		public override EMotorParkourPhase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorParkourPhase.Start;
			}
			return EMotorParkourPhaseExtensions.FromString(@string);
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x001EA684 File Offset: 0x001E8884
		public override void Write(Utf8JsonWriter writer, EMotorParkourPhase value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
