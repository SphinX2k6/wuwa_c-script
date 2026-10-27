using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006ED3 RID: 28371
	public class EDollGrabMachineEndReasonJsonConverter : JsonConverter<EDollGrabMachineEndReason>
	{
		// Token: 0x060451EA RID: 283114 RVA: 0x011178F4 File Offset: 0x01115AF4
		public override EDollGrabMachineEndReason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDollGrabMachineEndReason.TimeUp;
			}
			return EDollGrabMachineEndReasonExtensions.FromString(@string);
		}

		// Token: 0x060451EB RID: 283115 RVA: 0x01117918 File Offset: 0x01115B18
		public override void Write(Utf8JsonWriter writer, EDollGrabMachineEndReason value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
