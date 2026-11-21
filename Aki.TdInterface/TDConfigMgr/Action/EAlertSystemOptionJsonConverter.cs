using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200250D RID: 9485
	public class EAlertSystemOptionJsonConverter : JsonConverter<EAlertSystemOption>
	{
		// Token: 0x0600CE16 RID: 52758 RVA: 0x001DE190 File Offset: 0x001DC390
		public override EAlertSystemOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAlertSystemOption.EnableAlertArea;
			}
			return EAlertSystemOptionExtensions.FromString(@string);
		}

		// Token: 0x0600CE17 RID: 52759 RVA: 0x001DE1B4 File Offset: 0x001DC3B4
		public override void Write(Utf8JsonWriter writer, EAlertSystemOption value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
