using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096F RID: 2415
	public class EInhaledPerResultTypeJsonConverter : JsonConverter<EInhaledPerResultType>
	{
		// Token: 0x06003626 RID: 13862 RVA: 0x0008D4E4 File Offset: 0x0008B6E4
		public override EInhaledPerResultType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInhaledPerResultType.DestroySelf;
			}
			return EInhaledPerResultTypeExtensions.FromString(@string);
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x0008D508 File Offset: 0x0008B708
		public override void Write(Utf8JsonWriter writer, EInhaledPerResultType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
