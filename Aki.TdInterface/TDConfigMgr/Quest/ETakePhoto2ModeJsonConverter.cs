using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013DF RID: 5087
	public class ETakePhoto2ModeJsonConverter : JsonConverter<ETakePhoto2Mode>
	{
		// Token: 0x060071C7 RID: 29127 RVA: 0x0010FEE8 File Offset: 0x0010E0E8
		public override ETakePhoto2Mode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETakePhoto2Mode.BeforeYourEyes;
			}
			return ETakePhoto2ModeExtensions.FromString(@string);
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x0010FF0C File Offset: 0x0010E10C
		public override void Write(Utf8JsonWriter writer, ETakePhoto2Mode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
