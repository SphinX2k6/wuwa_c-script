using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A42 RID: 2626
	public class ELiftBuffTypeJsonConverter : JsonConverter<ELiftBuffType>
	{
		// Token: 0x06003A3D RID: 14909 RVA: 0x000966C4 File Offset: 0x000948C4
		public override ELiftBuffType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiftBuffType.DefaultLiftBuff;
			}
			return ELiftBuffTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x000966E8 File Offset: 0x000948E8
		public override void Write(Utf8JsonWriter writer, ELiftBuffType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
