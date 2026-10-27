using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228E RID: 8846
	public class EActorFxEmoteStopSubTypeJsonConverter : JsonConverter<EActorFxEmoteStopSubType>
	{
		// Token: 0x0600C1FF RID: 49663 RVA: 0x001C5314 File Offset: 0x001C3514
		public override EActorFxEmoteStopSubType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorFxEmoteStopSubType.StopAll;
			}
			return EActorFxEmoteStopSubTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C200 RID: 49664 RVA: 0x001C5338 File Offset: 0x001C3538
		public override void Write(Utf8JsonWriter writer, EActorFxEmoteStopSubType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
