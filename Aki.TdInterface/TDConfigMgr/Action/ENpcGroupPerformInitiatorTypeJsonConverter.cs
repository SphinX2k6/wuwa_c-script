using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AE RID: 9134
	public class ENpcGroupPerformInitiatorTypeJsonConverter : JsonConverter<ENpcGroupPerformInitiatorType>
	{
		// Token: 0x0600C70F RID: 50959 RVA: 0x001D2558 File Offset: 0x001D0758
		public override ENpcGroupPerformInitiatorType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcGroupPerformInitiatorType.Player;
			}
			return ENpcGroupPerformInitiatorTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C710 RID: 50960 RVA: 0x001D257C File Offset: 0x001D077C
		public override void Write(Utf8JsonWriter writer, ENpcGroupPerformInitiatorType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
