using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000955 RID: 2389
	public class EGraph3dTypeJsonConverter : JsonConverter<EGraph3dType>
	{
		// Token: 0x060035B1 RID: 13745 RVA: 0x0008BF94 File Offset: 0x0008A194
		public override EGraph3dType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGraph3dType.Normal;
			}
			return EGraph3dTypeExtensions.FromString(@string);
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x0008BFB8 File Offset: 0x0008A1B8
		public override void Write(Utf8JsonWriter writer, EGraph3dType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
