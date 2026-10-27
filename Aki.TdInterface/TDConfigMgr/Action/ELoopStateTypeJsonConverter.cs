using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237A RID: 9082
	public class ELoopStateTypeJsonConverter : JsonConverter<ELoopStateType>
	{
		// Token: 0x0600C625 RID: 50725 RVA: 0x001D0734 File Offset: 0x001CE934
		public override ELoopStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELoopStateType.Prev;
			}
			return ELoopStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C626 RID: 50726 RVA: 0x001D0758 File Offset: 0x001CE958
		public override void Write(Utf8JsonWriter writer, ELoopStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
