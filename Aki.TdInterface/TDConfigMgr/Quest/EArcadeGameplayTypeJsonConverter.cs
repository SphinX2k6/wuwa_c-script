using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200135F RID: 4959
	public class EArcadeGameplayTypeJsonConverter : JsonConverter<EArcadeGameplayType>
	{
		// Token: 0x06006F87 RID: 28551 RVA: 0x00108748 File Offset: 0x00106948
		public override EArcadeGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EArcadeGameplayType.DropCatch;
			}
			return EArcadeGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x0010876C File Offset: 0x0010696C
		public override void Write(Utf8JsonWriter writer, EArcadeGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
