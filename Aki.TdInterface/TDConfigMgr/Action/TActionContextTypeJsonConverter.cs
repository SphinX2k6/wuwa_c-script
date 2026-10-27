using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C0 RID: 9408
	public class TActionContextTypeJsonConverter : JsonConverter<TActionContextType>
	{
		// Token: 0x0600CBE0 RID: 52192 RVA: 0x001E0604 File Offset: 0x001DE804
		public override TActionContextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TActionContextType.commonBt;
			}
			return TActionContextTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CBE1 RID: 52193 RVA: 0x001E0628 File Offset: 0x001DE828
		public override void Write(Utf8JsonWriter writer, TActionContextType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
