using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001275 RID: 4725
	public class ERangeLimitingPriorityJsonConverter : JsonConverter<ERangeLimitingPriority>
	{
		// Token: 0x06006AB7 RID: 27319 RVA: 0x000FFF50 File Offset: 0x000FE150
		public override ERangeLimitingPriority Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERangeLimitingPriority.Low;
			}
			return ERangeLimitingPriorityExtensions.FromString(@string);
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x000FFF74 File Offset: 0x000FE174
		public override void Write(Utf8JsonWriter writer, ERangeLimitingPriority value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
