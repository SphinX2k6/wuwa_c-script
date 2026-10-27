using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231A RID: 8986
	public class EEnableClientFunctionTypeJsonConverter : JsonConverter<EEnableClientFunctionType>
	{
		// Token: 0x0600C475 RID: 50293 RVA: 0x001CAD58 File Offset: 0x001C8F58
		public override EEnableClientFunctionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnableClientFunctionType.HealthBarDisplay;
			}
			return EEnableClientFunctionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C476 RID: 50294 RVA: 0x001CAD7C File Offset: 0x001C8F7C
		public override void Write(Utf8JsonWriter writer, EEnableClientFunctionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
