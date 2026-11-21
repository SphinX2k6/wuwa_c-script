using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A2 RID: 2466
	public class EAttachTypeJsonConverter : JsonConverter<EAttachType>
	{
		// Token: 0x0600376D RID: 14189 RVA: 0x0008CA48 File Offset: 0x0008AC48
		public override EAttachType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttachType.Actor;
			}
			return EAttachTypeExtensions.FromString(@string);
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0008CA6C File Offset: 0x0008AC6C
		public override void Write(Utf8JsonWriter writer, EAttachType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
