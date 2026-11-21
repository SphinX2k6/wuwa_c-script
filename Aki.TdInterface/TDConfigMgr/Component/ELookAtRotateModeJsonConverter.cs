using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A48 RID: 2632
	public class ELookAtRotateModeJsonConverter : JsonConverter<ELookAtRotateMode>
	{
		// Token: 0x06003A58 RID: 14936 RVA: 0x00096A74 File Offset: 0x00094C74
		public override ELookAtRotateMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELookAtRotateMode.KeepInitialPitchRoll;
			}
			return ELookAtRotateModeExtensions.FromString(@string);
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00096A98 File Offset: 0x00094C98
		public override void Write(Utf8JsonWriter writer, ELookAtRotateMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
