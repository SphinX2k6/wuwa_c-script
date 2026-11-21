using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AAE RID: 2734
	public class EQuickHackAutoCloseTypeJsonConverter : JsonConverter<EQuickHackAutoCloseType>
	{
		// Token: 0x06003C23 RID: 15395 RVA: 0x0009A6DC File Offset: 0x000988DC
		public override EQuickHackAutoCloseType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuickHackAutoCloseType.OnSkillSelected;
			}
			return EQuickHackAutoCloseTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x0009A700 File Offset: 0x00098900
		public override void Write(Utf8JsonWriter writer, EQuickHackAutoCloseType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
