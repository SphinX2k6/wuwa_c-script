using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4E RID: 2638
	public class EMechHookInteractTypeJsonConverter : JsonConverter<EMechHookInteractType>
	{
		// Token: 0x06003A73 RID: 14963 RVA: 0x00096DF4 File Offset: 0x00094FF4
		public override EMechHookInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMechHookInteractType.FixedPointHook;
			}
			return EMechHookInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00096E18 File Offset: 0x00095018
		public override void Write(Utf8JsonWriter writer, EMechHookInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
