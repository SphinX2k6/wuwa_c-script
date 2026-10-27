using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002372 RID: 9074
	public class ELimitPlayOperationJsonConverter : JsonConverter<ELimitPlayOperation>
	{
		// Token: 0x0600C601 RID: 50689 RVA: 0x001D02A8 File Offset: 0x001CE4A8
		public override ELimitPlayOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELimitPlayOperation.AllowCamera;
			}
			return ELimitPlayOperationExtensions.FromString(@string);
		}

		// Token: 0x0600C602 RID: 50690 RVA: 0x001D02CC File Offset: 0x001CE4CC
		public override void Write(Utf8JsonWriter writer, ELimitPlayOperation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
