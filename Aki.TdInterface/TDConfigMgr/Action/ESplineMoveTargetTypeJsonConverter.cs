using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026CD RID: 9933
	public class ESplineMoveTargetTypeJsonConverter : JsonConverter<ESplineMoveTargetType>
	{
		// Token: 0x0600D5F6 RID: 54774 RVA: 0x001F1794 File Offset: 0x001EF994
		public override ESplineMoveTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMoveTargetType.Entity;
			}
			return ESplineMoveTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x001F17B8 File Offset: 0x001EF9B8
		public override void Write(Utf8JsonWriter writer, ESplineMoveTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
