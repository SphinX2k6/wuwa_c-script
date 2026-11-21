using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C9 RID: 9673
	public class EHideTypeJsonConverter : JsonConverter<EHideType>
	{
		// Token: 0x0600D164 RID: 53604 RVA: 0x001E5588 File Offset: 0x001E3788
		public override EHideType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHideType.WorldMonsterAndMonsterTreasure;
			}
			return EHideTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D165 RID: 53605 RVA: 0x001E55AC File Offset: 0x001E37AC
		public override void Write(Utf8JsonWriter writer, EHideType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
