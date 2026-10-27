using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EF RID: 2543
	public class ERefreshContentJsonConverter : JsonConverter<ERefreshContent>
	{
		// Token: 0x06003866 RID: 14438 RVA: 0x000920E8 File Offset: 0x000902E8
		public override ERefreshContent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERefreshContent.All;
			}
			return ERefreshContentExtensions.FromString(@string);
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x0009210C File Offset: 0x0009030C
		public override void Write(Utf8JsonWriter writer, ERefreshContent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
