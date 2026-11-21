using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A58 RID: 2648
	public class EMotorAutoEjectTypeJsonConverter : JsonConverter<EMotorAutoEjectType>
	{
		// Token: 0x06003AA0 RID: 15008 RVA: 0x00097408 File Offset: 0x00095608
		public override EMotorAutoEjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorAutoEjectType.NextHook;
			}
			return EMotorAutoEjectTypeExtensions.FromString(@string);
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x0009742C File Offset: 0x0009562C
		public override void Write(Utf8JsonWriter writer, EMotorAutoEjectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
