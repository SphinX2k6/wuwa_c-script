using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E4 RID: 2532
	public class EEntityCategoryJsonConverter : JsonConverter<EEntityCategory>
	{
		// Token: 0x06003896 RID: 14486 RVA: 0x00092850 File Offset: 0x00090A50
		public override EEntityCategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityCategory.MonsterMatchType;
			}
			return EEntityCategoryExtensions.FromString(@string);
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00092874 File Offset: 0x00090A74
		public override void Write(Utf8JsonWriter writer, EEntityCategory value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
