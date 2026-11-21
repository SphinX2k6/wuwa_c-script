using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200027A RID: 634
	public class TConfigVersionKeyJsonConverter : JsonConverter<TConfigVersionKey>
	{
		// Token: 0x06000F8F RID: 3983 RVA: 0x0005C200 File Offset: 0x0005A400
		public override TConfigVersionKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TConfigVersionKey.FsmVersion;
			}
			return TConfigVersionKeyExtensions.FromString(@string);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0005C224 File Offset: 0x0005A424
		public override void Write(Utf8JsonWriter writer, TConfigVersionKey value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
