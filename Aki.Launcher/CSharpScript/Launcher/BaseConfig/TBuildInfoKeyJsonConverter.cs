using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200027C RID: 636
	public class TBuildInfoKeyJsonConverter : JsonConverter<TBuildInfoKey>
	{
		// Token: 0x06000F98 RID: 3992 RVA: 0x0005C3E4 File Offset: 0x0005A5E4
		public override TBuildInfoKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TBuildInfoKey.BuildId;
			}
			return TBuildInfoKeyExtensions.FromString(@string);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0005C408 File Offset: 0x0005A608
		public override void Write(Utf8JsonWriter writer, TBuildInfoKey value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
