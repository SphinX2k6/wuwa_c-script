using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200263D RID: 9789
	public class ENpcGroupPerformNpcTypeJsonConverter : JsonConverter<ENpcGroupPerformNpcType>
	{
		// Token: 0x0600D36E RID: 54126 RVA: 0x001EB92C File Offset: 0x001E9B2C
		public override ENpcGroupPerformNpcType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcGroupPerformNpcType.LevelBCommonMale;
			}
			return ENpcGroupPerformNpcTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D36F RID: 54127 RVA: 0x001EB950 File Offset: 0x001E9B50
		public override void Write(Utf8JsonWriter writer, ENpcGroupPerformNpcType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
