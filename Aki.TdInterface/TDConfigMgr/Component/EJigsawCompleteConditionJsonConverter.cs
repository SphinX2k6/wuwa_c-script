using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A38 RID: 2616
	public class EJigsawCompleteConditionJsonConverter : JsonConverter<EJigsawCompleteCondition>
	{
		// Token: 0x06003A10 RID: 14864 RVA: 0x00096154 File Offset: 0x00094354
		public override EJigsawCompleteCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EJigsawCompleteCondition.ActivateAllCorrectPiece;
			}
			return EJigsawCompleteConditionExtensions.FromString(@string);
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00096178 File Offset: 0x00094378
		public override void Write(Utf8JsonWriter writer, EJigsawCompleteCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
