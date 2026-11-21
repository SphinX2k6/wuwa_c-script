using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200167C RID: 5756
	public class IDisableBattleSkillOptionsConverter : JsonConverter<IDisableBattleSkillOptions>
	{
		// Token: 0x060081A2 RID: 33186 RVA: 0x00137394 File Offset: 0x00135594
		[return: Nullable(2)]
		public override IDisableBattleSkillOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableBattleSkillOptions.CreateFromSetValue(JsonSerializer.Deserialize<IDisableBattleSkillOptions_SetValue>(ref reader, options));
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x001373A2 File Offset: 0x001355A2
		public override void Write(Utf8JsonWriter writer, IDisableBattleSkillOptions value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableBattleSkillOptions_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
