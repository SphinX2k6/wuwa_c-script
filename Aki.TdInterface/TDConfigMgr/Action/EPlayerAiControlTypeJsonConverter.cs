using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002663 RID: 9827
	public class EPlayerAiControlTypeJsonConverter : JsonConverter<EPlayerAiControlType>
	{
		// Token: 0x0600D419 RID: 54297 RVA: 0x001ECFB0 File Offset: 0x001EB1B0
		public override EPlayerAiControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerAiControlType.Enable;
			}
			return EPlayerAiControlTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D41A RID: 54298 RVA: 0x001ECFD4 File Offset: 0x001EB1D4
		public override void Write(Utf8JsonWriter writer, EPlayerAiControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
