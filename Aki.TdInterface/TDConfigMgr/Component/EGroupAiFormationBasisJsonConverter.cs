using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0E RID: 2574
	public class EGroupAiFormationBasisJsonConverter : JsonConverter<EGroupAiFormationBasis>
	{
		// Token: 0x06003953 RID: 14675 RVA: 0x000941EC File Offset: 0x000923EC
		public override EGroupAiFormationBasis Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupAiFormationBasis.Spline;
			}
			return EGroupAiFormationBasisExtensions.FromString(@string);
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00094210 File Offset: 0x00092410
		public override void Write(Utf8JsonWriter writer, EGroupAiFormationBasis value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
