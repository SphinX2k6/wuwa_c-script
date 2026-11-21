using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026DB RID: 9947
	public class ESubScreenPushDirectionJsonConverter : JsonConverter<ESubScreenPushDirection>
	{
		// Token: 0x0600D635 RID: 54837 RVA: 0x001F20C0 File Offset: 0x001F02C0
		public override ESubScreenPushDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubScreenPushDirection.Left;
			}
			return ESubScreenPushDirectionExtensions.FromString(@string);
		}

		// Token: 0x0600D636 RID: 54838 RVA: 0x001F20E4 File Offset: 0x001F02E4
		public override void Write(Utf8JsonWriter writer, ESubScreenPushDirection value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
