using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002296 RID: 8854
	public class EActorVisibilityPlayModeJsonConverter : JsonConverter<EActorVisibilityPlayMode>
	{
		// Token: 0x0600C223 RID: 49699 RVA: 0x001C5C3C File Offset: 0x001C3E3C
		public override EActorVisibilityPlayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorVisibilityPlayMode.FadeIn;
			}
			return EActorVisibilityPlayModeExtensions.FromString(@string);
		}

		// Token: 0x0600C224 RID: 49700 RVA: 0x001C5C60 File Offset: 0x001C3E60
		public override void Write(Utf8JsonWriter writer, EActorVisibilityPlayMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
