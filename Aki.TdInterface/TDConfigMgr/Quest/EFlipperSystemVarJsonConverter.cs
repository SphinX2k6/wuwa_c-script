using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001245 RID: 4677
	public class EFlipperSystemVarJsonConverter : JsonConverter<EFlipperSystemVar>
	{
		// Token: 0x060069DF RID: 27103 RVA: 0x000FD9C8 File Offset: 0x000FBBC8
		public override EFlipperSystemVar Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFlipperSystemVar.LifeRemain;
			}
			return EFlipperSystemVarExtensions.FromString(@string);
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x000FD9EC File Offset: 0x000FBBEC
		public override void Write(Utf8JsonWriter writer, EFlipperSystemVar value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
