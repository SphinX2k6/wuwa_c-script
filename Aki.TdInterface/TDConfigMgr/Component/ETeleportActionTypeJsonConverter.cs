using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A35 RID: 2613
	public class ETeleportActionTypeJsonConverter : JsonConverter<ETeleportActionType>
	{
		// Token: 0x060039A1 RID: 14753 RVA: 0x00094C20 File Offset: 0x00092E20
		public override ETeleportActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleportActionType.Dodge;
			}
			return ETeleportActionTypeExtensions.FromString(@string);
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00094C44 File Offset: 0x00092E44
		public override void Write(Utf8JsonWriter writer, ETeleportActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
