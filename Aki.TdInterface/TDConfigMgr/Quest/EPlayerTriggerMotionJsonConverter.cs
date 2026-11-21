using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013AB RID: 5035
	public class EPlayerTriggerMotionJsonConverter : JsonConverter<EPlayerTriggerMotion>
	{
		// Token: 0x060070DD RID: 28893 RVA: 0x0010D2E4 File Offset: 0x0010B4E4
		public override EPlayerTriggerMotion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerTriggerMotion.GroundSprint;
			}
			return EPlayerTriggerMotionExtensions.FromString(@string);
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x0010D308 File Offset: 0x0010B508
		public override void Write(Utf8JsonWriter writer, EPlayerTriggerMotion value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
