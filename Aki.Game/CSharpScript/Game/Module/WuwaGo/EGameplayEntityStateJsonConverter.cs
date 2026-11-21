using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200364F RID: 13903
	public class EGameplayEntityStateJsonConverter : JsonConverter<EGameplayEntityState>
	{
		// Token: 0x06024117 RID: 147735 RVA: 0x00A352E4 File Offset: 0x00A334E4
		public override EGameplayEntityState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGameplayEntityState.Locked;
			}
			return EGameplayEntityStateExtensions.FromString(@string);
		}

		// Token: 0x06024118 RID: 147736 RVA: 0x00A35308 File Offset: 0x00A33508
		public override void Write(Utf8JsonWriter writer, EGameplayEntityState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
