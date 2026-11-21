using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002503 RID: 9475
	public class EActorVisibilityPlayModeJsonConverter : JsonConverter<EActorVisibilityPlayMode>
	{
		// Token: 0x0600CDE9 RID: 52713 RVA: 0x001DD930 File Offset: 0x001DBB30
		public override EActorVisibilityPlayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorVisibilityPlayMode.FadeIn;
			}
			return EActorVisibilityPlayModeExtensions.FromString(@string);
		}

		// Token: 0x0600CDEA RID: 52714 RVA: 0x001DD954 File Offset: 0x001DBB54
		public override void Write(Utf8JsonWriter writer, EActorVisibilityPlayMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
