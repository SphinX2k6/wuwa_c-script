using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001534 RID: 5428
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEnableSkillOperationConverter : JsonConverter<IEnableSkillOperation>
	{
		// Token: 0x06007B0A RID: 31498 RVA: 0x001287B5 File Offset: 0x001269B5
		[return: Nullable(2)]
		public override IEnableSkillOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableSkillOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableSkillOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x001287C3 File Offset: 0x001269C3
		public override void Write(Utf8JsonWriter writer, IEnableSkillOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableSkillOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
