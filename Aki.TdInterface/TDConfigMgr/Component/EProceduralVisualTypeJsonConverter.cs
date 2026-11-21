using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA6 RID: 2726
	public class EProceduralVisualTypeJsonConverter : JsonConverter<EProceduralVisualType>
	{
		// Token: 0x06003BFF RID: 15359 RVA: 0x0009A258 File Offset: 0x00098458
		public override EProceduralVisualType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EProceduralVisualType.LookAt;
			}
			return EProceduralVisualTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x0009A27C File Offset: 0x0009847C
		public override void Write(Utf8JsonWriter writer, EProceduralVisualType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
