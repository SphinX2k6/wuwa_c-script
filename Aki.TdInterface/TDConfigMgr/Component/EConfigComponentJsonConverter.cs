using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BC RID: 2492
	public class EConfigComponentJsonConverter : JsonConverter<EConfigComponent>
	{
		// Token: 0x060037E2 RID: 14306 RVA: 0x00091348 File Offset: 0x0008F548
		public override EConfigComponent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConfigComponent.AirWallSpawnerComponent;
			}
			return EConfigComponentExtensions.FromString(@string);
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x0009136C File Offset: 0x0008F56C
		public override void Write(Utf8JsonWriter writer, EConfigComponent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
