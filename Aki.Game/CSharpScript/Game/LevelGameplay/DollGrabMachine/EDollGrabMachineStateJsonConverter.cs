using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006051 RID: 24657
	public class EDollGrabMachineStateJsonConverter : JsonConverter<EDollGrabMachineState>
	{
		// Token: 0x0603B38A RID: 242570 RVA: 0x010C14FC File Offset: 0x010BF6FC
		public override EDollGrabMachineState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDollGrabMachineState.InActive;
			}
			return EDollGrabMachineStateExtensions.FromString(@string);
		}

		// Token: 0x0603B38B RID: 242571 RVA: 0x010C1520 File Offset: 0x010BF720
		public override void Write(Utf8JsonWriter writer, EDollGrabMachineState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
