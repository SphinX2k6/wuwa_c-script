using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F3 RID: 2547
	public class ERenderFlagTypeJsonConverter : JsonConverter<ERenderFlagType>
	{
		// Token: 0x06003878 RID: 14456 RVA: 0x00092424 File Offset: 0x00090624
		public override ERenderFlagType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERenderFlagType.Fog;
			}
			return ERenderFlagTypeExtensions.FromString(@string);
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00092448 File Offset: 0x00090648
		public override void Write(Utf8JsonWriter writer, ERenderFlagType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
