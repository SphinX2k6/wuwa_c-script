using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002531 RID: 9521
	public class EBlendAnimTypeJsonConverter : JsonConverter<EBlendAnimType>
	{
		// Token: 0x0600CEB8 RID: 52920 RVA: 0x001DF860 File Offset: 0x001DDA60
		public override EBlendAnimType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBlendAnimType.StateMachine;
			}
			return EBlendAnimTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CEB9 RID: 52921 RVA: 0x001DF884 File Offset: 0x001DDA84
		public override void Write(Utf8JsonWriter writer, EBlendAnimType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
