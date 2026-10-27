using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BA RID: 8890
	public class EBattleStatePerceptionBehaviorJsonConverter : JsonConverter<EBattleStatePerceptionBehavior>
	{
		// Token: 0x0600C2C5 RID: 49861 RVA: 0x001C7558 File Offset: 0x001C5758
		public override EBattleStatePerceptionBehavior Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
			}
			return EBattleStatePerceptionBehaviorExtensions.FromString(@string);
		}

		// Token: 0x0600C2C6 RID: 49862 RVA: 0x001C757C File Offset: 0x001C577C
		public override void Write(Utf8JsonWriter writer, EBattleStatePerceptionBehavior value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
