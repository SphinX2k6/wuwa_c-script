using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A46 RID: 2630
	public class ELookAtInvalidProcessJsonConverter : JsonConverter<ELookAtInvalidProcess>
	{
		// Token: 0x06003A4F RID: 14927 RVA: 0x00096960 File Offset: 0x00094B60
		public override ELookAtInvalidProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELookAtInvalidProcess.Reset;
			}
			return ELookAtInvalidProcessExtensions.FromString(@string);
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00096984 File Offset: 0x00094B84
		public override void Write(Utf8JsonWriter writer, ELookAtInvalidProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
