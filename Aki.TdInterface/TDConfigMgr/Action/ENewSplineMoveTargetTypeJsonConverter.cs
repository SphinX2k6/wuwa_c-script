using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002637 RID: 9783
	public class ENewSplineMoveTargetTypeJsonConverter : JsonConverter<ENewSplineMoveTargetType>
	{
		// Token: 0x0600D353 RID: 54099 RVA: 0x001EB61C File Offset: 0x001E981C
		public override ENewSplineMoveTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENewSplineMoveTargetType.Player;
			}
			return ENewSplineMoveTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D354 RID: 54100 RVA: 0x001EB640 File Offset: 0x001E9840
		public override void Write(Utf8JsonWriter writer, ENewSplineMoveTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
