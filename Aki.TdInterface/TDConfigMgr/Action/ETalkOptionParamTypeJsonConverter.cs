using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026FD RID: 9981
	public class ETalkOptionParamTypeJsonConverter : JsonConverter<ETalkOptionParamType>
	{
		// Token: 0x0600D6CE RID: 54990 RVA: 0x001F5D58 File Offset: 0x001F3F58
		public override ETalkOptionParamType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkOptionParamType.QteSucceed;
			}
			return ETalkOptionParamTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D6CF RID: 54991 RVA: 0x001F5D7C File Offset: 0x001F3F7C
		public override void Write(Utf8JsonWriter writer, ETalkOptionParamType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
