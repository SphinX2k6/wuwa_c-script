using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200258D RID: 9613
	public class EEnableSubLevelTransitionTypeJsonConverter : JsonConverter<EEnableSubLevelTransitionType>
	{
		// Token: 0x0600D056 RID: 53334 RVA: 0x001E2E54 File Offset: 0x001E1054
		public override EEnableSubLevelTransitionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnableSubLevelTransitionType.SceneCapture;
			}
			return EEnableSubLevelTransitionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D057 RID: 53335 RVA: 0x001E2E78 File Offset: 0x001E1078
		public override void Write(Utf8JsonWriter writer, EEnableSubLevelTransitionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
