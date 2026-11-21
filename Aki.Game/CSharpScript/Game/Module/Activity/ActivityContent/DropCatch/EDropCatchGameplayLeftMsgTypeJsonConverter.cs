using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005627 RID: 22055
	public class EDropCatchGameplayLeftMsgTypeJsonConverter : JsonConverter<EDropCatchGameplayLeftMsgType>
	{
		// Token: 0x06036868 RID: 223336 RVA: 0x00F37DA8 File Offset: 0x00F35FA8
		public override EDropCatchGameplayLeftMsgType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchGameplayLeftMsgType.Gameplay;
			}
			return EDropCatchGameplayLeftMsgTypeExtensions.FromString(@string);
		}

		// Token: 0x06036869 RID: 223337 RVA: 0x00F37DCC File Offset: 0x00F35FCC
		public override void Write(Utf8JsonWriter writer, EDropCatchGameplayLeftMsgType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
