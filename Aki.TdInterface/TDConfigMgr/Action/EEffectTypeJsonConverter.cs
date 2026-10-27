using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002314 RID: 8980
	public class EEffectTypeJsonConverter : JsonConverter<EEffectType>
	{
		// Token: 0x0600C45A RID: 50266 RVA: 0x001CAA54 File Offset: 0x001C8C54
		public override EEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEffectType.Effect;
			}
			return EEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x001CAA78 File Offset: 0x001C8C78
		public override void Write(Utf8JsonWriter writer, EEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
