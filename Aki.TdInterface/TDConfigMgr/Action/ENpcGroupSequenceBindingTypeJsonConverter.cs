using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200263F RID: 9791
	public class ENpcGroupSequenceBindingTypeJsonConverter : JsonConverter<ENpcGroupSequenceBindingType>
	{
		// Token: 0x0600D377 RID: 54135 RVA: 0x001EBA08 File Offset: 0x001E9C08
		public override ENpcGroupSequenceBindingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcGroupSequenceBindingType.StaticEntity;
			}
			return ENpcGroupSequenceBindingTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D378 RID: 54136 RVA: 0x001EBA2C File Offset: 0x001E9C2C
		public override void Write(Utf8JsonWriter writer, ENpcGroupSequenceBindingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
