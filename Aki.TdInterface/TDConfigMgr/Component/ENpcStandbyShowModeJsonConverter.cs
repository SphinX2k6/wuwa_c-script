using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A6E RID: 2670
	public class ENpcStandbyShowModeJsonConverter : JsonConverter<ENpcStandbyShowMode>
	{
		// Token: 0x06003B03 RID: 15107 RVA: 0x00098400 File Offset: 0x00096600
		public override ENpcStandbyShowMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcStandbyShowMode.Finite;
			}
			return ENpcStandbyShowModeExtensions.FromString(@string);
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00098424 File Offset: 0x00096624
		public override void Write(Utf8JsonWriter writer, ENpcStandbyShowMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
