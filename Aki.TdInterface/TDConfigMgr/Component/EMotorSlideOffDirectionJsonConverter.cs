using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A5C RID: 2652
	public class EMotorSlideOffDirectionJsonConverter : JsonConverter<EMotorSlideOffDirection>
	{
		// Token: 0x06003AB2 RID: 15026 RVA: 0x000975F8 File Offset: 0x000957F8
		public override EMotorSlideOffDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorSlideOffDirection.Left;
			}
			return EMotorSlideOffDirectionExtensions.FromString(@string);
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x0009761C File Offset: 0x0009581C
		public override void Write(Utf8JsonWriter writer, EMotorSlideOffDirection value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
