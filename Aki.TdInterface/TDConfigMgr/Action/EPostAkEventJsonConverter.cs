using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002673 RID: 9843
	public class EPostAkEventJsonConverter : JsonConverter<EPostAkEvent>
	{
		// Token: 0x0600D461 RID: 54369 RVA: 0x001ED9C4 File Offset: 0x001EBBC4
		public override EPostAkEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPostAkEvent.Global;
			}
			return EPostAkEventExtensions.FromString(@string);
		}

		// Token: 0x0600D462 RID: 54370 RVA: 0x001ED9E8 File Offset: 0x001EBBE8
		public override void Write(Utf8JsonWriter writer, EPostAkEvent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
