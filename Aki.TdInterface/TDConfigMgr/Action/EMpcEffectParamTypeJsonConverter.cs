using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AA RID: 9130
	public class EMpcEffectParamTypeJsonConverter : JsonConverter<EMpcEffectParamType>
	{
		// Token: 0x0600C6FD RID: 50941 RVA: 0x001D22F4 File Offset: 0x001D04F4
		public override EMpcEffectParamType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMpcEffectParamType.PostProcessVolumeCenterPosition;
			}
			return EMpcEffectParamTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C6FE RID: 50942 RVA: 0x001D2318 File Offset: 0x001D0518
		public override void Write(Utf8JsonWriter writer, EMpcEffectParamType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
