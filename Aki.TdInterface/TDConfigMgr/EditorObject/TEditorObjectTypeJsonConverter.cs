using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.EditorObject
{
	// Token: 0x0200000F RID: 15
	public class TEditorObjectTypeJsonConverter : JsonConverter<TEditorObjectType>
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00013FBC File Offset: 0x000121BC
		public override TEditorObjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TEditorObjectType.BehaviorTreeFragment;
			}
			return TEditorObjectTypeExtensions.FromString(@string);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00013FE0 File Offset: 0x000121E0
		public override void Write(Utf8JsonWriter writer, TEditorObjectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
