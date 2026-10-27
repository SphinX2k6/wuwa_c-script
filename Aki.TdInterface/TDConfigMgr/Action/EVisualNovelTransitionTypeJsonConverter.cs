using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BA RID: 9402
	public class EVisualNovelTransitionTypeJsonConverter : JsonConverter<EVisualNovelTransitionType>
	{
		// Token: 0x0600CBC5 RID: 52165 RVA: 0x001E00EC File Offset: 0x001DE2EC
		public override EVisualNovelTransitionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelTransitionType.Location;
			}
			return EVisualNovelTransitionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CBC6 RID: 52166 RVA: 0x001E0110 File Offset: 0x001DE310
		public override void Write(Utf8JsonWriter writer, EVisualNovelTransitionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
