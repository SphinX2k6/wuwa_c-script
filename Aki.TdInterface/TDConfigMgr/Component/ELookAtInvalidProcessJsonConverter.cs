using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000993 RID: 2451
	public class ELookAtInvalidProcessJsonConverter : JsonConverter<ELookAtInvalidProcess>
	{
		// Token: 0x060036C8 RID: 14024 RVA: 0x0008E9F4 File Offset: 0x0008CBF4
		public override ELookAtInvalidProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELookAtInvalidProcess.Reset;
			}
			return ELookAtInvalidProcessExtensions.FromString(@string);
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x0008EA18 File Offset: 0x0008CC18
		public override void Write(Utf8JsonWriter writer, ELookAtInvalidProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
