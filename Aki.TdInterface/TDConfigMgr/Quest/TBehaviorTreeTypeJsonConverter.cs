using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001407 RID: 5127
	public class TBehaviorTreeTypeJsonConverter : JsonConverter<TBehaviorTreeType>
	{
		// Token: 0x0600727B RID: 29307 RVA: 0x00112004 File Offset: 0x00110204
		public override TBehaviorTreeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TBehaviorTreeType.BehaviorTreeFragment;
			}
			return TBehaviorTreeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x00112028 File Offset: 0x00110228
		public override void Write(Utf8JsonWriter writer, TBehaviorTreeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
