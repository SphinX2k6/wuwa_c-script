using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001525 RID: 5413
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableCharacterSectionalSkillOptionConverter : JsonConverter<IDisableCharacterSectionalSkillOption>
	{
		// Token: 0x06007ADD RID: 31453 RVA: 0x0012858A File Offset: 0x0012678A
		[return: Nullable(2)]
		public override IDisableCharacterSectionalSkillOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableCharacterSectionalSkillOption.CreateFromSetValue(JsonSerializer.Deserialize<IDisableCharacterSectionalSkillOption_SetValue>(ref reader, options));
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x00128598 File Offset: 0x00126798
		public override void Write(Utf8JsonWriter writer, IDisableCharacterSectionalSkillOption value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableCharacterSectionalSkillOption_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
