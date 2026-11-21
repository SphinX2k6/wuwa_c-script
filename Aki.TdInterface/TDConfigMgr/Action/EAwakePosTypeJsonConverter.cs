using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002525 RID: 9509
	public class EAwakePosTypeJsonConverter : JsonConverter<EAwakePosType>
	{
		// Token: 0x0600CE82 RID: 52866 RVA: 0x001DF170 File Offset: 0x001DD370
		public override EAwakePosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAwakePosType.TransformVar;
			}
			return EAwakePosTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE83 RID: 52867 RVA: 0x001DF194 File Offset: 0x001DD394
		public override void Write(Utf8JsonWriter writer, EAwakePosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
