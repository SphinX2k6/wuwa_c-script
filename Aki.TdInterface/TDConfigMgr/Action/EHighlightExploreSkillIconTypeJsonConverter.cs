using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002356 RID: 9046
	public class EHighlightExploreSkillIconTypeJsonConverter : JsonConverter<EHighlightExploreSkillIconType>
	{
		// Token: 0x0600C583 RID: 50563 RVA: 0x001CD400 File Offset: 0x001CB600
		public override EHighlightExploreSkillIconType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHighlightExploreSkillIconType.Show;
			}
			return EHighlightExploreSkillIconTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C584 RID: 50564 RVA: 0x001CD424 File Offset: 0x001CB624
		public override void Write(Utf8JsonWriter writer, EHighlightExploreSkillIconType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
