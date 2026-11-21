using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001684 RID: 5764
	public class IDisableSectionalSkillOperationConverter : JsonConverter<IDisableSectionalSkillOperation>
	{
		// Token: 0x060081BA RID: 33210 RVA: 0x001374BC File Offset: 0x001356BC
		[return: Nullable(2)]
		public override IDisableSectionalSkillOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableSectionalSkillOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableSectionalSkillOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x001374CA File Offset: 0x001356CA
		public override void Write(Utf8JsonWriter writer, IDisableSectionalSkillOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableSectionalSkillOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
