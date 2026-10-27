using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002328 RID: 9000
	public class EExecBattleActionTypeJsonConverter : JsonConverter<EExecBattleActionType>
	{
		// Token: 0x0600C4B4 RID: 50356 RVA: 0x001CB610 File Offset: 0x001C9810
		public override EExecBattleActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExecBattleActionType.SetBattleTags;
			}
			return EExecBattleActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x001CB634 File Offset: 0x001C9834
		public override void Write(Utf8JsonWriter writer, EExecBattleActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
