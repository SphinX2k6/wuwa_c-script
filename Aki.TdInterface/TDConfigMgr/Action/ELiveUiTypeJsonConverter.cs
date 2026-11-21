using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025FB RID: 9723
	public class ELiveUiTypeJsonConverter : JsonConverter<ELiveUiType>
	{
		// Token: 0x0600D245 RID: 53829 RVA: 0x001E927C File Offset: 0x001E747C
		public override ELiveUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveUiType.Start;
			}
			return ELiveUiTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D246 RID: 53830 RVA: 0x001E92A0 File Offset: 0x001E74A0
		public override void Write(Utf8JsonWriter writer, ELiveUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
