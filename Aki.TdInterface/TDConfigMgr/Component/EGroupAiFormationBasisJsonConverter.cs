using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095B RID: 2395
	public class EGroupAiFormationBasisJsonConverter : JsonConverter<EGroupAiFormationBasis>
	{
		// Token: 0x060035CC RID: 13772 RVA: 0x0008C298 File Offset: 0x0008A498
		public override EGroupAiFormationBasis Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupAiFormationBasis.Spline;
			}
			return EGroupAiFormationBasisExtensions.FromString(@string);
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0008C2BC File Offset: 0x0008A4BC
		public override void Write(Utf8JsonWriter writer, EGroupAiFormationBasis value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
