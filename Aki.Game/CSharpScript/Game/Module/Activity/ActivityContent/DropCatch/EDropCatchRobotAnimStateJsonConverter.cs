using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066CD RID: 26317
	public class EDropCatchRobotAnimStateJsonConverter : JsonConverter<EDropCatchRobotAnimState>
	{
		// Token: 0x06041CEF RID: 269551 RVA: 0x00FF5F10 File Offset: 0x00FF4110
		public override EDropCatchRobotAnimState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchRobotAnimState.HappyLeft;
			}
			return EDropCatchRobotAnimStateExtensions.FromString(@string);
		}

		// Token: 0x06041CF0 RID: 269552 RVA: 0x00FF5F34 File Offset: 0x00FF4134
		public override void Write(Utf8JsonWriter writer, EDropCatchRobotAnimState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
