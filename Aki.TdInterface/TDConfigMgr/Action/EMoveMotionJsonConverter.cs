using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239C RID: 9116
	public class EMoveMotionJsonConverter : JsonConverter<EMoveMotion>
	{
		// Token: 0x0600C6BE RID: 50878 RVA: 0x001D1AA4 File Offset: 0x001CFCA4
		public override EMoveMotion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveMotion.UniformMotion;
			}
			return EMoveMotionExtensions.FromString(@string);
		}

		// Token: 0x0600C6BF RID: 50879 RVA: 0x001D1AC8 File Offset: 0x001CFCC8
		public override void Write(Utf8JsonWriter writer, EMoveMotion value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
