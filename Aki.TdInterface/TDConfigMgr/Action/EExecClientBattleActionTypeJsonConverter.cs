using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232A RID: 9002
	public class EExecClientBattleActionTypeJsonConverter : JsonConverter<EExecClientBattleActionType>
	{
		// Token: 0x0600C4BD RID: 50365 RVA: 0x001CB970 File Offset: 0x001C9B70
		public override EExecClientBattleActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExecClientBattleActionType.SendTagEventToControlCharacter;
			}
			return EExecClientBattleActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4BE RID: 50366 RVA: 0x001CB994 File Offset: 0x001C9B94
		public override void Write(Utf8JsonWriter writer, EExecClientBattleActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
