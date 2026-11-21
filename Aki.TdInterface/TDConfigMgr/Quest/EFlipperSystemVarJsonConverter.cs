using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001385 RID: 4997
	public class EFlipperSystemVarJsonConverter : JsonConverter<EFlipperSystemVar>
	{
		// Token: 0x06007032 RID: 28722 RVA: 0x0010B5F4 File Offset: 0x001097F4
		public override EFlipperSystemVar Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFlipperSystemVar.LifeRemain;
			}
			return EFlipperSystemVarExtensions.FromString(@string);
		}

		// Token: 0x06007033 RID: 28723 RVA: 0x0010B618 File Offset: 0x00109818
		public override void Write(Utf8JsonWriter writer, EFlipperSystemVar value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
