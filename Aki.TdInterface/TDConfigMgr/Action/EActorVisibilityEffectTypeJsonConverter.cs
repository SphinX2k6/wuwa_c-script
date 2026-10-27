using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002294 RID: 8852
	public class EActorVisibilityEffectTypeJsonConverter : JsonConverter<EActorVisibilityEffectType>
	{
		// Token: 0x0600C21A RID: 49690 RVA: 0x001C5B28 File Offset: 0x001C3D28
		public override EActorVisibilityEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorVisibilityEffectType.Default;
			}
			return EActorVisibilityEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x001C5B4C File Offset: 0x001C3D4C
		public override void Write(Utf8JsonWriter writer, EActorVisibilityEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
