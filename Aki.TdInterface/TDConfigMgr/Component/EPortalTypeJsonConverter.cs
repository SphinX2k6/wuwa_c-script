using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DD RID: 2525
	public class EPortalTypeJsonConverter : JsonConverter<EPortalType>
	{
		// Token: 0x06003815 RID: 14357 RVA: 0x000917A8 File Offset: 0x0008F9A8
		public override EPortalType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPortalType.Static;
			}
			return EPortalTypeExtensions.FromString(@string);
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x000917CC File Offset: 0x0008F9CC
		public override void Write(Utf8JsonWriter writer, EPortalType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
