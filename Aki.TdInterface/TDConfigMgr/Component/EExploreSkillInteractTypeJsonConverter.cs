using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093F RID: 2367
	public class EExploreSkillInteractTypeJsonConverter : JsonConverter<EExploreSkillInteractType>
	{
		// Token: 0x0600354E RID: 13646 RVA: 0x0008B508 File Offset: 0x00089708
		public override EExploreSkillInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExploreSkillInteractType.PullGiant;
			}
			return EExploreSkillInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x0008B52C File Offset: 0x0008972C
		public override void Write(Utf8JsonWriter writer, EExploreSkillInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
