using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200271F RID: 10015
	public class ETraceSplineOptionTypeJsonConverter : JsonConverter<ETraceSplineOptionType>
	{
		// Token: 0x0600D767 RID: 55143 RVA: 0x001F7738 File Offset: 0x001F5938
		public override ETraceSplineOptionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETraceSplineOptionType.Open;
			}
			return ETraceSplineOptionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D768 RID: 55144 RVA: 0x001F775C File Offset: 0x001F595C
		public override void Write(Utf8JsonWriter writer, ETraceSplineOptionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
