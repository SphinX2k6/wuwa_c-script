using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026AB RID: 9899
	public class ESetReviveTypeJsonConverter : JsonConverter<ESetReviveType>
	{
		// Token: 0x0600D55D RID: 54621 RVA: 0x001EFA6C File Offset: 0x001EDC6C
		public override ESetReviveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetReviveType.Add;
			}
			return ESetReviveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D55E RID: 54622 RVA: 0x001EFA90 File Offset: 0x001EDC90
		public override void Write(Utf8JsonWriter writer, ESetReviveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
