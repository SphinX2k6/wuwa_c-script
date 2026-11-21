using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006053 RID: 24659
	public class EDollGrabMachineEndReasonJsonConverter : JsonConverter<EDollGrabMachineEndReason>
	{
		// Token: 0x0603B393 RID: 242579 RVA: 0x010C1684 File Offset: 0x010BF884
		public override EDollGrabMachineEndReason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDollGrabMachineEndReason.TimeUp;
			}
			return EDollGrabMachineEndReasonExtensions.FromString(@string);
		}

		// Token: 0x0603B394 RID: 242580 RVA: 0x010C16A8 File Offset: 0x010BF8A8
		public override void Write(Utf8JsonWriter writer, EDollGrabMachineEndReason value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
