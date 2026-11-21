using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002687 RID: 9863
	public class EResetPosTypeJsonConverter : JsonConverter<EResetPosType>
	{
		// Token: 0x0600D4BB RID: 54459 RVA: 0x001EE6DC File Offset: 0x001EC8DC
		public override EResetPosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResetPosType.PosEntity;
			}
			return EResetPosTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4BC RID: 54460 RVA: 0x001EE700 File Offset: 0x001EC900
		public override void Write(Utf8JsonWriter writer, EResetPosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
