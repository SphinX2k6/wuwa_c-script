using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F3 RID: 9459
	public class EActionJsonConverter : JsonConverter<EAction>
	{
		// Token: 0x0600CDA1 RID: 52641 RVA: 0x001DCB14 File Offset: 0x001DAD14
		public override EAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAction.Undefined;
			}
			return EActionExtensions.FromString(@string);
		}

		// Token: 0x0600CDA2 RID: 52642 RVA: 0x001DCB38 File Offset: 0x001DAD38
		public override void Write(Utf8JsonWriter writer, EAction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
