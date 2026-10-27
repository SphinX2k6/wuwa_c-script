using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002312 RID: 8978
	public class EEditFlagJsonConverter : JsonConverter<EEditFlag>
	{
		// Token: 0x0600C451 RID: 50257 RVA: 0x001CA89C File Offset: 0x001C8A9C
		public override EEditFlag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEditFlag.Add;
			}
			return EEditFlagExtensions.FromString(@string);
		}

		// Token: 0x0600C452 RID: 50258 RVA: 0x001CA8C0 File Offset: 0x001C8AC0
		public override void Write(Utf8JsonWriter writer, EEditFlag value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
