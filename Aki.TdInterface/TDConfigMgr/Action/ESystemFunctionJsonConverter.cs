using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026EB RID: 9963
	public class ESystemFunctionJsonConverter : JsonConverter<ESystemFunction>
	{
		// Token: 0x0600D67D RID: 54909 RVA: 0x001F28C4 File Offset: 0x001F0AC4
		public override ESystemFunction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESystemFunction.BuyGoods;
			}
			return ESystemFunctionExtensions.FromString(@string);
		}

		// Token: 0x0600D67E RID: 54910 RVA: 0x001F28E8 File Offset: 0x001F0AE8
		public override void Write(Utf8JsonWriter writer, ESystemFunction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
