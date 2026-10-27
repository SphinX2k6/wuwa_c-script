using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231E RID: 8990
	public class EEnableSubLevelTransitionTypeJsonConverter : JsonConverter<EEnableSubLevelTransitionType>
	{
		// Token: 0x0600C487 RID: 50311 RVA: 0x001CAF8C File Offset: 0x001C918C
		public override EEnableSubLevelTransitionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnableSubLevelTransitionType.SceneCapture;
			}
			return EEnableSubLevelTransitionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C488 RID: 50312 RVA: 0x001CAFB0 File Offset: 0x001C91B0
		public override void Write(Utf8JsonWriter writer, EEnableSubLevelTransitionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
