using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066C9 RID: 26313
	public class EDropCatchResourceIdJsonConverter : JsonConverter<EDropCatchResourceId>
	{
		// Token: 0x06041CDD RID: 269533 RVA: 0x00FF5AE0 File Offset: 0x00FF3CE0
		public override EDropCatchResourceId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchResourceId.DropItem;
			}
			return EDropCatchResourceIdExtensions.FromString(@string);
		}

		// Token: 0x06041CDE RID: 269534 RVA: 0x00FF5B04 File Offset: 0x00FF3D04
		public override void Write(Utf8JsonWriter writer, EDropCatchResourceId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
