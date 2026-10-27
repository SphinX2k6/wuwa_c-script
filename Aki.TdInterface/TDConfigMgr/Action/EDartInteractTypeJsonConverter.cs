using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F8 RID: 8952
	public class EDartInteractTypeJsonConverter : JsonConverter<EDartInteractType>
	{
		// Token: 0x0600C3DC RID: 50140 RVA: 0x001C9B5C File Offset: 0x001C7D5C
		public override EDartInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDartInteractType.Machine;
			}
			return EDartInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C3DD RID: 50141 RVA: 0x001C9B80 File Offset: 0x001C7D80
		public override void Write(Utf8JsonWriter writer, EDartInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
