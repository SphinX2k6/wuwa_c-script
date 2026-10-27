using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001251 RID: 4689
	public class EKurotatoSystemVarTypeJsonConverter : JsonConverter<EKurotatoSystemVarType>
	{
		// Token: 0x06006A15 RID: 27157 RVA: 0x000FE5F8 File Offset: 0x000FC7F8
		public override EKurotatoSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EKurotatoSystemVarType.Gold;
			}
			return EKurotatoSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x000FE61C File Offset: 0x000FC81C
		public override void Write(Utf8JsonWriter writer, EKurotatoSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
