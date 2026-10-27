using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CD RID: 2509
	public class EPetalGrabHandTypeJsonConverter : JsonConverter<EPetalGrabHandType>
	{
		// Token: 0x060037CD RID: 14285 RVA: 0x00090F28 File Offset: 0x0008F128
		public override EPetalGrabHandType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPetalGrabHandType.LeftHand;
			}
			return EPetalGrabHandTypeExtensions.FromString(@string);
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00090F4C File Offset: 0x0008F14C
		public override void Write(Utf8JsonWriter writer, EPetalGrabHandType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
