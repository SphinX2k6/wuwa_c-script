using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002402 RID: 9218
	public class ESetBattleStateTypeJsonConverter : JsonConverter<ESetBattleStateType>
	{
		// Token: 0x0600C889 RID: 51337 RVA: 0x001D5938 File Offset: 0x001D3B38
		public override ESetBattleStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetBattleStateType.SetBattleTag;
			}
			return ESetBattleStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x001D595C File Offset: 0x001D3B5C
		public override void Write(Utf8JsonWriter writer, ESetBattleStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
