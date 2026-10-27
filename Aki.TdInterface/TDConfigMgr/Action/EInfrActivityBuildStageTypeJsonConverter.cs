using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235C RID: 9052
	public class EInfrActivityBuildStageTypeJsonConverter : JsonConverter<EInfrActivityBuildStageType>
	{
		// Token: 0x0600C59E RID: 50590 RVA: 0x001CD704 File Offset: 0x001CB904
		public override EInfrActivityBuildStageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInfrActivityBuildStageType.Infrastructure;
			}
			return EInfrActivityBuildStageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C59F RID: 50591 RVA: 0x001CD728 File Offset: 0x001CB928
		public override void Write(Utf8JsonWriter writer, EInfrActivityBuildStageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
