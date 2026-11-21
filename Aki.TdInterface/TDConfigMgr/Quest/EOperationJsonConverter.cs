using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200139D RID: 5021
	public class EOperationJsonConverter : JsonConverter<EOperation>
	{
		// Token: 0x0600709E RID: 28830 RVA: 0x0010C914 File Offset: 0x0010AB14
		public override EOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOperation.DisableHLOD;
			}
			return EOperationExtensions.FromString(@string);
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x0010C938 File Offset: 0x0010AB38
		public override void Write(Utf8JsonWriter writer, EOperation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
