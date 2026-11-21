using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002607 RID: 9735
	public class EMapMarkStateJsonConverter : JsonConverter<EMapMarkState>
	{
		// Token: 0x0600D27B RID: 53883 RVA: 0x001E993C File Offset: 0x001E7B3C
		public override EMapMarkState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMapMarkState.Show;
			}
			return EMapMarkStateExtensions.FromString(@string);
		}

		// Token: 0x0600D27C RID: 53884 RVA: 0x001E9960 File Offset: 0x001E7B60
		public override void Write(Utf8JsonWriter writer, EMapMarkState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
