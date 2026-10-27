using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236A RID: 9066
	public class EJigsawShapeJsonConverter : JsonConverter<EJigsawShape>
	{
		// Token: 0x0600C5DD RID: 50653 RVA: 0x001CEDDC File Offset: 0x001CCFDC
		public override EJigsawShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EJigsawShape.Circle;
			}
			return EJigsawShapeExtensions.FromString(@string);
		}

		// Token: 0x0600C5DE RID: 50654 RVA: 0x001CEE00 File Offset: 0x001CD000
		public override void Write(Utf8JsonWriter writer, EJigsawShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
