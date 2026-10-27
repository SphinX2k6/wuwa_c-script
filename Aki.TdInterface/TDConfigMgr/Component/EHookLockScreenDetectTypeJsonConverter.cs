using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000969 RID: 2409
	public class EHookLockScreenDetectTypeJsonConverter : JsonConverter<EHookLockScreenDetectType>
	{
		// Token: 0x0600360B RID: 13835 RVA: 0x0008D1E0 File Offset: 0x0008B3E0
		public override EHookLockScreenDetectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHookLockScreenDetectType.CentralEllipse;
			}
			return EHookLockScreenDetectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x0008D204 File Offset: 0x0008B404
		public override void Write(Utf8JsonWriter writer, EHookLockScreenDetectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
