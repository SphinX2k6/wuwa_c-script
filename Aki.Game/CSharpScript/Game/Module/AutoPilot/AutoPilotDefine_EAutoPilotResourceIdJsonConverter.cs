using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E7A RID: 24186
	public class AutoPilotDefine_EAutoPilotResourceIdJsonConverter : JsonConverter<AutoPilotDefine.EAutoPilotResourceId>
	{
		// Token: 0x0603D86C RID: 252012 RVA: 0x00ED93F4 File Offset: 0x00ED75F4
		public override AutoPilotDefine.EAutoPilotResourceId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return AutoPilotDefine.EAutoPilotResourceId.AutoPilotNavBtn;
			}
			return AutoPilotDefine_EAutoPilotResourceIdExtensions.FromString(@string);
		}

		// Token: 0x0603D86D RID: 252013 RVA: 0x00ED9418 File Offset: 0x00ED7618
		public override void Write(Utf8JsonWriter writer, AutoPilotDefine.EAutoPilotResourceId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
