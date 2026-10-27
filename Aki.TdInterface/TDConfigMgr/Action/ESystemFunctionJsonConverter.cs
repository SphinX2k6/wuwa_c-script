using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200244A RID: 9290
	public class ESystemFunctionJsonConverter : JsonConverter<ESystemFunction>
	{
		// Token: 0x0600C9CD RID: 51661 RVA: 0x001D89FC File Offset: 0x001D6BFC
		public override ESystemFunction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESystemFunction.BuyGoods;
			}
			return ESystemFunctionExtensions.FromString(@string);
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x001D8A20 File Offset: 0x001D6C20
		public override void Write(Utf8JsonWriter writer, ESystemFunction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
