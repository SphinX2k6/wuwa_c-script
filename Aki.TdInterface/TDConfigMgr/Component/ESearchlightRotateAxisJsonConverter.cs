using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A09 RID: 2569
	public class ESearchlightRotateAxisJsonConverter : JsonConverter<ESearchlightRotateAxis>
	{
		// Token: 0x060038DB RID: 14555 RVA: 0x00092F94 File Offset: 0x00091194
		public override ESearchlightRotateAxis Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESearchlightRotateAxis.Yaw;
			}
			return ESearchlightRotateAxisExtensions.FromString(@string);
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x00092FB8 File Offset: 0x000911B8
		public override void Write(Utf8JsonWriter writer, ESearchlightRotateAxis value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
