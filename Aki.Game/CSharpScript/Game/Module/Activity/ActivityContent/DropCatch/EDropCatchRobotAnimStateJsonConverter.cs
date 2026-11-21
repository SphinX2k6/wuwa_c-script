using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200561D RID: 22045
	public class EDropCatchRobotAnimStateJsonConverter : JsonConverter<EDropCatchRobotAnimState>
	{
		// Token: 0x0603683B RID: 223291 RVA: 0x00F37314 File Offset: 0x00F35514
		public override EDropCatchRobotAnimState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchRobotAnimState.HappyLeft;
			}
			return EDropCatchRobotAnimStateExtensions.FromString(@string);
		}

		// Token: 0x0603683C RID: 223292 RVA: 0x00F37338 File Offset: 0x00F35538
		public override void Write(Utf8JsonWriter writer, EDropCatchRobotAnimState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
