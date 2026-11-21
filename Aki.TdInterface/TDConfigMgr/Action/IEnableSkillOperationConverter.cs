using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200168F RID: 5775
	public class IEnableSkillOperationConverter : JsonConverter<IEnableSkillOperation>
	{
		// Token: 0x060081DB RID: 33243 RVA: 0x00137653 File Offset: 0x00135853
		[return: Nullable(2)]
		public override IEnableSkillOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableSkillOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableSkillOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x00137661 File Offset: 0x00135861
		public override void Write(Utf8JsonWriter writer, IEnableSkillOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableSkillOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
