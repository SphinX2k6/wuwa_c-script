using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F7 RID: 9719
	public class ELiveParamTypeJsonConverter : JsonConverter<ELiveParamType>
	{
		// Token: 0x0600D233 RID: 53811 RVA: 0x001E8F84 File Offset: 0x001E7184
		public override ELiveParamType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveParamType.Heat;
			}
			return ELiveParamTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D234 RID: 53812 RVA: 0x001E8FA8 File Offset: 0x001E71A8
		public override void Write(Utf8JsonWriter writer, ELiveParamType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
