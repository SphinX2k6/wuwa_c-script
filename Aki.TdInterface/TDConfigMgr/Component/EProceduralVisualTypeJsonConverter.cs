using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E1 RID: 2529
	public class EProceduralVisualTypeJsonConverter : JsonConverter<EProceduralVisualType>
	{
		// Token: 0x06003827 RID: 14375 RVA: 0x00091998 File Offset: 0x0008FB98
		public override EProceduralVisualType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EProceduralVisualType.LookAt;
			}
			return EProceduralVisualTypeExtensions.FromString(@string);
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x000919BC File Offset: 0x0008FBBC
		public override void Write(Utf8JsonWriter writer, EProceduralVisualType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
