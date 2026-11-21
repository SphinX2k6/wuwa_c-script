using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005619 RID: 22041
	public class EDropCatchResourceIdJsonConverter : JsonConverter<EDropCatchResourceId>
	{
		// Token: 0x06036829 RID: 223273 RVA: 0x00F36EE4 File Offset: 0x00F350E4
		public override EDropCatchResourceId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchResourceId.DropItem;
			}
			return EDropCatchResourceIdExtensions.FromString(@string);
		}

		// Token: 0x0603682A RID: 223274 RVA: 0x00F36F08 File Offset: 0x00F35108
		public override void Write(Utf8JsonWriter writer, EDropCatchResourceId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
