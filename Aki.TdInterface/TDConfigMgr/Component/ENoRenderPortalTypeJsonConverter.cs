using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B3 RID: 2483
	public class ENoRenderPortalTypeJsonConverter : JsonConverter<ENoRenderPortalType>
	{
		// Token: 0x06003758 RID: 14168 RVA: 0x0008FF48 File Offset: 0x0008E148
		public override ENoRenderPortalType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENoRenderPortalType.Static;
			}
			return ENoRenderPortalTypeExtensions.FromString(@string);
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x0008FF6C File Offset: 0x0008E16C
		public override void Write(Utf8JsonWriter writer, ENoRenderPortalType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
