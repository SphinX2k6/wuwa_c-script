using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A7 RID: 9895
	public class ESetJigsawFoundationTypeJsonConverter : JsonConverter<ESetJigsawFoundationType>
	{
		// Token: 0x0600D54B RID: 54603 RVA: 0x001EF87C File Offset: 0x001EDA7C
		public override ESetJigsawFoundationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetJigsawFoundationType.SetPieceState;
			}
			return ESetJigsawFoundationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D54C RID: 54604 RVA: 0x001EF8A0 File Offset: 0x001EDAA0
		public override void Write(Utf8JsonWriter writer, ESetJigsawFoundationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
