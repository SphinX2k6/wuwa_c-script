using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DC RID: 9180
	public class EPostAkEventJsonConverter : JsonConverter<EPostAkEvent>
	{
		// Token: 0x0600C7DE RID: 51166 RVA: 0x001D4218 File Offset: 0x001D2418
		public override EPostAkEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPostAkEvent.Global;
			}
			return EPostAkEventExtensions.FromString(@string);
		}

		// Token: 0x0600C7DF RID: 51167 RVA: 0x001D423C File Offset: 0x001D243C
		public override void Write(Utf8JsonWriter writer, EPostAkEvent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
