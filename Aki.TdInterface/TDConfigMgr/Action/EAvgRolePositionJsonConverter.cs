using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AE RID: 8878
	public class EAvgRolePositionJsonConverter : JsonConverter<EAvgRolePosition>
	{
		// Token: 0x0600C28F RID: 49807 RVA: 0x001C6E3C File Offset: 0x001C503C
		public override EAvgRolePosition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgRolePosition.Center;
			}
			return EAvgRolePositionExtensions.FromString(@string);
		}

		// Token: 0x0600C290 RID: 49808 RVA: 0x001C6E60 File Offset: 0x001C5060
		public override void Write(Utf8JsonWriter writer, EAvgRolePosition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
