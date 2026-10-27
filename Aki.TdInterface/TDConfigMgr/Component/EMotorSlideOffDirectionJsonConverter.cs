using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A7 RID: 2471
	public class EMotorSlideOffDirectionJsonConverter : JsonConverter<EMotorSlideOffDirection>
	{
		// Token: 0x06003722 RID: 14114 RVA: 0x0008F534 File Offset: 0x0008D734
		public override EMotorSlideOffDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorSlideOffDirection.Left;
			}
			return EMotorSlideOffDirectionExtensions.FromString(@string);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0008F558 File Offset: 0x0008D758
		public override void Write(Utf8JsonWriter writer, EMotorSlideOffDirection value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
