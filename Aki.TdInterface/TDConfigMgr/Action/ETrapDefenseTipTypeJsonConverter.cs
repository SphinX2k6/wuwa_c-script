using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002488 RID: 9352
	public class ETrapDefenseTipTypeJsonConverter : JsonConverter<ETrapDefenseTipType>
	{
		// Token: 0x0600CAE4 RID: 51940 RVA: 0x001DDCA4 File Offset: 0x001DBEA4
		public override ETrapDefenseTipType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrapDefenseTipType.OpenNewAreaTip;
			}
			return ETrapDefenseTipTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x001DDCC8 File Offset: 0x001DBEC8
		public override void Write(Utf8JsonWriter writer, ETrapDefenseTipType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
