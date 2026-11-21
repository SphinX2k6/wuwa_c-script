using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC0 RID: 2752
	public class ERoleMotionInteractTypeJsonConverter : JsonConverter<ERoleMotionInteractType>
	{
		// Token: 0x06003C74 RID: 15476 RVA: 0x0009B168 File Offset: 0x00099368
		public override ERoleMotionInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoleMotionInteractType.PetalGrab;
			}
			return ERoleMotionInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x0009B18C File Offset: 0x0009938C
		public override void Write(Utf8JsonWriter writer, ERoleMotionInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
