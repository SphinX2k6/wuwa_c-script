using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249C RID: 9372
	public class EVehicleEnteringTargetJsonConverter : JsonConverter<EVehicleEnteringTarget>
	{
		// Token: 0x0600CB3E RID: 52030 RVA: 0x001DEB9C File Offset: 0x001DCD9C
		public override EVehicleEnteringTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVehicleEnteringTarget.Player;
			}
			return EVehicleEnteringTargetExtensions.FromString(@string);
		}

		// Token: 0x0600CB3F RID: 52031 RVA: 0x001DEBC0 File Offset: 0x001DCDC0
		public override void Write(Utf8JsonWriter writer, EVehicleEnteringTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
