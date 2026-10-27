using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246E RID: 9326
	public class ETextHorizontalJsonConverter : JsonConverter<ETextHorizontal>
	{
		// Token: 0x0600CA6F RID: 51823 RVA: 0x001DCC6C File Offset: 0x001DAE6C
		public override ETextHorizontal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETextHorizontal.Left;
			}
			return ETextHorizontalExtensions.FromString(@string);
		}

		// Token: 0x0600CA70 RID: 51824 RVA: 0x001DCC90 File Offset: 0x001DAE90
		public override void Write(Utf8JsonWriter writer, ETextHorizontal value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
