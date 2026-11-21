using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002689 RID: 9865
	public class EResetPresentationTypeJsonConverter : JsonConverter<EResetPresentationType>
	{
		// Token: 0x0600D4C4 RID: 54468 RVA: 0x001EE7B8 File Offset: 0x001EC9B8
		public override EResetPresentationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResetPresentationType.Failure;
			}
			return EResetPresentationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x001EE7DC File Offset: 0x001EC9DC
		public override void Write(Utf8JsonWriter writer, EResetPresentationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
