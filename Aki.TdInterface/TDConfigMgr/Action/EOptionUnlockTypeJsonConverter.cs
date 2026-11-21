using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200264D RID: 9805
	public class EOptionUnlockTypeJsonConverter : JsonConverter<EOptionUnlockType>
	{
		// Token: 0x0600D3B6 RID: 54198 RVA: 0x001EC20C File Offset: 0x001EA40C
		public override EOptionUnlockType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOptionUnlockType.OnMecha;
			}
			return EOptionUnlockTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3B7 RID: 54199 RVA: 0x001EC230 File Offset: 0x001EA430
		public override void Write(Utf8JsonWriter writer, EOptionUnlockType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
