using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200268D RID: 9869
	public class ERogueRewardReceiveTypeJsonConverter : JsonConverter<ERogueRewardReceiveType>
	{
		// Token: 0x0600D4D6 RID: 54486 RVA: 0x001EE9A8 File Offset: 0x001ECBA8
		public override ERogueRewardReceiveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERogueRewardReceiveType.ReceiveByCount;
			}
			return ERogueRewardReceiveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4D7 RID: 54487 RVA: 0x001EE9CC File Offset: 0x001ECBCC
		public override void Write(Utf8JsonWriter writer, ERogueRewardReceiveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
