using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FB RID: 2555
	public class ERoleMotionInteractTypeJsonConverter : JsonConverter<ERoleMotionInteractType>
	{
		// Token: 0x0600389C RID: 14492 RVA: 0x00092878 File Offset: 0x00090A78
		public override ERoleMotionInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoleMotionInteractType.PetalGrab;
			}
			return ERoleMotionInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0009289C File Offset: 0x00090A9C
		public override void Write(Utf8JsonWriter writer, ERoleMotionInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
