using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002408 RID: 9224
	public class ESetJigsawFoundationTypeJsonConverter : JsonConverter<ESetJigsawFoundationType>
	{
		// Token: 0x0600C8A4 RID: 51364 RVA: 0x001D5C80 File Offset: 0x001D3E80
		public override ESetJigsawFoundationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetJigsawFoundationType.SetPieceState;
			}
			return ESetJigsawFoundationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8A5 RID: 51365 RVA: 0x001D5CA4 File Offset: 0x001D3EA4
		public override void Write(Utf8JsonWriter writer, ESetJigsawFoundationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
