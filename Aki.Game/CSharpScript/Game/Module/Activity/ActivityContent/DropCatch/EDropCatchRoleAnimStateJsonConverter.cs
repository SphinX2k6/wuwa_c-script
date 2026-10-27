using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066CB RID: 26315
	public class EDropCatchRoleAnimStateJsonConverter : JsonConverter<EDropCatchRoleAnimState>
	{
		// Token: 0x06041CE6 RID: 269542 RVA: 0x00FF5D88 File Offset: 0x00FF3F88
		public override EDropCatchRoleAnimState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchRoleAnimState.IdleBowlLeft;
			}
			return EDropCatchRoleAnimStateExtensions.FromString(@string);
		}

		// Token: 0x06041CE7 RID: 269543 RVA: 0x00FF5DAC File Offset: 0x00FF3FAC
		public override void Write(Utf8JsonWriter writer, EDropCatchRoleAnimState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
