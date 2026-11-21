using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EC RID: 2540
	public class EExploreSkillInteractTypeJsonConverter : JsonConverter<EExploreSkillInteractType>
	{
		// Token: 0x060038BA RID: 14522 RVA: 0x000930E4 File Offset: 0x000912E4
		public override EExploreSkillInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExploreSkillInteractType.PullGiant;
			}
			return EExploreSkillInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00093108 File Offset: 0x00091308
		public override void Write(Utf8JsonWriter writer, EExploreSkillInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
