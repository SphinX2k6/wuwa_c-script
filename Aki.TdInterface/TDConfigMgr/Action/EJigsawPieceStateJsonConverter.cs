using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025DD RID: 9693
	public class EJigsawPieceStateJsonConverter : JsonConverter<EJigsawPieceState>
	{
		// Token: 0x0600D1BE RID: 53694 RVA: 0x001E6FA8 File Offset: 0x001E51A8
		public override EJigsawPieceState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EJigsawPieceState.Disable;
			}
			return EJigsawPieceStateExtensions.FromString(@string);
		}

		// Token: 0x0600D1BF RID: 53695 RVA: 0x001E6FCC File Offset: 0x001E51CC
		public override void Write(Utf8JsonWriter writer, EJigsawPieceState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
