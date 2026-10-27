using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006ED1 RID: 28369
	public class EDollGrabMachineStateJsonConverter : JsonConverter<EDollGrabMachineState>
	{
		// Token: 0x060451E1 RID: 283105 RVA: 0x0111776C File Offset: 0x0111596C
		public override EDollGrabMachineState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDollGrabMachineState.InActive;
			}
			return EDollGrabMachineStateExtensions.FromString(@string);
		}

		// Token: 0x060451E2 RID: 283106 RVA: 0x01117790 File Offset: 0x01115990
		public override void Write(Utf8JsonWriter writer, EDollGrabMachineState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
