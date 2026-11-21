using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024FB RID: 9467
	public class EActorFxEmoteStopSubTypeJsonConverter : JsonConverter<EActorFxEmoteStopSubType>
	{
		// Token: 0x0600CDC5 RID: 52677 RVA: 0x001DD008 File Offset: 0x001DB208
		public override EActorFxEmoteStopSubType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorFxEmoteStopSubType.StopAll;
			}
			return EActorFxEmoteStopSubTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x001DD02C File Offset: 0x001DB22C
		public override void Write(Utf8JsonWriter writer, EActorFxEmoteStopSubType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
