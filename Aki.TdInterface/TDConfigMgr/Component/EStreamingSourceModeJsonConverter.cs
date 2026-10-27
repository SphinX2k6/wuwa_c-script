using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A23 RID: 2595
	public class EStreamingSourceModeJsonConverter : JsonConverter<EStreamingSourceMode>
	{
		// Token: 0x06003950 RID: 14672 RVA: 0x000941A8 File Offset: 0x000923A8
		public override EStreamingSourceMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStreamingSourceMode.Fixed;
			}
			return EStreamingSourceModeExtensions.FromString(@string);
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x000941CC File Offset: 0x000923CC
		public override void Write(Utf8JsonWriter writer, EStreamingSourceMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
