using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A68 RID: 2664
	public class ENoRenderPortalTypeJsonConverter : JsonConverter<ENoRenderPortalType>
	{
		// Token: 0x06003AE8 RID: 15080 RVA: 0x0009803C File Offset: 0x0009623C
		public override ENoRenderPortalType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENoRenderPortalType.Static;
			}
			return ENoRenderPortalTypeExtensions.FromString(@string);
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00098060 File Offset: 0x00096260
		public override void Write(Utf8JsonWriter writer, ENoRenderPortalType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
