using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002501 RID: 9473
	public class EActorVisibilityEffectTypeJsonConverter : JsonConverter<EActorVisibilityEffectType>
	{
		// Token: 0x0600CDE0 RID: 52704 RVA: 0x001DD81C File Offset: 0x001DBA1C
		public override EActorVisibilityEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorVisibilityEffectType.Default;
			}
			return EActorVisibilityEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CDE1 RID: 52705 RVA: 0x001DD840 File Offset: 0x001DBA40
		public override void Write(Utf8JsonWriter writer, EActorVisibilityEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
