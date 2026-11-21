using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E1 RID: 5089
	public class ETakePhoto2SuccessCameraBehaviorJsonConverter : JsonConverter<ETakePhoto2SuccessCameraBehavior>
	{
		// Token: 0x060071D0 RID: 29136 RVA: 0x0010FFFC File Offset: 0x0010E1FC
		public override ETakePhoto2SuccessCameraBehavior Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETakePhoto2SuccessCameraBehavior.KeepOpen;
			}
			return ETakePhoto2SuccessCameraBehaviorExtensions.FromString(@string);
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x00110020 File Offset: 0x0010E220
		public override void Write(Utf8JsonWriter writer, ETakePhoto2SuccessCameraBehavior value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
