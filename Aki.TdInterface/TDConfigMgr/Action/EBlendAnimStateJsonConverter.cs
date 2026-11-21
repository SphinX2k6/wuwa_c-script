using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200252D RID: 9517
	public class EBlendAnimStateJsonConverter : JsonConverter<EBlendAnimState>
	{
		// Token: 0x0600CEA6 RID: 52902 RVA: 0x001DF670 File Offset: 0x001DD870
		public override EBlendAnimState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBlendAnimState.CombatIdle;
			}
			return EBlendAnimStateExtensions.FromString(@string);
		}

		// Token: 0x0600CEA7 RID: 52903 RVA: 0x001DF694 File Offset: 0x001DD894
		public override void Write(Utf8JsonWriter writer, EBlendAnimState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
