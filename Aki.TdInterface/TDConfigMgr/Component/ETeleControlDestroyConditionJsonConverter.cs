using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2F RID: 2607
	public class ETeleControlDestroyConditionJsonConverter : JsonConverter<ETeleControlDestroyCondition>
	{
		// Token: 0x06003986 RID: 14726 RVA: 0x000948E4 File Offset: 0x00092AE4
		public override ETeleControlDestroyCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleControlDestroyCondition.LetGo;
			}
			return ETeleControlDestroyConditionExtensions.FromString(@string);
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00094908 File Offset: 0x00092B08
		public override void Write(Utf8JsonWriter writer, ETeleControlDestroyCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
