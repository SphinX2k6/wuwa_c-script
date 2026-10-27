using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012C1 RID: 4801
	public class TBehaviorTreeTypeJsonConverter : JsonConverter<TBehaviorTreeType>
	{
		// Token: 0x06006C0D RID: 27661 RVA: 0x0010403C File Offset: 0x0010223C
		public override TBehaviorTreeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TBehaviorTreeType.BehaviorTreeFragment;
			}
			return TBehaviorTreeTypeExtensions.FromString(@string);
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x00104060 File Offset: 0x00102260
		public override void Write(Utf8JsonWriter writer, TBehaviorTreeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
