using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000937 RID: 2359
	public class EEntityCategoryJsonConverter : JsonConverter<EEntityCategory>
	{
		// Token: 0x0600352A RID: 13610 RVA: 0x0008ACD0 File Offset: 0x00088ED0
		public override EEntityCategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityCategory.MonsterMatchType;
			}
			return EEntityCategoryExtensions.FromString(@string);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x0008ACF4 File Offset: 0x00088EF4
		public override void Write(Utf8JsonWriter writer, EEntityCategory value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
