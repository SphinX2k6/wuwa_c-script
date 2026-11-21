using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026AF RID: 9903
	public class ESetTeleControlTypeJsonConverter : JsonConverter<ESetTeleControlType>
	{
		// Token: 0x0600D56F RID: 54639 RVA: 0x001EFC5C File Offset: 0x001EDE5C
		public override ESetTeleControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetTeleControlType.OpenGravity;
			}
			return ESetTeleControlTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D570 RID: 54640 RVA: 0x001EFC80 File Offset: 0x001EDE80
		public override void Write(Utf8JsonWriter writer, ESetTeleControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
