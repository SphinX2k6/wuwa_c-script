using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AAA RID: 2730
	public class EPullingFoundationJsonConverter : JsonConverter<EPullingFoundation>
	{
		// Token: 0x06003C11 RID: 15377 RVA: 0x0009A4EC File Offset: 0x000986EC
		public override EPullingFoundation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPullingFoundation.CategoryMatching;
			}
			return EPullingFoundationExtensions.FromString(@string);
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x0009A510 File Offset: 0x00098710
		public override void Write(Utf8JsonWriter writer, EPullingFoundation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
