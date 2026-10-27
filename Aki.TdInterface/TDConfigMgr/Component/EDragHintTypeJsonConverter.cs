using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000927 RID: 2343
	public class EDragHintTypeJsonConverter : JsonConverter<EDragHintType>
	{
		// Token: 0x060034E2 RID: 13538 RVA: 0x0008A420 File Offset: 0x00088620
		public override EDragHintType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDragHintType.Horizontal;
			}
			return EDragHintTypeExtensions.FromString(@string);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0008A444 File Offset: 0x00088644
		public override void Write(Utf8JsonWriter writer, EDragHintType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
