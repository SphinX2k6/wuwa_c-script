using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002368 RID: 9064
	public class EJigsawPieceStateJsonConverter : JsonConverter<EJigsawPieceState>
	{
		// Token: 0x0600C5D4 RID: 50644 RVA: 0x001CECC8 File Offset: 0x001CCEC8
		public override EJigsawPieceState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EJigsawPieceState.Disable;
			}
			return EJigsawPieceStateExtensions.FromString(@string);
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x001CECEC File Offset: 0x001CCEEC
		public override void Write(Utf8JsonWriter writer, EJigsawPieceState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
