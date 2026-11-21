using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200167E RID: 5758
	public class IDisableCharacterSectionalSkillOptionConverter : JsonConverter<IDisableCharacterSectionalSkillOption>
	{
		// Token: 0x060081A8 RID: 33192 RVA: 0x001373DE File Offset: 0x001355DE
		[return: Nullable(2)]
		public override IDisableCharacterSectionalSkillOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableCharacterSectionalSkillOption.CreateFromSetValue(JsonSerializer.Deserialize<IDisableCharacterSectionalSkillOption_SetValue>(ref reader, options));
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x001373EC File Offset: 0x001355EC
		public override void Write(Utf8JsonWriter writer, IDisableCharacterSectionalSkillOption value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableCharacterSectionalSkillOption_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
