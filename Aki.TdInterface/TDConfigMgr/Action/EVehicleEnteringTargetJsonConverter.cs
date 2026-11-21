using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200273F RID: 10047
	public class EVehicleEnteringTargetJsonConverter : JsonConverter<EVehicleEnteringTarget>
	{
		// Token: 0x0600D7F7 RID: 55287 RVA: 0x001F8D64 File Offset: 0x001F6F64
		public override EVehicleEnteringTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVehicleEnteringTarget.Player;
			}
			return EVehicleEnteringTargetExtensions.FromString(@string);
		}

		// Token: 0x0600D7F8 RID: 55288 RVA: 0x001F8D88 File Offset: 0x001F6F88
		public override void Write(Utf8JsonWriter writer, EVehicleEnteringTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
