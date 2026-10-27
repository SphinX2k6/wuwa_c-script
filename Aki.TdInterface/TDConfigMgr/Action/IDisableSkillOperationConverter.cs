using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200152B RID: 5419
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableSkillOperationConverter : JsonConverter<IDisableSkillOperation>
	{
		// Token: 0x06007AEF RID: 31471 RVA: 0x00128668 File Offset: 0x00126868
		[return: Nullable(2)]
		public override IDisableSkillOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableSkillOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableSkillOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x00128676 File Offset: 0x00126876
		public override void Write(Utf8JsonWriter writer, IDisableSkillOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableSkillOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
