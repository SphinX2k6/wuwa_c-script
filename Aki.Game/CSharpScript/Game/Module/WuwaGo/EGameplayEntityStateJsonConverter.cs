using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200471F RID: 18207
	public class EGameplayEntityStateJsonConverter : JsonConverter<EGameplayEntityState>
	{
		// Token: 0x0602F951 RID: 194897 RVA: 0x00B05614 File Offset: 0x00B03814
		public override EGameplayEntityState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGameplayEntityState.Locked;
			}
			return EGameplayEntityStateExtensions.FromString(@string);
		}

		// Token: 0x0602F952 RID: 194898 RVA: 0x00B05638 File Offset: 0x00B03838
		public override void Write(Utf8JsonWriter writer, EGameplayEntityState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
