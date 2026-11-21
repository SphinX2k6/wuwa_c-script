using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ACE RID: 2766
	public class ESearchlightRotateAxisJsonConverter : JsonConverter<ESearchlightRotateAxis>
	{
		// Token: 0x06003CB3 RID: 15539 RVA: 0x0009B884 File Offset: 0x00099A84
		public override ESearchlightRotateAxis Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESearchlightRotateAxis.Yaw;
			}
			return ESearchlightRotateAxisExtensions.FromString(@string);
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x0009B8A8 File Offset: 0x00099AA8
		public override void Write(Utf8JsonWriter writer, ESearchlightRotateAxis value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
