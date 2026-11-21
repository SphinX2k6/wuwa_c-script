using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E5F RID: 20063
	public class AutoPilotDefine_EAutoPilotResourceIdJsonConverter : JsonConverter<AutoPilotDefine.EAutoPilotResourceId>
	{
		// Token: 0x060327FC RID: 206844 RVA: 0x00E2A980 File Offset: 0x00E28B80
		public override AutoPilotDefine.EAutoPilotResourceId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return AutoPilotDefine.EAutoPilotResourceId.AutoPilotNavBtn;
			}
			return AutoPilotDefine_EAutoPilotResourceIdExtensions.FromString(@string);
		}

		// Token: 0x060327FD RID: 206845 RVA: 0x00E2A9A4 File Offset: 0x00E28BA4
		public override void Write(Utf8JsonWriter writer, AutoPilotDefine.EAutoPilotResourceId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
