using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A3 RID: 5027
	public class EPlayerButtonTypeJsonConverter : JsonConverter<EPlayerButtonType>
	{
		// Token: 0x060070B9 RID: 28857 RVA: 0x0010CC18 File Offset: 0x0010AE18
		public override EPlayerButtonType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerButtonType.ChallengeAgain;
			}
			return EPlayerButtonTypeExtensions.FromString(@string);
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x0010CC3C File Offset: 0x0010AE3C
		public override void Write(Utf8JsonWriter writer, EPlayerButtonType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
