using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200129D RID: 4765
	public class ETakePhoto2TargetTypeJsonConverter : JsonConverter<ETakePhoto2TargetType>
	{
		// Token: 0x06006B6B RID: 27499 RVA: 0x001021BC File Offset: 0x001003BC
		public override ETakePhoto2TargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETakePhoto2TargetType.Entity;
			}
			return ETakePhoto2TargetTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x001021E0 File Offset: 0x001003E0
		public override void Write(Utf8JsonWriter writer, ETakePhoto2TargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
