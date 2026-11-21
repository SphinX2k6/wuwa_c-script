using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B14 RID: 2836
	public class EWuWaGoGridRotationTypeJsonConverter : JsonConverter<EWuWaGoGridRotationType>
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x0009E7DC File Offset: 0x0009C9DC
		public override EWuWaGoGridRotationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoGridRotationType.Front;
			}
			return EWuWaGoGridRotationTypeExtensions.FromString(@string);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x0009E800 File Offset: 0x0009CA00
		public override void Write(Utf8JsonWriter writer, EWuWaGoGridRotationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
