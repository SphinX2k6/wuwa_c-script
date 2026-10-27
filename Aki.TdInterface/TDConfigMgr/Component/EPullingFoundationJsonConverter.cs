using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E5 RID: 2533
	public class EPullingFoundationJsonConverter : JsonConverter<EPullingFoundation>
	{
		// Token: 0x06003839 RID: 14393 RVA: 0x00091C2C File Offset: 0x0008FE2C
		public override EPullingFoundation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPullingFoundation.CategoryMatching;
			}
			return EPullingFoundationExtensions.FromString(@string);
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00091C50 File Offset: 0x0008FE50
		public override void Write(Utf8JsonWriter writer, EPullingFoundation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
