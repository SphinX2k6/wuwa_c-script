using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F6 RID: 9206
	public class ERogueRewardReceiveTypeJsonConverter : JsonConverter<ERogueRewardReceiveType>
	{
		// Token: 0x0600C853 RID: 51283 RVA: 0x001D51FC File Offset: 0x001D33FC
		public override ERogueRewardReceiveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERogueRewardReceiveType.ReceiveByCount;
			}
			return ERogueRewardReceiveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C854 RID: 51284 RVA: 0x001D5220 File Offset: 0x001D3420
		public override void Write(Utf8JsonWriter writer, ERogueRewardReceiveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
