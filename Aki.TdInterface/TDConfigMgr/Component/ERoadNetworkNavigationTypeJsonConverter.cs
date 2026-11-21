using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ABE RID: 2750
	public class ERoadNetworkNavigationTypeJsonConverter : JsonConverter<ERoadNetworkNavigationType>
	{
		// Token: 0x06003C6B RID: 15467 RVA: 0x0009B08C File Offset: 0x0009928C
		public override ERoadNetworkNavigationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoadNetworkNavigationType.Traffic;
			}
			return ERoadNetworkNavigationTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x0009B0B0 File Offset: 0x000992B0
		public override void Write(Utf8JsonWriter writer, ERoadNetworkNavigationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
