using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D2 RID: 9170
	public class EPlayerOperationTypeJsonConverter : JsonConverter<EPlayerOperationType>
	{
		// Token: 0x0600C7B1 RID: 51121 RVA: 0x001D3BF8 File Offset: 0x001D1DF8
		public override EPlayerOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerOperationType.EnableAll;
			}
			return EPlayerOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C7B2 RID: 51122 RVA: 0x001D3C1C File Offset: 0x001D1E1C
		public override void Write(Utf8JsonWriter writer, EPlayerOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
