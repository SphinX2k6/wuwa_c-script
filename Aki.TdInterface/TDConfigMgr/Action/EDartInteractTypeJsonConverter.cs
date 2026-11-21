using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002569 RID: 9577
	public class EDartInteractTypeJsonConverter : JsonConverter<EDartInteractType>
	{
		// Token: 0x0600CFB4 RID: 53172 RVA: 0x001E1B00 File Offset: 0x001DFD00
		public override EDartInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDartInteractType.Machine;
			}
			return EDartInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x001E1B24 File Offset: 0x001DFD24
		public override void Write(Utf8JsonWriter writer, EDartInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
