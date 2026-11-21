using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001361 RID: 4961
	public class EAtomicProcessJsonConverter : JsonConverter<EAtomicProcess>
	{
		// Token: 0x06006F90 RID: 28560 RVA: 0x00108824 File Offset: 0x00106A24
		public override EAtomicProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAtomicProcess.StoveCoreFall;
			}
			return EAtomicProcessExtensions.FromString(@string);
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x00108848 File Offset: 0x00106A48
		public override void Write(Utf8JsonWriter writer, EAtomicProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
