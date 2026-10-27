using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023FC RID: 9212
	public class ESceneActorEventTypeJsonConverter : JsonConverter<ESceneActorEventType>
	{
		// Token: 0x0600C86E RID: 51310 RVA: 0x001D55B8 File Offset: 0x001D37B8
		public override ESceneActorEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneActorEventType.PlayMusicPlants;
			}
			return ESceneActorEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C86F RID: 51311 RVA: 0x001D55DC File Offset: 0x001D37DC
		public override void Write(Utf8JsonWriter writer, ESceneActorEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
