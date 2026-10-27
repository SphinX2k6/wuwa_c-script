using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1B RID: 2587
	public class ESpecialNpcTypeJsonConverter : JsonConverter<ESpecialNpcType>
	{
		// Token: 0x0600392C RID: 14636 RVA: 0x00093974 File Offset: 0x00091B74
		public override ESpecialNpcType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialNpcType.BaseRoleNpc;
			}
			return ESpecialNpcTypeExtensions.FromString(@string);
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x00093998 File Offset: 0x00091B98
		public override void Write(Utf8JsonWriter writer, ESpecialNpcType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
