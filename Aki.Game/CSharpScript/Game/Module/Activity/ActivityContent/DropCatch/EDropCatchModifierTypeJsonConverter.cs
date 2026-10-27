using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066D3 RID: 26323
	public class EDropCatchModifierTypeJsonConverter : JsonConverter<EDropCatchModifierType>
	{
		// Token: 0x06041D0A RID: 269578 RVA: 0x00FF67B4 File Offset: 0x00FF49B4
		public override EDropCatchModifierType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchModifierType.Override;
			}
			return EDropCatchModifierTypeExtensions.FromString(@string);
		}

		// Token: 0x06041D0B RID: 269579 RVA: 0x00FF67D8 File Offset: 0x00FF49D8
		public override void Write(Utf8JsonWriter writer, EDropCatchModifierType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
