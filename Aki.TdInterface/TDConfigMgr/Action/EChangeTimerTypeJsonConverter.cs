using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D8 RID: 8920
	public class EChangeTimerTypeJsonConverter : JsonConverter<EChangeTimerType>
	{
		// Token: 0x0600C34C RID: 49996 RVA: 0x001C89F8 File Offset: 0x001C6BF8
		public override EChangeTimerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChangeTimerType.Add;
			}
			return EChangeTimerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C34D RID: 49997 RVA: 0x001C8A1C File Offset: 0x001C6C1C
		public override void Write(Utf8JsonWriter writer, EChangeTimerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
