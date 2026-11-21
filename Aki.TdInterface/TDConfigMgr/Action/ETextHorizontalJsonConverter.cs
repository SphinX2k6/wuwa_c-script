using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200270F RID: 9999
	public class ETextHorizontalJsonConverter : JsonConverter<ETextHorizontal>
	{
		// Token: 0x0600D71F RID: 55071 RVA: 0x001F6D20 File Offset: 0x001F4F20
		public override ETextHorizontal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETextHorizontal.Left;
			}
			return ETextHorizontalExtensions.FromString(@string);
		}

		// Token: 0x0600D720 RID: 55072 RVA: 0x001F6D44 File Offset: 0x001F4F44
		public override void Write(Utf8JsonWriter writer, ETextHorizontal value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
