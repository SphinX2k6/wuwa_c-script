using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000273 RID: 627
	public class TConfigVersionKeyJsonConverter : JsonConverter<TConfigVersionKey>
	{
		// Token: 0x06000F44 RID: 3908 RVA: 0x0005925C File Offset: 0x0005745C
		public override TConfigVersionKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TConfigVersionKey.FsmVersion;
			}
			return TConfigVersionKeyExtensions.FromString(@string);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00059280 File Offset: 0x00057480
		public override void Write(Utf8JsonWriter writer, TConfigVersionKey value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
