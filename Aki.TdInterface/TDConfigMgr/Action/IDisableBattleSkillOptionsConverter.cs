using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001523 RID: 5411
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableBattleSkillOptionsConverter : JsonConverter<IDisableBattleSkillOptions>
	{
		// Token: 0x06007AD7 RID: 31447 RVA: 0x00128540 File Offset: 0x00126740
		[return: Nullable(2)]
		public override IDisableBattleSkillOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableBattleSkillOptions.CreateFromSetValue(JsonSerializer.Deserialize<IDisableBattleSkillOptions_SetValue>(ref reader, options));
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x0012854E File Offset: 0x0012674E
		public override void Write(Utf8JsonWriter writer, IDisableBattleSkillOptions value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableBattleSkillOptions_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
