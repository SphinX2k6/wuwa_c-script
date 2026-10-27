using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002498 RID: 9368
	public class EUnlockSystemItemTypeJsonConverter : JsonConverter<EUnlockSystemItemType>
	{
		// Token: 0x0600CB2C RID: 52012 RVA: 0x001DE974 File Offset: 0x001DCB74
		public override EUnlockSystemItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUnlockSystemItemType.CookSystem;
			}
			return EUnlockSystemItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB2D RID: 52013 RVA: 0x001DE998 File Offset: 0x001DCB98
		public override void Write(Utf8JsonWriter writer, EUnlockSystemItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
