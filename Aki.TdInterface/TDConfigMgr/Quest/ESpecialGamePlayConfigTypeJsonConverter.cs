using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D1 RID: 5073
	public class ESpecialGamePlayConfigTypeJsonConverter : JsonConverter<ESpecialGamePlayConfigType>
	{
		// Token: 0x06007188 RID: 29064 RVA: 0x0010F2B8 File Offset: 0x0010D4B8
		public override ESpecialGamePlayConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialGamePlayConfigType.Stalking;
			}
			return ESpecialGamePlayConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x0010F2DC File Offset: 0x0010D4DC
		public override void Write(Utf8JsonWriter writer, ESpecialGamePlayConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
