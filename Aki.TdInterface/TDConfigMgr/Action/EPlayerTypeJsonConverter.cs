using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D4 RID: 9172
	public class EPlayerTypeJsonConverter : JsonConverter<EPlayerType>
	{
		// Token: 0x0600C7BA RID: 51130 RVA: 0x001D3D50 File Offset: 0x001D1F50
		public override EPlayerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerType.P1;
			}
			return EPlayerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C7BB RID: 51131 RVA: 0x001D3D74 File Offset: 0x001D1F74
		public override void Write(Utf8JsonWriter writer, EPlayerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
