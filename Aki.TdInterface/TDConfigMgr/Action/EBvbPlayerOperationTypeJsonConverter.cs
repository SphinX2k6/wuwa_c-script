using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002537 RID: 9527
	public class EBvbPlayerOperationTypeJsonConverter : JsonConverter<EBvbPlayerOperationType>
	{
		// Token: 0x0600CED3 RID: 52947 RVA: 0x001DFE88 File Offset: 0x001DE088
		public override EBvbPlayerOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBvbPlayerOperationType.BvbDeploy;
			}
			return EBvbPlayerOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CED4 RID: 52948 RVA: 0x001DFEAC File Offset: 0x001DE0AC
		public override void Write(Utf8JsonWriter writer, EBvbPlayerOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
