using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200273B RID: 10043
	public class EUnlockSystemItemTypeJsonConverter : JsonConverter<EUnlockSystemItemType>
	{
		// Token: 0x0600D7E5 RID: 55269 RVA: 0x001F8B3C File Offset: 0x001F6D3C
		public override EUnlockSystemItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUnlockSystemItemType.CookSystem;
			}
			return EUnlockSystemItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D7E6 RID: 55270 RVA: 0x001F8B60 File Offset: 0x001F6D60
		public override void Write(Utf8JsonWriter writer, EUnlockSystemItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
