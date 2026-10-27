using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200238C RID: 9100
	public class EMoraleAreaTypeJsonConverter : JsonConverter<EMoraleAreaType>
	{
		// Token: 0x0600C676 RID: 50806 RVA: 0x001D11F8 File Offset: 0x001CF3F8
		public override EMoraleAreaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoraleAreaType.MoraleArea1;
			}
			return EMoraleAreaTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C677 RID: 50807 RVA: 0x001D121C File Offset: 0x001CF41C
		public override void Write(Utf8JsonWriter writer, EMoraleAreaType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
