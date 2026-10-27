using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002496 RID: 9366
	public class EUnlockCookSystemTypeJsonConverter : JsonConverter<EUnlockCookSystemType>
	{
		// Token: 0x0600CB23 RID: 52003 RVA: 0x001DE7BC File Offset: 0x001DC9BC
		public override EUnlockCookSystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUnlockCookSystemType.UnlockCookBook;
			}
			return EUnlockCookSystemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB24 RID: 52004 RVA: 0x001DE7E0 File Offset: 0x001DC9E0
		public override void Write(Utf8JsonWriter writer, EUnlockCookSystemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
