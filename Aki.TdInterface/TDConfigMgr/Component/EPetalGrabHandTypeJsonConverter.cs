using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A92 RID: 2706
	public class EPetalGrabHandTypeJsonConverter : JsonConverter<EPetalGrabHandType>
	{
		// Token: 0x06003BA5 RID: 15269 RVA: 0x000997E8 File Offset: 0x000979E8
		public override EPetalGrabHandType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPetalGrabHandType.LeftHand;
			}
			return EPetalGrabHandTypeExtensions.FromString(@string);
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x0009980C File Offset: 0x00097A0C
		public override void Write(Utf8JsonWriter writer, EPetalGrabHandType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
