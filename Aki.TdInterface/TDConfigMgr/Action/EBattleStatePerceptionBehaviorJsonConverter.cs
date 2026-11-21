using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002529 RID: 9513
	public class EBattleStatePerceptionBehaviorJsonConverter : JsonConverter<EBattleStatePerceptionBehavior>
	{
		// Token: 0x0600CE94 RID: 52884 RVA: 0x001DF360 File Offset: 0x001DD560
		public override EBattleStatePerceptionBehavior Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
			}
			return EBattleStatePerceptionBehaviorExtensions.FromString(@string);
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x001DF384 File Offset: 0x001DD584
		public override void Write(Utf8JsonWriter writer, EBattleStatePerceptionBehavior value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
