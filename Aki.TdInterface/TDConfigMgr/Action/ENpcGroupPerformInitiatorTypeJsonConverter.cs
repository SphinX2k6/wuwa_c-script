using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200263B RID: 9787
	public class ENpcGroupPerformInitiatorTypeJsonConverter : JsonConverter<ENpcGroupPerformInitiatorType>
	{
		// Token: 0x0600D365 RID: 54117 RVA: 0x001EB7D4 File Offset: 0x001E99D4
		public override ENpcGroupPerformInitiatorType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcGroupPerformInitiatorType.Player;
			}
			return ENpcGroupPerformInitiatorTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D366 RID: 54118 RVA: 0x001EB7F8 File Offset: 0x001E99F8
		public override void Write(Utf8JsonWriter writer, ENpcGroupPerformInitiatorType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
