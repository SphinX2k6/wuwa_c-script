using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F7 RID: 9463
	public class EActionTypeJsonConverter : JsonConverter<EActionType>
	{
		// Token: 0x0600CDB3 RID: 52659 RVA: 0x001DCDE0 File Offset: 0x001DAFE0
		public override EActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActionType.Entity;
			}
			return EActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CDB4 RID: 52660 RVA: 0x001DCE04 File Offset: 0x001DB004
		public override void Write(Utf8JsonWriter writer, EActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
