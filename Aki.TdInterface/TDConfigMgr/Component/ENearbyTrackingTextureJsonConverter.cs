using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A60 RID: 2656
	public class ENearbyTrackingTextureJsonConverter : JsonConverter<ENearbyTrackingTexture>
	{
		// Token: 0x06003AC4 RID: 15044 RVA: 0x00097AB0 File Offset: 0x00095CB0
		public override ENearbyTrackingTexture Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENearbyTrackingTexture.BigTeleporter;
			}
			return ENearbyTrackingTextureExtensions.FromString(@string);
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00097AD4 File Offset: 0x00095CD4
		public override void Write(Utf8JsonWriter writer, ENearbyTrackingTexture value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
