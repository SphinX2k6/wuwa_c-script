using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E9 RID: 2537
	public class EQuickHackAutoCloseTypeJsonConverter : JsonConverter<EQuickHackAutoCloseType>
	{
		// Token: 0x0600384B RID: 14411 RVA: 0x00091E1C File Offset: 0x0009001C
		public override EQuickHackAutoCloseType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuickHackAutoCloseType.OnSkillSelected;
			}
			return EQuickHackAutoCloseTypeExtensions.FromString(@string);
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00091E40 File Offset: 0x00090040
		public override void Write(Utf8JsonWriter writer, EQuickHackAutoCloseType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
