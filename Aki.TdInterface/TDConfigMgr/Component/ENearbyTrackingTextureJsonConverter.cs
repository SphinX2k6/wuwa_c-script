using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AB RID: 2475
	public class ENearbyTrackingTextureJsonConverter : JsonConverter<ENearbyTrackingTexture>
	{
		// Token: 0x06003734 RID: 14132 RVA: 0x0008F9EC File Offset: 0x0008DBEC
		public override ENearbyTrackingTexture Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENearbyTrackingTexture.BigTeleporter;
			}
			return ENearbyTrackingTextureExtensions.FromString(@string);
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0008FA10 File Offset: 0x0008DC10
		public override void Write(Utf8JsonWriter writer, ENearbyTrackingTexture value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
