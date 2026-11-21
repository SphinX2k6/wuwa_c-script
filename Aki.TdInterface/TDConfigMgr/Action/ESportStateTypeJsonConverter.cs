using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026CF RID: 9935
	public class ESportStateTypeJsonConverter : JsonConverter<ESportStateType>
	{
		// Token: 0x0600D5FF RID: 54783 RVA: 0x001F191C File Offset: 0x001EFB1C
		public override ESportStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESportStateType.Slide;
			}
			return ESportStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x001F1940 File Offset: 0x001EFB40
		public override void Write(Utf8JsonWriter writer, ESportStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
