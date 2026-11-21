using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C7 RID: 9927
	public class ESplineMoveDriveModeJsonConverter : JsonConverter<ESplineMoveDriveMode>
	{
		// Token: 0x0600D5DB RID: 54747 RVA: 0x001F12D8 File Offset: 0x001EF4D8
		public override ESplineMoveDriveMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMoveDriveMode.InputDriven;
			}
			return ESplineMoveDriveModeExtensions.FromString(@string);
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x001F12FC File Offset: 0x001EF4FC
		public override void Write(Utf8JsonWriter writer, ESplineMoveDriveMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
