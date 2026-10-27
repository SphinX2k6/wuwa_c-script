using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E8 RID: 9192
	public class ERegionConfigTypeJsonConverter : JsonConverter<ERegionConfigType>
	{
		// Token: 0x0600C814 RID: 51220 RVA: 0x001D4A6C File Offset: 0x001D2C6C
		public override ERegionConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERegionConfigType.Mpc;
			}
			return ERegionConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C815 RID: 51221 RVA: 0x001D4A90 File Offset: 0x001D2C90
		public override void Write(Utf8JsonWriter writer, ERegionConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
