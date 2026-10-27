using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249A RID: 9370
	public class EVehicleControlTypeJsonConverter : JsonConverter<EVehicleControlType>
	{
		// Token: 0x0600CB35 RID: 52021 RVA: 0x001DEA88 File Offset: 0x001DCC88
		public override EVehicleControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVehicleControlType.EnterPathMoving;
			}
			return EVehicleControlTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x001DEAAC File Offset: 0x001DCCAC
		public override void Write(Utf8JsonWriter writer, EVehicleControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
