using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002290 RID: 8848
	public class EActorFxEmoteTypeJsonConverter : JsonConverter<EActorFxEmoteType>
	{
		// Token: 0x0600C208 RID: 49672 RVA: 0x001C5428 File Offset: 0x001C3628
		public override EActorFxEmoteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorFxEmoteType.Play;
			}
			return EActorFxEmoteTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C209 RID: 49673 RVA: 0x001C544C File Offset: 0x001C364C
		public override void Write(Utf8JsonWriter writer, EActorFxEmoteType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
