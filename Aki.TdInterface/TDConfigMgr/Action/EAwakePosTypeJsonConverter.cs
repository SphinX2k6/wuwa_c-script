using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B6 RID: 8886
	public class EAwakePosTypeJsonConverter : JsonConverter<EAwakePosType>
	{
		// Token: 0x0600C2B3 RID: 49843 RVA: 0x001C7368 File Offset: 0x001C5568
		public override EAwakePosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAwakePosType.TransformVar;
			}
			return EAwakePosTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C2B4 RID: 49844 RVA: 0x001C738C File Offset: 0x001C558C
		public override void Write(Utf8JsonWriter writer, EAwakePosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
