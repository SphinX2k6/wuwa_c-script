using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200256B RID: 9579
	public class EDelayRemoveTypeJsonConverter : JsonConverter<EDelayRemoveType>
	{
		// Token: 0x0600CFBD RID: 53181 RVA: 0x001E1BDC File Offset: 0x001DFDDC
		public override EDelayRemoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDelayRemoveType.DelayRemoveAfterSkillFinish;
			}
			return EDelayRemoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CFBE RID: 53182 RVA: 0x001E1C00 File Offset: 0x001DFE00
		public override void Write(Utf8JsonWriter writer, EDelayRemoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
