using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000963 RID: 2403
	public class EHitLogicTypeJsonConverter : JsonConverter<EHitLogicType>
	{
		// Token: 0x060035F0 RID: 13808 RVA: 0x0008C964 File Offset: 0x0008AB64
		public override EHitLogicType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHitLogicType.ChangeNextState;
			}
			return EHitLogicTypeExtensions.FromString(@string);
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0008C988 File Offset: 0x0008AB88
		public override void Write(Utf8JsonWriter writer, EHitLogicType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
