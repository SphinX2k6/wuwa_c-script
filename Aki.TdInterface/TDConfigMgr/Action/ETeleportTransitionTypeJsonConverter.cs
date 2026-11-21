using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002709 RID: 9993
	public class ETeleportTransitionTypeJsonConverter : JsonConverter<ETeleportTransitionType>
	{
		// Token: 0x0600D704 RID: 55044 RVA: 0x001F68E8 File Offset: 0x001F4AE8
		public override ETeleportTransitionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleportTransitionType.PlayMp4;
			}
			return ETeleportTransitionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D705 RID: 55045 RVA: 0x001F690C File Offset: 0x001F4B0C
		public override void Write(Utf8JsonWriter writer, ETeleportTransitionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
