using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002675 RID: 9845
	public class EPreloadObjectTypeJsonConverter : JsonConverter<EPreloadObjectType>
	{
		// Token: 0x0600D46A RID: 54378 RVA: 0x001EDB7C File Offset: 0x001EBD7C
		public override EPreloadObjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPreloadObjectType.PreloadTrialCharacterForSkill;
			}
			return EPreloadObjectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D46B RID: 54379 RVA: 0x001EDBA0 File Offset: 0x001EBDA0
		public override void Write(Utf8JsonWriter writer, EPreloadObjectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
