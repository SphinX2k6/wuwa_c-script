using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA0 RID: 2720
	public class EPortalModelJsonConverter : JsonConverter<EPortalModel>
	{
		// Token: 0x06003BE4 RID: 15332 RVA: 0x00099F54 File Offset: 0x00098154
		public override EPortalModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPortalModel.A;
			}
			return EPortalModelExtensions.FromString(@string);
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x00099F78 File Offset: 0x00098178
		public override void Write(Utf8JsonWriter writer, EPortalModel value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
