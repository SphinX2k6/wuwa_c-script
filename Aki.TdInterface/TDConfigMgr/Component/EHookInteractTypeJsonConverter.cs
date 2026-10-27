using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000967 RID: 2407
	public class EHookInteractTypeJsonConverter : JsonConverter<EHookInteractType>
	{
		// Token: 0x06003602 RID: 13826 RVA: 0x0008D0CC File Offset: 0x0008B2CC
		public override EHookInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHookInteractType.FixedPointHook;
			}
			return EHookInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x0008D0F0 File Offset: 0x0008B2F0
		public override void Write(Utf8JsonWriter writer, EHookInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
