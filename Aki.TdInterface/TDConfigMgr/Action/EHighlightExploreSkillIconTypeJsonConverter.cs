using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025CB RID: 9675
	public class EHighlightExploreSkillIconTypeJsonConverter : JsonConverter<EHighlightExploreSkillIconType>
	{
		// Token: 0x0600D16D RID: 53613 RVA: 0x001E56E0 File Offset: 0x001E38E0
		public override EHighlightExploreSkillIconType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHighlightExploreSkillIconType.Show;
			}
			return EHighlightExploreSkillIconTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x001E5704 File Offset: 0x001E3904
		public override void Write(Utf8JsonWriter writer, EHighlightExploreSkillIconType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
