using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090F RID: 2319
	public class EConfigComponentJsonConverter : JsonConverter<EConfigComponent>
	{
		// Token: 0x06003476 RID: 13430 RVA: 0x000897C8 File Offset: 0x000879C8
		public override EConfigComponent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConfigComponent.AirWallSpawnerComponent;
			}
			return EConfigComponentExtensions.FromString(@string);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x000897EC File Offset: 0x000879EC
		public override void Write(Utf8JsonWriter writer, EConfigComponent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
