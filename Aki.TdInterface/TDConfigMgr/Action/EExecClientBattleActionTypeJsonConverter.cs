using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200259B RID: 9627
	public class EExecClientBattleActionTypeJsonConverter : JsonConverter<EExecClientBattleActionType>
	{
		// Token: 0x0600D095 RID: 53397 RVA: 0x001E3A28 File Offset: 0x001E1C28
		public override EExecClientBattleActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExecClientBattleActionType.SendTagEventToControlCharacter;
			}
			return EExecClientBattleActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D096 RID: 53398 RVA: 0x001E3A4C File Offset: 0x001E1C4C
		public override void Write(Utf8JsonWriter writer, EExecClientBattleActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
