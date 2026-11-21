using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002739 RID: 10041
	public class EUnlockCookSystemTypeJsonConverter : JsonConverter<EUnlockCookSystemType>
	{
		// Token: 0x0600D7DC RID: 55260 RVA: 0x001F8984 File Offset: 0x001F6B84
		public override EUnlockCookSystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUnlockCookSystemType.UnlockCookBook;
			}
			return EUnlockCookSystemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D7DD RID: 55261 RVA: 0x001F89A8 File Offset: 0x001F6BA8
		public override void Write(Utf8JsonWriter writer, EUnlockCookSystemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
