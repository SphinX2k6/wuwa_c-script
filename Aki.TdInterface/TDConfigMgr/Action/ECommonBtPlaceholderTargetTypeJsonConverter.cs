using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022EC RID: 8940
	public class ECommonBtPlaceholderTargetTypeJsonConverter : JsonConverter<ECommonBtPlaceholderTargetType>
	{
		// Token: 0x0600C3A6 RID: 50086 RVA: 0x001C9450 File Offset: 0x001C7650
		public override ECommonBtPlaceholderTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECommonBtPlaceholderTargetType.Action;
			}
			return ECommonBtPlaceholderTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C3A7 RID: 50087 RVA: 0x001C9474 File Offset: 0x001C7674
		public override void Write(Utf8JsonWriter writer, ECommonBtPlaceholderTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
