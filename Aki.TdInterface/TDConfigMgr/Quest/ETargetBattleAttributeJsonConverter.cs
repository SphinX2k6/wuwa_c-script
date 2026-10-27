using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200129F RID: 4767
	public class ETargetBattleAttributeJsonConverter : JsonConverter<ETargetBattleAttribute>
	{
		// Token: 0x06006B74 RID: 27508 RVA: 0x001022D0 File Offset: 0x001004D0
		public override ETargetBattleAttribute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetBattleAttribute.Player;
			}
			return ETargetBattleAttributeExtensions.FromString(@string);
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x001022F4 File Offset: 0x001004F4
		public override void Write(Utf8JsonWriter writer, ETargetBattleAttribute value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
