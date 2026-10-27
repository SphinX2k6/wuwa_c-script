using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001223 RID: 4643
	public class EArcadeGameplayTypeJsonConverter : JsonConverter<EArcadeGameplayType>
	{
		// Token: 0x06006946 RID: 26950 RVA: 0x000FAE3C File Offset: 0x000F903C
		public override EArcadeGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EArcadeGameplayType.DropCatch;
			}
			return EArcadeGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x000FAE60 File Offset: 0x000F9060
		public override void Write(Utf8JsonWriter writer, EArcadeGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
