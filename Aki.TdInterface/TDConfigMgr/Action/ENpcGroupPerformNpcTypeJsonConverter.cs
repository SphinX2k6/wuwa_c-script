using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B0 RID: 9136
	public class ENpcGroupPerformNpcTypeJsonConverter : JsonConverter<ENpcGroupPerformNpcType>
	{
		// Token: 0x0600C718 RID: 50968 RVA: 0x001D26B0 File Offset: 0x001D08B0
		public override ENpcGroupPerformNpcType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcGroupPerformNpcType.LevelBCommonMale;
			}
			return ENpcGroupPerformNpcTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C719 RID: 50969 RVA: 0x001D26D4 File Offset: 0x001D08D4
		public override void Write(Utf8JsonWriter writer, ENpcGroupPerformNpcType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
