using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C7 RID: 9671
	public class EHandBookProgressTypeJsonConverter : JsonConverter<EHandBookProgressType>
	{
		// Token: 0x0600D15B RID: 53595 RVA: 0x001E53D0 File Offset: 0x001E35D0
		public override EHandBookProgressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHandBookProgressType.GrantEmoji;
			}
			return EHandBookProgressTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D15C RID: 53596 RVA: 0x001E53F4 File Offset: 0x001E35F4
		public override void Write(Utf8JsonWriter writer, EHandBookProgressType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
