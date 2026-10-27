using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C2 RID: 8898
	public class EBlendAnimTypeJsonConverter : JsonConverter<EBlendAnimType>
	{
		// Token: 0x0600C2E9 RID: 49897 RVA: 0x001C7A58 File Offset: 0x001C5C58
		public override EBlendAnimType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBlendAnimType.StateMachine;
			}
			return EBlendAnimTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C2EA RID: 49898 RVA: 0x001C7A7C File Offset: 0x001C5C7C
		public override void Write(Utf8JsonWriter writer, EBlendAnimType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
