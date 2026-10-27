using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DB RID: 2523
	public class EPortalModelJsonConverter : JsonConverter<EPortalModel>
	{
		// Token: 0x0600380C RID: 14348 RVA: 0x00091694 File Offset: 0x0008F894
		public override EPortalModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPortalModel.A;
			}
			return EPortalModelExtensions.FromString(@string);
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x000916B8 File Offset: 0x0008F8B8
		public override void Write(Utf8JsonWriter writer, EPortalModel value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
