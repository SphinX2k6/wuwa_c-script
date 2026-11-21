using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002599 RID: 9625
	public class EExecBattleActionTypeJsonConverter : JsonConverter<EExecBattleActionType>
	{
		// Token: 0x0600D08C RID: 53388 RVA: 0x001E3688 File Offset: 0x001E1888
		public override EExecBattleActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExecBattleActionType.SetBattleTags;
			}
			return EExecBattleActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D08D RID: 53389 RVA: 0x001E36AC File Offset: 0x001E18AC
		public override void Write(Utf8JsonWriter writer, EExecBattleActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
