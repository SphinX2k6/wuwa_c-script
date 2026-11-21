using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A1 RID: 9889
	public class ESetBattleStateTypeJsonConverter : JsonConverter<ESetBattleStateType>
	{
		// Token: 0x0600D530 RID: 54576 RVA: 0x001EF534 File Offset: 0x001ED734
		public override ESetBattleStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetBattleStateType.SetBattleTag;
			}
			return ESetBattleStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D531 RID: 54577 RVA: 0x001EF558 File Offset: 0x001ED758
		public override void Write(Utf8JsonWriter writer, ESetBattleStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
