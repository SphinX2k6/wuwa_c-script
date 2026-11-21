using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C5 RID: 9925
	public class ESplineMoveConfigTypeJsonConverter : JsonConverter<ESplineMoveConfigType>
	{
		// Token: 0x0600D5D2 RID: 54738 RVA: 0x001F11C4 File Offset: 0x001EF3C4
		public override ESplineMoveConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMoveConfigType.Open;
			}
			return ESplineMoveConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D5D3 RID: 54739 RVA: 0x001F11E8 File Offset: 0x001EF3E8
		public override void Write(Utf8JsonWriter writer, ESplineMoveConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
