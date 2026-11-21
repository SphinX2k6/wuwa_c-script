using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A18 RID: 2584
	public class EHookFetchMoveModeJsonConverter : JsonConverter<EHookFetchMoveMode>
	{
		// Token: 0x06003980 RID: 14720 RVA: 0x00094994 File Offset: 0x00092B94
		public override EHookFetchMoveMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHookFetchMoveMode.Uniform;
			}
			return EHookFetchMoveModeExtensions.FromString(@string);
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x000949B8 File Offset: 0x00092BB8
		public override void Write(Utf8JsonWriter writer, EHookFetchMoveMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
