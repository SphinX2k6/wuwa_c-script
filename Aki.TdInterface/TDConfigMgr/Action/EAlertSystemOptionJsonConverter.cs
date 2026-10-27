using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A0 RID: 8864
	public class EAlertSystemOptionJsonConverter : JsonConverter<EAlertSystemOption>
	{
		// Token: 0x0600C250 RID: 49744 RVA: 0x001C649C File Offset: 0x001C469C
		public override EAlertSystemOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAlertSystemOption.EnableAlertArea;
			}
			return EAlertSystemOptionExtensions.FromString(@string);
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x001C64C0 File Offset: 0x001C46C0
		public override void Write(Utf8JsonWriter writer, EAlertSystemOption value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
