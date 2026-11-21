using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DA RID: 2522
	public class EEffectSplineCreateModeJsonConverter : JsonConverter<EEffectSplineCreateMode>
	{
		// Token: 0x06003869 RID: 14441 RVA: 0x0009226C File Offset: 0x0009046C
		public override EEffectSplineCreateMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEffectSplineCreateMode.WholeLine;
			}
			return EEffectSplineCreateModeExtensions.FromString(@string);
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x00092290 File Offset: 0x00090490
		public override void Write(Utf8JsonWriter writer, EEffectSplineCreateMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
