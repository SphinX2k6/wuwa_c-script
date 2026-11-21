using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200254F RID: 9551
	public class EClientEventTargetJsonConverter : JsonConverter<EClientEventTarget>
	{
		// Token: 0x0600CF3F RID: 53055 RVA: 0x001E0C18 File Offset: 0x001DEE18
		public override EClientEventTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientEventTarget.Self;
			}
			return EClientEventTargetExtensions.FromString(@string);
		}

		// Token: 0x0600CF40 RID: 53056 RVA: 0x001E0C3C File Offset: 0x001DEE3C
		public override void Write(Utf8JsonWriter writer, EClientEventTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
