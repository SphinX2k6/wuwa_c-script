using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002430 RID: 9264
	public class EStopNewMoveWithSplineTypeJsonConverter : JsonConverter<EStopNewMoveWithSplineType>
	{
		// Token: 0x0600C958 RID: 51544 RVA: 0x001D7BDC File Offset: 0x001D5DDC
		public override EStopNewMoveWithSplineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStopNewMoveWithSplineType.StopAtCurrentPos;
			}
			return EStopNewMoveWithSplineTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C959 RID: 51545 RVA: 0x001D7C00 File Offset: 0x001D5E00
		public override void Write(Utf8JsonWriter writer, EStopNewMoveWithSplineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
