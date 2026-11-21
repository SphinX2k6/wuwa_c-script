using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005664 RID: 22116
	public class EMorningSpecialAnimStateJsonConverter : JsonConverter<EMorningSpecialAnimState>
	{
		// Token: 0x060369C2 RID: 223682 RVA: 0x00F3DB40 File Offset: 0x00F3BD40
		public override EMorningSpecialAnimState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMorningSpecialAnimState.IdleNothingLeft;
			}
			return EMorningSpecialAnimStateExtensions.FromString(@string);
		}

		// Token: 0x060369C3 RID: 223683 RVA: 0x00F3DB64 File Offset: 0x00F3BD64
		public override void Write(Utf8JsonWriter writer, EMorningSpecialAnimState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
