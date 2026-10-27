using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002384 RID: 9092
	public class EModifyActorMaterialTypeJsonConverter : JsonConverter<EModifyActorMaterialType>
	{
		// Token: 0x0600C652 RID: 50770 RVA: 0x001D0D74 File Offset: 0x001CEF74
		public override EModifyActorMaterialType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EModifyActorMaterialType.ChangeMaterialData;
			}
			return EModifyActorMaterialTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C653 RID: 50771 RVA: 0x001D0D98 File Offset: 0x001CEF98
		public override void Write(Utf8JsonWriter writer, EModifyActorMaterialType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
