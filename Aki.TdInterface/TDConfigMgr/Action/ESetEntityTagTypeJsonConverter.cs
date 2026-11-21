using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A5 RID: 9893
	public class ESetEntityTagTypeJsonConverter : JsonConverter<ESetEntityTagType>
	{
		// Token: 0x0600D542 RID: 54594 RVA: 0x001EF7A0 File Offset: 0x001ED9A0
		public override ESetEntityTagType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetEntityTagType.Add;
			}
			return ESetEntityTagTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D543 RID: 54595 RVA: 0x001EF7C4 File Offset: 0x001ED9C4
		public override void Write(Utf8JsonWriter writer, ESetEntityTagType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
