using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200260D RID: 9741
	public class EModifyActorMaterialTypeJsonConverter : JsonConverter<EModifyActorMaterialType>
	{
		// Token: 0x0600D296 RID: 53910 RVA: 0x001E9D48 File Offset: 0x001E7F48
		public override EModifyActorMaterialType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EModifyActorMaterialType.ChangeMaterialData;
			}
			return EModifyActorMaterialTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D297 RID: 53911 RVA: 0x001E9D6C File Offset: 0x001E7F6C
		public override void Write(Utf8JsonWriter writer, EModifyActorMaterialType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
