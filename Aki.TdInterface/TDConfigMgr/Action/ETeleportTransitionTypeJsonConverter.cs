using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002468 RID: 9320
	public class ETeleportTransitionTypeJsonConverter : JsonConverter<ETeleportTransitionType>
	{
		// Token: 0x0600CA54 RID: 51796 RVA: 0x001DC834 File Offset: 0x001DAA34
		public override ETeleportTransitionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleportTransitionType.PlayMp4;
			}
			return ETeleportTransitionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA55 RID: 51797 RVA: 0x001DC858 File Offset: 0x001DAA58
		public override void Write(Utf8JsonWriter writer, ETeleportTransitionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
