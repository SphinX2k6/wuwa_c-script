using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D1 RID: 9937
	public class EStopNewMoveWithSplineTypeJsonConverter : JsonConverter<EStopNewMoveWithSplineType>
	{
		// Token: 0x0600D608 RID: 54792 RVA: 0x001F1AA4 File Offset: 0x001EFCA4
		public override EStopNewMoveWithSplineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStopNewMoveWithSplineType.StopAtCurrentPos;
			}
			return EStopNewMoveWithSplineTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D609 RID: 54793 RVA: 0x001F1AC8 File Offset: 0x001EFCC8
		public override void Write(Utf8JsonWriter writer, EStopNewMoveWithSplineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
