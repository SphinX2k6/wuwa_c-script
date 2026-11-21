using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200273D RID: 10045
	public class EVehicleControlTypeJsonConverter : JsonConverter<EVehicleControlType>
	{
		// Token: 0x0600D7EE RID: 55278 RVA: 0x001F8C50 File Offset: 0x001F6E50
		public override EVehicleControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVehicleControlType.EnterPathMoving;
			}
			return EVehicleControlTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D7EF RID: 55279 RVA: 0x001F8C74 File Offset: 0x001F6E74
		public override void Write(Utf8JsonWriter writer, EVehicleControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
