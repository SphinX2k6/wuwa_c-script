using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001685 RID: 5765
	public class IDisableSkillOperationConverter : JsonConverter<IDisableSkillOperation>
	{
		// Token: 0x060081BD RID: 33213 RVA: 0x001374E1 File Offset: 0x001356E1
		[return: Nullable(2)]
		public override IDisableSkillOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableSkillOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableSkillOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x001374EF File Offset: 0x001356EF
		public override void Write(Utf8JsonWriter writer, IDisableSkillOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableSkillOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
