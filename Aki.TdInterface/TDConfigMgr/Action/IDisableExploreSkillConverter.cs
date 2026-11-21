using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200167F RID: 5759
	public class IDisableExploreSkillConverter : JsonConverter<IDisableExploreSkill>
	{
		// Token: 0x060081AB RID: 33195 RVA: 0x00137403 File Offset: 0x00135603
		[return: Nullable(2)]
		public override IDisableExploreSkill Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableExploreSkill.CreateFromSetValue(JsonSerializer.Deserialize<IDisableExploreSkill_SetValue>(ref reader, options));
		}

		// Token: 0x060081AC RID: 33196 RVA: 0x00137411 File Offset: 0x00135611
		public override void Write(Utf8JsonWriter writer, IDisableExploreSkill value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableExploreSkill_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
