using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E0 RID: 8928
	public class EClientEventTargetJsonConverter : JsonConverter<EClientEventTarget>
	{
		// Token: 0x0600C370 RID: 50032 RVA: 0x001C8E10 File Offset: 0x001C7010
		public override EClientEventTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientEventTarget.Self;
			}
			return EClientEventTargetExtensions.FromString(@string);
		}

		// Token: 0x0600C371 RID: 50033 RVA: 0x001C8E34 File Offset: 0x001C7034
		public override void Write(Utf8JsonWriter writer, EClientEventTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
