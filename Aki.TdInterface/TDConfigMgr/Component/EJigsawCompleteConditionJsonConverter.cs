using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000985 RID: 2437
	public class EJigsawCompleteConditionJsonConverter : JsonConverter<EJigsawCompleteCondition>
	{
		// Token: 0x06003689 RID: 13961 RVA: 0x0008E1E8 File Offset: 0x0008C3E8
		public override EJigsawCompleteCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EJigsawCompleteCondition.ActivateAllCorrectPiece;
			}
			return EJigsawCompleteConditionExtensions.FromString(@string);
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x0008E20C File Offset: 0x0008C40C
		public override void Write(Utf8JsonWriter writer, EJigsawCompleteCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
