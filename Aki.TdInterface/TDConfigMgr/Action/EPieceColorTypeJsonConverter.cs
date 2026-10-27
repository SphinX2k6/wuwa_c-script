using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CC RID: 9164
	public class EPieceColorTypeJsonConverter : JsonConverter<EPieceColorType>
	{
		// Token: 0x0600C796 RID: 51094 RVA: 0x001D3804 File Offset: 0x001D1A04
		public override EPieceColorType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPieceColorType.White;
			}
			return EPieceColorTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C797 RID: 51095 RVA: 0x001D3828 File Offset: 0x001D1A28
		public override void Write(Utf8JsonWriter writer, EPieceColorType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
