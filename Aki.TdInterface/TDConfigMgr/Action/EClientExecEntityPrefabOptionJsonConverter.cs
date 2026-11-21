using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002553 RID: 9555
	public class EClientExecEntityPrefabOptionJsonConverter : JsonConverter<EClientExecEntityPrefabOption>
	{
		// Token: 0x0600CF51 RID: 53073 RVA: 0x001E0E08 File Offset: 0x001DF008
		public override EClientExecEntityPrefabOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientExecEntityPrefabOption.ModifyPrefabParams;
			}
			return EClientExecEntityPrefabOptionExtensions.FromString(@string);
		}

		// Token: 0x0600CF52 RID: 53074 RVA: 0x001E0E2C File Offset: 0x001DF02C
		public override void Write(Utf8JsonWriter writer, EClientExecEntityPrefabOption value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
