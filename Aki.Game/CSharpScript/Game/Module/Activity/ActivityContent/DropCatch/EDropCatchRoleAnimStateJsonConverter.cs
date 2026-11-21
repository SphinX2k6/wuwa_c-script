using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200561B RID: 22043
	public class EDropCatchRoleAnimStateJsonConverter : JsonConverter<EDropCatchRoleAnimState>
	{
		// Token: 0x06036832 RID: 223282 RVA: 0x00F3718C File Offset: 0x00F3538C
		public override EDropCatchRoleAnimState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchRoleAnimState.IdleBowlLeft;
			}
			return EDropCatchRoleAnimStateExtensions.FromString(@string);
		}

		// Token: 0x06036833 RID: 223283 RVA: 0x00F371B0 File Offset: 0x00F353B0
		public override void Write(Utf8JsonWriter writer, EDropCatchRoleAnimState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
