using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200092D RID: 2349
	public class EEffectSplineCreateModeJsonConverter : JsonConverter<EEffectSplineCreateMode>
	{
		// Token: 0x060034FD RID: 13565 RVA: 0x0008A6EC File Offset: 0x000888EC
		public override EEffectSplineCreateMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEffectSplineCreateMode.WholeLine;
			}
			return EEffectSplineCreateModeExtensions.FromString(@string);
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x0008A710 File Offset: 0x00088910
		public override void Write(Utf8JsonWriter writer, EEffectSplineCreateMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
