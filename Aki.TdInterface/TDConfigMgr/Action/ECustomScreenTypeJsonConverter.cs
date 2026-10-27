using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F6 RID: 8950
	public class ECustomScreenTypeJsonConverter : JsonConverter<ECustomScreenType>
	{
		// Token: 0x0600C3D3 RID: 50131 RVA: 0x001C9A04 File Offset: 0x001C7C04
		public override ECustomScreenType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECustomScreenType.Spine;
			}
			return ECustomScreenTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C3D4 RID: 50132 RVA: 0x001C9A28 File Offset: 0x001C7C28
		public override void Write(Utf8JsonWriter writer, ECustomScreenType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
