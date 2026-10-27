using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001526 RID: 5414
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableExploreSkillConverter : JsonConverter<IDisableExploreSkill>
	{
		// Token: 0x06007AE0 RID: 31456 RVA: 0x001285AF File Offset: 0x001267AF
		[return: Nullable(2)]
		public override IDisableExploreSkill Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableExploreSkill.CreateFromSetValue(JsonSerializer.Deserialize<IDisableExploreSkill_SetValue>(ref reader, options));
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x001285BD File Offset: 0x001267BD
		public override void Write(Utf8JsonWriter writer, IDisableExploreSkill value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableExploreSkill_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
