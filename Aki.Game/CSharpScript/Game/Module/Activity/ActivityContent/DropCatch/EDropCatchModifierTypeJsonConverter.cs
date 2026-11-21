using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005623 RID: 22051
	public class EDropCatchModifierTypeJsonConverter : JsonConverter<EDropCatchModifierType>
	{
		// Token: 0x06036856 RID: 223318 RVA: 0x00F37BB8 File Offset: 0x00F35DB8
		public override EDropCatchModifierType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchModifierType.Override;
			}
			return EDropCatchModifierTypeExtensions.FromString(@string);
		}

		// Token: 0x06036857 RID: 223319 RVA: 0x00F37BDC File Offset: 0x00F35DDC
		public override void Write(Utf8JsonWriter writer, EDropCatchModifierType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
