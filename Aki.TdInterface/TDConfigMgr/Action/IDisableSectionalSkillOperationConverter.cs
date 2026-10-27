using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200152A RID: 5418
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableSectionalSkillOperationConverter : JsonConverter<IDisableSectionalSkillOperation>
	{
		// Token: 0x06007AEC RID: 31468 RVA: 0x00128643 File Offset: 0x00126843
		[return: Nullable(2)]
		public override IDisableSectionalSkillOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableSectionalSkillOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableSectionalSkillOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AED RID: 31469 RVA: 0x00128651 File Offset: 0x00126851
		public override void Write(Utf8JsonWriter writer, IDisableSectionalSkillOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableSectionalSkillOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
