using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200251B RID: 9499
	public class EAvgRoleAnimationTypeJsonConverter : JsonConverter<EAvgRoleAnimationType>
	{
		// Token: 0x0600CE55 RID: 52821 RVA: 0x001DEA8C File Offset: 0x001DCC8C
		public override EAvgRoleAnimationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgRoleAnimationType.Idle;
			}
			return EAvgRoleAnimationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE56 RID: 52822 RVA: 0x001DEAB0 File Offset: 0x001DCCB0
		public override void Write(Utf8JsonWriter writer, EAvgRoleAnimationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
