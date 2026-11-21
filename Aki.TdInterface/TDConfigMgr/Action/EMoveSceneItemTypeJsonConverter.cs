using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200262B RID: 9771
	public class EMoveSceneItemTypeJsonConverter : JsonConverter<EMoveSceneItemType>
	{
		// Token: 0x0600D31D RID: 54045 RVA: 0x001EAEE0 File Offset: 0x001E90E0
		public override EMoveSceneItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveSceneItemType.MoveToPoint;
			}
			return EMoveSceneItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D31E RID: 54046 RVA: 0x001EAF04 File Offset: 0x001E9104
		public override void Write(Utf8JsonWriter writer, EMoveSceneItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
