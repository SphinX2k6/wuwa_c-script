using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002635 RID: 9781
	public class EMpcEffectParamTypeJsonConverter : JsonConverter<EMpcEffectParamType>
	{
		// Token: 0x0600D34A RID: 54090 RVA: 0x001EB494 File Offset: 0x001E9694
		public override EMpcEffectParamType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMpcEffectParamType.PostProcessVolumeCenterPosition;
			}
			return EMpcEffectParamTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D34B RID: 54091 RVA: 0x001EB4B8 File Offset: 0x001E96B8
		public override void Write(Utf8JsonWriter writer, EMpcEffectParamType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
