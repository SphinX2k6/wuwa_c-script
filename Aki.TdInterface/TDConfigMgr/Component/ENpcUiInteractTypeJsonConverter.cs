using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A70 RID: 2672
	public class ENpcUiInteractTypeJsonConverter : JsonConverter<ENpcUiInteractType>
	{
		// Token: 0x06003B0C RID: 15116 RVA: 0x000987B8 File Offset: 0x000969B8
		public override ENpcUiInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcUiInteractType.HandInItem;
			}
			return ENpcUiInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x000987DC File Offset: 0x000969DC
		public override void Write(Utf8JsonWriter writer, ENpcUiInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
