using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E7 RID: 5095
	public class ETetrisDirectionJsonConverter : JsonConverter<ETetrisDirection>
	{
		// Token: 0x060071EB RID: 29163 RVA: 0x001103AC File Offset: 0x0010E5AC
		public override ETetrisDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETetrisDirection.UpDown;
			}
			return ETetrisDirectionExtensions.FromString(@string);
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x001103D0 File Offset: 0x0010E5D0
		public override void Write(Utf8JsonWriter writer, ETetrisDirection value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
