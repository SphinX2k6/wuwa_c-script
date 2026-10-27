using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000249 RID: 585
	public class EResFileJsonConverter : JsonConverter<EResFile>
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x000568A8 File Offset: 0x00054AA8
		public override EResFile Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResFile.PAK;
			}
			return EResFileExtensions.FromString(@string);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x000568CC File Offset: 0x00054ACC
		public override void Write(Utf8JsonWriter writer, EResFile value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
