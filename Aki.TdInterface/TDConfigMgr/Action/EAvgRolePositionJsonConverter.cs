using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200251D RID: 9501
	public class EAvgRolePositionJsonConverter : JsonConverter<EAvgRolePosition>
	{
		// Token: 0x0600CE5E RID: 52830 RVA: 0x001DEC44 File Offset: 0x001DCE44
		public override EAvgRolePosition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgRolePosition.Center;
			}
			return EAvgRolePositionExtensions.FromString(@string);
		}

		// Token: 0x0600CE5F RID: 52831 RVA: 0x001DEC68 File Offset: 0x001DCE68
		public override void Write(Utf8JsonWriter writer, EAvgRolePosition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
