using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245C RID: 9308
	public class ETalkOptionParamTypeJsonConverter : JsonConverter<ETalkOptionParamType>
	{
		// Token: 0x0600CA1E RID: 51742 RVA: 0x001DBCA4 File Offset: 0x001D9EA4
		public override ETalkOptionParamType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkOptionParamType.QteSucceed;
			}
			return ETalkOptionParamTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA1F RID: 51743 RVA: 0x001DBCC8 File Offset: 0x001D9EC8
		public override void Write(Utf8JsonWriter writer, ETalkOptionParamType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
