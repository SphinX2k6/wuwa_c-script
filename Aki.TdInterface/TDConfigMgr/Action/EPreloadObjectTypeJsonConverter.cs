using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DE RID: 9182
	public class EPreloadObjectTypeJsonConverter : JsonConverter<EPreloadObjectType>
	{
		// Token: 0x0600C7E7 RID: 51175 RVA: 0x001D43D0 File Offset: 0x001D25D0
		public override EPreloadObjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPreloadObjectType.PreloadTrialCharacterForSkill;
			}
			return EPreloadObjectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x001D43F4 File Offset: 0x001D25F4
		public override void Write(Utf8JsonWriter writer, EPreloadObjectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
