using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B9 RID: 2489
	public class ENpcStandbyShowModeJsonConverter : JsonConverter<ENpcStandbyShowMode>
	{
		// Token: 0x06003773 RID: 14195 RVA: 0x000902C8 File Offset: 0x0008E4C8
		public override ENpcStandbyShowMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcStandbyShowMode.Finite;
			}
			return ENpcStandbyShowModeExtensions.FromString(@string);
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x000902EC File Offset: 0x0008E4EC
		public override void Write(Utf8JsonWriter writer, ENpcStandbyShowMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
