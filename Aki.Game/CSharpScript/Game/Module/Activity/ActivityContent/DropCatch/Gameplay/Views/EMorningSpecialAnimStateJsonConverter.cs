using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02006714 RID: 26388
	public class EMorningSpecialAnimStateJsonConverter : JsonConverter<EMorningSpecialAnimState>
	{
		// Token: 0x06041E76 RID: 269942 RVA: 0x00FFC774 File Offset: 0x00FFA974
		public override EMorningSpecialAnimState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMorningSpecialAnimState.IdleNothingLeft;
			}
			return EMorningSpecialAnimStateExtensions.FromString(@string);
		}

		// Token: 0x06041E77 RID: 269943 RVA: 0x00FFC798 File Offset: 0x00FFA998
		public override void Write(Utf8JsonWriter writer, EMorningSpecialAnimState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
