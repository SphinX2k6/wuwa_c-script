using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025DF RID: 9695
	public class EJigsawShapeJsonConverter : JsonConverter<EJigsawShape>
	{
		// Token: 0x0600D1C7 RID: 53703 RVA: 0x001E70BC File Offset: 0x001E52BC
		public override EJigsawShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EJigsawShape.Circle;
			}
			return EJigsawShapeExtensions.FromString(@string);
		}

		// Token: 0x0600D1C8 RID: 53704 RVA: 0x001E70E0 File Offset: 0x001E52E0
		public override void Write(Utf8JsonWriter writer, EJigsawShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
