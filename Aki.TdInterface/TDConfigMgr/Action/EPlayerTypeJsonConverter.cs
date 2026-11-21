using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200266B RID: 9835
	public class EPlayerTypeJsonConverter : JsonConverter<EPlayerType>
	{
		// Token: 0x0600D43D RID: 54333 RVA: 0x001ED4FC File Offset: 0x001EB6FC
		public override EPlayerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerType.P1;
			}
			return EPlayerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D43E RID: 54334 RVA: 0x001ED520 File Offset: 0x001EB720
		public override void Write(Utf8JsonWriter writer, EPlayerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
