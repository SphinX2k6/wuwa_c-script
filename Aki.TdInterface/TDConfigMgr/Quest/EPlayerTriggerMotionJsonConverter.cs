using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126B RID: 4715
	public class EPlayerTriggerMotionJsonConverter : JsonConverter<EPlayerTriggerMotion>
	{
		// Token: 0x06006A8A RID: 27274 RVA: 0x000FF6B8 File Offset: 0x000FD8B8
		public override EPlayerTriggerMotion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerTriggerMotion.GroundSprint;
			}
			return EPlayerTriggerMotionExtensions.FromString(@string);
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x000FF6DC File Offset: 0x000FD8DC
		public override void Write(Utf8JsonWriter writer, EPlayerTriggerMotion value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
