using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002693 RID: 9875
	public class ESceneActorEventTypeJsonConverter : JsonConverter<ESceneActorEventType>
	{
		// Token: 0x0600D4F1 RID: 54513 RVA: 0x001EED64 File Offset: 0x001ECF64
		public override ESceneActorEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneActorEventType.PlayMusicPlants;
			}
			return ESceneActorEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4F2 RID: 54514 RVA: 0x001EED88 File Offset: 0x001ECF88
		public override void Write(Utf8JsonWriter writer, ESceneActorEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
