using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BB RID: 2491
	public class ENpcUiInteractTypeJsonConverter : JsonConverter<ENpcUiInteractType>
	{
		// Token: 0x0600377C RID: 14204 RVA: 0x00090680 File Offset: 0x0008E880
		public override ENpcUiInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcUiInteractType.HandInItem;
			}
			return ENpcUiInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x000906A4 File Offset: 0x0008E8A4
		public override void Write(Utf8JsonWriter writer, ENpcUiInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
