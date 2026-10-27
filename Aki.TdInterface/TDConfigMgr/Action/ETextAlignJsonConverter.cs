using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246C RID: 9324
	public class ETextAlignJsonConverter : JsonConverter<ETextAlign>
	{
		// Token: 0x0600CA66 RID: 51814 RVA: 0x001DCB14 File Offset: 0x001DAD14
		public override ETextAlign Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETextAlign.Top;
			}
			return ETextAlignExtensions.FromString(@string);
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x001DCB38 File Offset: 0x001DAD38
		public override void Write(Utf8JsonWriter writer, ETextAlign value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
