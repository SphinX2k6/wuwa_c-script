using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1C RID: 2588
	public class EHookLockScreenDetectTypeJsonConverter : JsonConverter<EHookLockScreenDetectType>
	{
		// Token: 0x06003992 RID: 14738 RVA: 0x0009514C File Offset: 0x0009334C
		public override EHookLockScreenDetectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHookLockScreenDetectType.CentralEllipse;
			}
			return EHookLockScreenDetectTypeExtensions.FromString(@string);
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00095170 File Offset: 0x00093370
		public override void Write(Utf8JsonWriter writer, EHookLockScreenDetectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
