using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001225 RID: 4645
	public class EAtomicProcessJsonConverter : JsonConverter<EAtomicProcess>
	{
		// Token: 0x0600694F RID: 26959 RVA: 0x000FAF18 File Offset: 0x000F9118
		public override EAtomicProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAtomicProcess.StoveCoreFall;
			}
			return EAtomicProcessExtensions.FromString(@string);
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x000FAF3C File Offset: 0x000F913C
		public override void Write(Utf8JsonWriter writer, EAtomicProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
