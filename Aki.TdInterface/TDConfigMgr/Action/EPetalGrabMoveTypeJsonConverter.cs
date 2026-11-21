using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002653 RID: 9811
	public class EPetalGrabMoveTypeJsonConverter : JsonConverter<EPetalGrabMoveType>
	{
		// Token: 0x0600D3D1 RID: 54225 RVA: 0x001EC5C8 File Offset: 0x001EA7C8
		public override EPetalGrabMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPetalGrabMoveType.Linear;
			}
			return EPetalGrabMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3D2 RID: 54226 RVA: 0x001EC5EC File Offset: 0x001EA7EC
		public override void Write(Utf8JsonWriter writer, EPetalGrabMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
