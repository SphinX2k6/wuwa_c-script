using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BE RID: 8894
	public class EBlendAnimStateJsonConverter : JsonConverter<EBlendAnimState>
	{
		// Token: 0x0600C2D7 RID: 49879 RVA: 0x001C7868 File Offset: 0x001C5A68
		public override EBlendAnimState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBlendAnimState.CombatIdle;
			}
			return EBlendAnimStateExtensions.FromString(@string);
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x001C788C File Offset: 0x001C5A8C
		public override void Write(Utf8JsonWriter writer, EBlendAnimState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
