using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F9 RID: 2553
	public class ERoadNetworkNavigationTypeJsonConverter : JsonConverter<ERoadNetworkNavigationType>
	{
		// Token: 0x06003893 RID: 14483 RVA: 0x0009279C File Offset: 0x0009099C
		public override ERoadNetworkNavigationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoadNetworkNavigationType.Traffic;
			}
			return ERoadNetworkNavigationTypeExtensions.FromString(@string);
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x000927C0 File Offset: 0x000909C0
		public override void Write(Utf8JsonWriter writer, ERoadNetworkNavigationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
