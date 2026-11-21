using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1A RID: 2586
	public class EHookInteractTypeJsonConverter : JsonConverter<EHookInteractType>
	{
		// Token: 0x06003989 RID: 14729 RVA: 0x00095038 File Offset: 0x00093238
		public override EHookInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHookInteractType.FixedPointHook;
			}
			return EHookInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x0009505C File Offset: 0x0009325C
		public override void Write(Utf8JsonWriter writer, EHookInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
