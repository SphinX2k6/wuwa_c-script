using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066D7 RID: 26327
	public class EDropCatchGameplayLeftMsgTypeJsonConverter : JsonConverter<EDropCatchGameplayLeftMsgType>
	{
		// Token: 0x06041D1C RID: 269596 RVA: 0x00FF69A4 File Offset: 0x00FF4BA4
		public override EDropCatchGameplayLeftMsgType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchGameplayLeftMsgType.Gameplay;
			}
			return EDropCatchGameplayLeftMsgTypeExtensions.FromString(@string);
		}

		// Token: 0x06041D1D RID: 269597 RVA: 0x00FF69C8 File Offset: 0x00FF4BC8
		public override void Write(Utf8JsonWriter writer, EDropCatchGameplayLeftMsgType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
