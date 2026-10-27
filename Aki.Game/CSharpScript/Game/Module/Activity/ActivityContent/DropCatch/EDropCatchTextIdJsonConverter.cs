using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066C7 RID: 26311
	public class EDropCatchTextIdJsonConverter : JsonConverter<EDropCatchTextId>
	{
		// Token: 0x06041CD4 RID: 269524 RVA: 0x00FF58FC File Offset: 0x00FF3AFC
		public override EDropCatchTextId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchTextId.TextScoreLevel;
			}
			return EDropCatchTextIdExtensions.FromString(@string);
		}

		// Token: 0x06041CD5 RID: 269525 RVA: 0x00FF5920 File Offset: 0x00FF3B20
		public override void Write(Utf8JsonWriter writer, EDropCatchTextId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
