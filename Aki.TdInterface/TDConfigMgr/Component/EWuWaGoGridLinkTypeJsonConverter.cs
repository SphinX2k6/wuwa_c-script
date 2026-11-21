using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B12 RID: 2834
	public class EWuWaGoGridLinkTypeJsonConverter : JsonConverter<EWuWaGoGridLinkType>
	{
		// Token: 0x06003DE5 RID: 15845 RVA: 0x0009E654 File Offset: 0x0009C854
		public override EWuWaGoGridLinkType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoGridLinkType.EmptyGrid;
			}
			return EWuWaGoGridLinkTypeExtensions.FromString(@string);
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x0009E678 File Offset: 0x0009C878
		public override void Write(Utf8JsonWriter writer, EWuWaGoGridLinkType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
